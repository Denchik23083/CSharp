using System;
using System.Collections.Generic;
using Blazor.Db.Entities;

namespace Blazor.WebDb
{
    public class GameRepository : IGameRepository
    {
        public List<Game> GetAllGames()
        {
            return new List<Game>
            {
                new()
                {
                    Name = "Denis",
                    Genre = "Male",
                    ReleaseDate = new DateTime(2003, 08, 23)
                },
                new()
                {
                    Name = "Info",
                    Genre = "Happy",
                    ReleaseDate = new DateTime(2002, 01, 25)
                }
            };
        }
    }
}