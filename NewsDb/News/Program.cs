using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NewsDb;
using NewsDb.News;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NewsGet
{
    class Program
    {
        private static HttpClient _client = new HttpClient();

        private static NewsDbContext _context = new NewsDbContext();

        static async Task Main(string[] args)
        {
            var load = LoadFromJson();

            List<News> list = GiveJson(load.Result);

            foreach (var item in list)
            {
                var news = new News
                {
                    Seo = item.Seo,
                    Title = item.Title,
                    ReadMore = item.ReadMore,
                    NewsCount = item.NewsCount
                };

                _context.News.Add(news);

                await _context.SaveChangesAsync();
            }
        }

        private static Task<string> LoadFromJson()
        {
            var jsonString = _client.GetStringAsync("https://www.ukr.net/ajax/start.json");

            jsonString.Wait();

            return jsonString;
        }

        private static List<News> GiveJson(string result)
        {
            List<News> list = new List<News>();

            var obj = (JObject)JsonConvert.DeserializeObject(result);

            var index = 0;

            while (obj["news"][index] != obj["news"].Last)
            {
                var newNews = obj["news"][index];

                var news = new News
                {
                    Seo = newNews["seo"].ToString(),
                    Title = newNews["title"].ToString(),
                    ReadMore = newNews["readMore"].ToString(),
                    NewsCount = int.Parse(newNews["newsCount"].ToString()),
                };

                list.Add(news);

                index++;
            }

            return list;
        }
    }
}
