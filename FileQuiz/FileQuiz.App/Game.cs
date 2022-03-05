using System;
using FileQuiz.Logic;

namespace FileQuiz.App
{
    public class Game
    {
        private readonly IFileQuizService _service;

        public Game(IFileQuizService service)
        {
            _service = service;
        }

        public bool Auth()
        {
            bool isLogin = false;

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
                            isLogin = true;
                        }
                    }
                    break;
                case 2:
                    var resultLogin = _service.Login();
                    if (resultLogin)
                    {
                        isLogin = true;
                    }
                    break;
                default:
                    Auth();
                    break;
            }

            return isLogin;
        }
    }
}
