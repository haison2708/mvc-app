namespace Web.ViewModels
{
    public class CartViewModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string UserId { get; set; }
        public ProductViewModel Product { get; init; }
    }
}
