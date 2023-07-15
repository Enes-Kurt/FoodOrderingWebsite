namespace MVCFoodShop.Entities
{
    public class Menu:BaseEntity
    {
        public Menu()
        {
            Products = new HashSet<Product>();
        }
        public string MenuName { get; set; }
        public decimal Price { get; set; }

        public bool IsActive { get; set; }

        public int FoodCount { get; set; }
        public int beverageCount { get; set; }
        public int SauceCount { get; set; }
        public string? CoverImage { get; set; }

        public ICollection<Product> Products { get; set; }  
    }
}
