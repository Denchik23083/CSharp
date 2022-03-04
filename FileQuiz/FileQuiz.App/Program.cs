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

            game.Auth();
        }

        private static IFileQuizService LogicWebDb()
        {
            var repository = new FileQuizRepository();
            var service = new FileQuizService(repository);

            return service;
        }
    }
}
