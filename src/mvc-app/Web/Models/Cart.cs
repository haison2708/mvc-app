using Web.Data;

namespace Web.Models
{
    public class Cart : Entity
    {
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsOrder { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
        public Product Product { get; init; }
        public User User { get; set; }
    }
}
