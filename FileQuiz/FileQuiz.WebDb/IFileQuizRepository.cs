using FileQuiz.Db;

namespace FileQuiz.WebDb
{
    public interface IFileQuizRepository
    {
        public bool Register(User user);

        public bool Login(User user);

        public void Section(string sectionFile);
    }
}
