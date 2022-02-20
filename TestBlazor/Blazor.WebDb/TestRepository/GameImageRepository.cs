using System;
using System.Collections.Generic;
using System.Linq;
using Blazor.Db.Entities.TestModel23;

namespace Blazor.WebDb.TestRepository
{
    public class GameImageRepository : IGameImageRepository
    {
        private readonly List<GameImage> _games;

        public GameImageRepository()
        {
            new GenreImageRepository().GetAllGenres();

            _games = new List<GameImage>
            {
                new()
                {
                    Id = 1,
                    Name = "Denis",
                    Description = "My name",
                    GameGenre = GetRandomGenres(1),
                    ReleaseDate = new DateTime(2003, 08, 23),
                    Image = "https://bipbap.ru/wp-content/uploads/2017/08/04.-risunki-dlya-srisovki-legkie-dlya-devochek.jpg",
                    InSale = false,
                },
                new()
                {
                    Id = 2,
                    Name = "Info",
                    Description = "Picture of SpongeBob",
                    GameGenre = GetRandomGenres(2),
                    ReleaseDate = new DateTime(2002, 01, 25),
                    Image = "https://img2.akspic.ru/previews/5/7/1/6/6/166175/166175-gubka_bob-multfilm-multik-bikini_bottom-nikelodeon-500x.jpg",
                    InSale = true,
                },
            };
        }

        public List<GameImage> GetAllGames()
        {
            return _games;
        }

        public GameImage GetGameById(int id)
        {
            return _games.FirstOrDefault(g => g.Id == id);
        }

        public bool CreateNewGame(GameImage game)
        {
            if (game is null)
            {
                return false;
            }

            game.Id = _games.Max(x => x.Id) + 1;
            _games.Add(game);

            return true;
        }

        public bool UpdateGame(GameImage gameToUpdate)
        {
            var game = _games.FirstOrDefault(x => x.Id == gameToUpdate.Id);

            if (game is null)
            {
                return false;
            }

            game.Name = gameToUpdate.Name;
            game.Description = gameToUpdate.Description;
            game.GameGenre = gameToUpdate.GameGenre;
            game.Image = gameToUpdate.Image;
            game.ReleaseDate = gameToUpdate.ReleaseDate;
            game.GamePlayVideo = gameToUpdate.GamePlayVideo;
            game.InSale = gameToUpdate.InSale;

            return true;
        }

        public bool Remove(GameImage gameToDelete)
        {
            var result = _games.Remove(gameToDelete);

            if (!result)
            {
                return false;
            }

            return true;
        }

        List<GameGenreImage> GetRandomGenres(int gameId)
        {
            var rnd = new Random(DateTime.Now.Millisecond);

            var genre = new GenreImageRepository().GetAllGenres();

            var randomGenreCount = rnd.Next(1, genre.Count);

            var genresForReturn = new List<GameGenreImage>();

            for (int i = 0; i < randomGenreCount; i++)
            {
                var genreId = rnd.Next(1, genre.Count);

                var result = genre.FirstOrDefault(x => x.Id == genreId);

                if (result is not null)
                {
                    genresForReturn.Add(
                        new GameGenreImage
                        {
                            GameId = gameId,
                            GenreId = genreId
                        });
                }
            }

            return genresForReturn;
        }
    }
}