using System;
using System.IO;
using FileQuiz.Db;

namespace FileQuiz.WebDb
{
    public class FileQuizRepository : IFileQuizRepository, IDisposable
    {
        private StreamWriter _textWriter;
        private FileStream _fileStream;
        private StreamReader _textReader;
        private string authFile = "test.txt";

        public bool Register(User user)
        {
            _textWriter = new StreamWriter(authFile);
            _textWriter.Write(user.Email + "\n" + user.Password + "\n" + user.Name);
            _textWriter.Close();

            Console.WriteLine("You registered! Now Enter" + "\n");

            return true;
        }

        public bool Login(User user)
        {
            var emailFromFile = string.Empty;
            var passwordFromFile = string.Empty;

            _fileStream = new FileStream(authFile, FileMode.OpenOrCreate);
            _textReader = new StreamReader(_fileStream);

            while (!_textReader.EndOfStream)
            {
                emailFromFile = _textReader.ReadLine();
                passwordFromFile = _textReader.ReadLine();

                break;
            }

            _fileStream.Close();
            
            if (user.Email == emailFromFile && user.Password == passwordFromFile)
            {
                return true;
            }

            return false;
        }

        public void Section(string sectionFile)
        {
            var numQuest = 0;
            var res = 0;

            do
            {
                _fileStream = new FileStream(sectionFile, FileMode.OpenOrCreate);
                _textReader = new StreamReader(_fileStream);
                while (!_textReader.EndOfStream)
                {
                    string question = _textReader.ReadLine();
                    Console.WriteLine(question);

                    var answer = int.Parse(Console.ReadLine());
                    if (answer == 3) { res++; }

                    if (numQuest <= 1) { numQuest++; }
                }
                _fileStream.Close();
            } while (numQuest != 1);
            Console.WriteLine($"Your result is {res} of {numQuest}");
        }

        public void Dispose()
        {
            _fileStream.Dispose();
            _textReader.Dispose();
            _textReader.Dispose();
        }
    }
}
