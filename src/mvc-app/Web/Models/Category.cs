using Web.Data;

namespace Web.Models
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
