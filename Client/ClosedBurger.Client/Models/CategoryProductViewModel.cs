namespace ClosedBurger.Client.Models
{
    public class CategoryProductViewModel
    {
        public Category Category { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
