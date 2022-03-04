using System;
using System.IO;
using FileQuiz.Logic;

namespace FileQuiz.App
{
    public class Game
    {
        private readonly IFileQuizService _service;
        private StreamWriter _textWriter;
        private FileStream _fileStream;
        private StreamReader _textReader;
        private string file = "test.txt";

        public Game(IFileQuizService service)
        {
            _service = service;
        }

        public void Auth()
        {
            Console.WriteLine("1) Register" + "\n" + "2) Login");
            var game = int.Parse(Console.ReadLine() + "\n");
            Console.WriteLine();

            switch (game)
            {
                case 1:
                    var resultResister = _service.Register();
                    if (resultResister)
                    {
                        var resultLoginWithRegister = _service.Login();
                        if (resultLoginWithRegister)
                        {
                            Quiz();
                        }
                    }
                    break;
                case 2:
                    var resultLogin = _service.Login();
                    if (resultLogin)
                    {
                        Quiz();
                    }
                    break;
                default: throw new ArgumentException();
            }
        }

        private void Quiz()
        {
            Console.WriteLine("1) Start" + "\n" + "2) Exit");
            var choose = int.Parse(Console.ReadLine() + "\n");
            Console.WriteLine();

            var quiz = new Quiz();

            switch (choose)
            {
                case 1:
                    quiz.StartQuiz();
                    break;
                case 2:
                    break;
                default: throw new ArgumentException();
            }
        }
    }
}
