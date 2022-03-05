using System;
using FileQuiz.Logic;

namespace FileQuiz.App
{
    public class Quiz
    {
        private readonly IFileQuizService _service;
        
        public Quiz(IFileQuizService service)
        {
            _service = service;
        }

        public void StartQuiz()
        {
            Console.WriteLine(
                "Enter section" 
                + "\n" + "1) History"
                + "\n" + "2) Geography"
                + "\n" + "3) Biology" 
                + "\n" + "Your choose is: ");

            Console.WriteLine();
            var choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    _service.Section("history.txt");
                    break;
                case 2:
                    _service.Section("geography.txt");
                    break;
                case 3:
                    _service.Section("biology.txt");
                    break;
                default:
                    StartQuiz();
                    break;
            }
        }
    }
}
