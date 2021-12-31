using System;
using System.Linq;
using ControllerApp;
using Db;
using Db.Entities;
using RepositoryApp;
using ServiceApp;

namespace RepositoryService
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = Controller();

            GetAll(controller);

            GetId(controller);

            CreateBook(controller);

            UpdateBook(controller);

            RemoveBook(controller);
        }

        private static Controller Controller()
        {
            IRepository repository = new Repository();
            IService service = new Service(repository);

            var controller = new Controller(service);

            return controller;
        }

        private static void GetAll(Controller controller)
        {
            controller.GetAll();
        }

        private static void GetId(Controller controller)
        {
            controller.Get(8);
        }

        private static void CreateBook(Controller controller)
        {
            var book = new Book
            {
                Title = "Гарри Поттер и печера страха",
                Author = "Дж. Роуль",
                PagesCount = 200,
                PublishDate = new DateTime(1989, 01, 11)
            };

            controller.Create(book);
        }

        private static void UpdateBook(Controller controller)
        {
            var bookUpdate = new Book
            {
                Title = "Гарри Поттер и пытка",
                Author = "Дж. Роуль",
                PagesCount = 1000,
                PublishDate = new DateTime(1979, 01, 11)
            };

            controller.Update(bookUpdate, 3);
        }

        private static void RemoveBook(Controller controller)
        {
            controller.Remove(1);
        }
    }
}
