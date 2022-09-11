using Web.Data;

namespace Web.Models
{
    public class ProductImage : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public Product Product { get; set; }
    }
}
