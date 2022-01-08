namespace MvcEntity.Web.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public string ContactPhone { get; set; }

        public int UserId { get; set; }

        public int PhoneId { get; set; }
    }
}