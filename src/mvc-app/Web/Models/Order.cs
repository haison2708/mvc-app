using Web.Data;

namespace Web.Models
{
    public class Order : Entity
    {
        public string UserId { get; set; }
        public string? Address { get; set; }
        public int Total { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
    }
}
