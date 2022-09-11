using Web.Data;

namespace Web.Models
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public string Brand { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeleted { get; set; }
        public Category Category { get; set; }
        public ICollection<OrderDetail>? OrderDetails { get; set; }
        public ICollection<ProductImage>? ProductImages { get; set; }
    }
}
