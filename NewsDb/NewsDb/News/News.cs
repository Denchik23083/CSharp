using Newtonsoft.Json;

namespace NewsDb.News
{
    public class News
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("seo")]
        public string Seo { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("readMore")] 
        public string ReadMore { get; set; }

        [JsonProperty("newsCount")]
        public int NewsCount { get; set; }
    }
}
