using System;
using System.IO;

namespace FileQuiz.App
{
    public class Quiz
    {
        private FileStream _fileStream;
        private StreamReader _textReader;
        
        public void StartQuiz()
        {
            Console.WriteLine();
            Console.WriteLine("Enter section");
            Console.WriteLine("1) History");
            Console.WriteLine("2) Geography");
            Console.WriteLine("3) Biology");
            Console.Write("Your choose is: ");
            Console.WriteLine();
            var choose = int.Parse(Console.ReadLine());

            if (choose == 1) History("history.txt");
            else if (choose == 2) Geography("geography.txt");
            else if (choose == 3) Biology("biology.txt");
            else throw new ArgumentException();
        }
        private void History(string file)
        {
            var numQuest = 0;
            var res = 0;

            do
            {
                _fileStream = new FileStream(file, FileMode.OpenOrCreate);
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
        private void Biology(string file)
        {
            var numQuest = 0;
            var res = 0;

            do
            {
                _fileStream = new FileStream(file, FileMode.OpenOrCreate);
                _textReader = new StreamReader(_fileStream);
                while (!_textReader.EndOfStream)
                {
                    string question = _textReader.ReadLine();
                    Console.WriteLine(question);

                    var answer = int.Parse(Console.ReadLine());
                    if (answer == 2) { res++; }

                    if (numQuest <= 1) { numQuest++; }
                }
                _fileStream.Close();
            } while (numQuest != 1);
            Console.WriteLine($"Your result is {res} of {numQuest}");
        }
        private void Geography(string file)
        {
            var numQuest = 0;
            var res = 0;

            do
            {
                _fileStream = new FileStream(file, FileMode.OpenOrCreate);
                _textReader = new StreamReader(_fileStream);
                while (!_textReader.EndOfStream)
                {
                    string question = _textReader.ReadLine();
                    Console.WriteLine(question);
                    var answer = int.Parse(Console.ReadLine());
                    if (answer == 2) { res++; }

                    if (numQuest <= 1) { numQuest++; }
                }
                _fileStream.Close();
            } while (numQuest != 1);
            Console.WriteLine($"Your result is {res} of {numQuest}");
        }
    }
}
