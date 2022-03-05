namespace FileQuiz.Logic
{
    public interface IFileQuizService
    {
        public bool Register();

        public bool Login();

        public void Section(string sectionFile);
    }
}
