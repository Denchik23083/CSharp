﻿using System;
using System.Collections.Generic;
using Blazor.Db.Entities.TestModel2;

namespace Blazor.WebDb.TestRepository
{
    public class GameImageRepository : IGameImageRepository
    {
        public List<GameImage> GetAllGames()
        {
            return new List<GameImage>
            {
                new()
                {
                    Name = "Denis",
                    Genre = "Male",
                    ReleaseDate = new DateTime(2003, 08, 23),
                    Image = "https://bipbap.ru/wp-content/uploads/2017/08/04.-risunki-dlya-srisovki-legkie-dlya-devochek.jpg",
                },
                new()
                {
                    Name = "Info",
                    Genre = "Happy",
                    ReleaseDate = new DateTime(2002, 01, 25),
                    Image = "https://img2.akspic.ru/previews/5/7/1/6/6/166175/166175-gubka_bob-multfilm-multik-bikini_bottom-nikelodeon-500x.jpg",
                }
            };
        }
    }
}