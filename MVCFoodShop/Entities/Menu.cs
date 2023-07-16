namespace MVCFoodShop.Entities
{
    public class Menu:BaseEntity
    {
        public Menu()
        {
            Products = new HashSet<Product>();
        }
        public string MenuName { get; set; }
        public int FoodCount { get; set; }
        public int BeverageCount { get; set; }
        public int SauceCount { get; set; }
        public decimal MenuPrice { get; set; }
        public bool MenuIsActive { get; set; }
        public string? MenuCoverImage { get; set; }
        public string? MenuDeclaration { get; set; }

        public ICollection<Product> Products { get; set; }  
    }
}
