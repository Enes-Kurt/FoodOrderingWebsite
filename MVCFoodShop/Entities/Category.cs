namespace MVCFoodShop.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string CategoryName { get; set; }
        public bool CategoryIsActive { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
