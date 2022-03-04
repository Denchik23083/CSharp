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
        private string file = "test.txt";

        public bool Register(User user)
        {
            _textWriter = new StreamWriter(file);
            _textWriter.Write(user.Email + "\n" + user.Password + "\n" + user.Name);
            _textWriter.Close();

            Console.WriteLine("You registered! Now Enter" + "\n");

            return true;
        }

        public bool Login(User user)
        {
            var emailFromFile = string.Empty;
            var passwordFromFile = string.Empty;

            _fileStream = new FileStream(file, FileMode.OpenOrCreate);
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

        public void Dispose()
        {
            _fileStream.Dispose();
            _textReader.Dispose();
            _textReader.Dispose();
        }
    }
}
