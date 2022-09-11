namespace Web.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
        public IList<CategoryViewModel>? Categories { get; set; }
    }
}
