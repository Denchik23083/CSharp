namespace MvcEntity.Db.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Balance { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}