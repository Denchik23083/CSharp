using System;
using FileQuiz.Logic;
using FileQuiz.WebDb;

namespace FileQuiz.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            var logic = LogicWebDb();
            
            var game = new Game(logic);

            var isLogin = game.Auth();

            Quiz(isLogin);
        }

        private static void Quiz(bool isLogic)
        {
            if (isLogic)
            {
                Console.WriteLine("1) Start" + "\n" + "2) Exit");
                var choose = int.Parse(Console.ReadLine() + "\n");
                Console.WriteLine();

                var logic = LogicWebDb();

                var quiz = new Quiz(logic);

                switch (choose)
                {
                    case 1:
                        quiz.StartQuiz();
                        break;
                    case 2:
                        break;
                    default:
                        Quiz(true);
                        break;
                }
            }
        }

        private static IFileQuizService LogicWebDb()
        {
            var repository = new FileQuizRepository();
            var service = new FileQuizService(repository);

            return service;
        }
    }
}
