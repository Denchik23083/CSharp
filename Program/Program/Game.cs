using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Program
{
    public class Game : IDisposable
    {
        private StreamWriter _textWriter;
        private FileStream _fileStream;
        private StreamReader _textReader;
        private string file = "test.txt";

        public string _login { get; set; }
        public string _password { get; set; }
        private string _date { get; set; }
        public void Start()
        {
            Console.WriteLine("HALLO!");
            Console.WriteLine("1) Register");
            Console.WriteLine("2) Login");
            var game = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            if (game == 1) register();
            else if (game == 2) Log();
            else throw new ArgumentException();

            Console.WriteLine();
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Exit"); 
            var choose = int.Parse(Console.ReadLine());
            var victorina = new Victorina();
            
            if (choose == 1) victorina.StartVictorina();
            else if (choose == 2) victorina.Exit();
            else throw new ArgumentException();
        }
        private void Log()
        {
            Console.WriteLine("Enter your Login");
            var login = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter your Password");
            var password = Console.ReadLine();
            
            string logFromFile = string.Empty;
            string passFromFile = string.Empty;

            _fileStream = new FileStream(file, FileMode.OpenOrCreate);
            _textReader = new StreamReader(_fileStream);
            while (!_textReader.EndOfStream)
            {
                var logFrom = _textReader.ReadLine();
                var passFrom = _textReader.ReadLine();

                logFromFile = logFrom;
                passFromFile = passFrom;

                break;
            }
            _fileStream.Close();
            
            while(login != logFromFile || password != passFromFile)
            {
                if (login == logFromFile && password == passFromFile)
                {
                    break;
                }
                else if (login == logFromFile || password != passFromFile)
                {
                    Console.WriteLine("Bad password");
                    Log();
                }
                else if (login != logFromFile || password == passFromFile)
                {
                    Console.WriteLine("Bad login");
                    Log();
                }
                else {  }
            }
        }
        private void register()
        {
            Console.WriteLine("Enter your Login");
            var login = Console.ReadLine();
            _login = login;

            Console.WriteLine("Enter your Password");
            var password = Console.ReadLine();
            _password = password;

            Console.WriteLine("Enter your Date");
            var date = Console.ReadLine();
            _date = date;

            _textWriter = new StreamWriter(file);
            _textWriter.Write(_login + "\n" + _password + "\n" + _date);
            _textWriter.Close();

            Console.WriteLine("You registered! Now Enter\n");

            Log();
        }
        public void Dispose(){}
    }

    class Victorina : Game
    {
        private FileStream _fileStream;
        private StreamReader _textReader;

        public void Exit()
        {
            return;
        }
        public void StartVictorina()
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
                    if (answer == 3){res++;}

                    if (numQuest <= 1){numQuest++;}
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
                    if (answer == 2){res++;}

                    if (numQuest <= 1){numQuest++;}
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
                    if (answer == 2){res++;}
                    
                    if (numQuest <= 1){numQuest++;}
                }
                _fileStream.Close();
            } while (numQuest != 1);
            Console.WriteLine($"Your result is {res} of {numQuest}");
        }
    }
}
