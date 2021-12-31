using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            using var game = new Game();

            game.Start();
        }
    }
}
