using System;
using FileQuiz.Db;
using FileQuiz.WebDb;

namespace FileQuiz.Logic
{
    public class FileQuizService : IFileQuizService
    {
        private readonly IFileQuizRepository _repository;

        public FileQuizService(IFileQuizRepository repository)
        {
            _repository = repository;
        }

        public bool Register()
        {
            Console.WriteLine("Enter your Name");
            var name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your Email");
            var email = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your Password");
            var password = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Confirm your Password");
            var confirmPassword = Console.ReadLine();
            Console.WriteLine();

            if (password == confirmPassword)
            {
                var register = new Register
                {
                    Name = name,
                    Email = email,
                    Password = password,
                    ConfirmPassword = confirmPassword,
                };

                return _repository.Register(Map(register));
            }

            Console.WriteLine("You not registered!");
            Console.WriteLine();

            return false;
        }

        public bool Login()
        {
            Console.WriteLine("Enter your Email");
            var email = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your Password");
            var password = Console.ReadLine();
            Console.WriteLine();

            var login = new Login
            {
                Email = email,
                Password = password,
            };

            var result = _repository.Login(Map(login));

            if (!result)
            {
                Login();
            }

            return true;
        }

        public void Section(string sectionFile)
        {
            _repository.Section(sectionFile);
        }
        
        private static User Map(Register model)
        {
            return new User
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
            };
        }

        private static User Map(Login model)
        {
            return new User
            {
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}
