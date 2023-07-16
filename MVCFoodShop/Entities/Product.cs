namespace MVCFoodShop.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            Menus = new HashSet<Menu>();
            ShoppingCartElements = new HashSet<ShoppingCartElement>();
            MenuCartElements = new HashSet<MenuCartElement>();
        }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public bool ProductIsActive { get; set; }
        public string? ProductCoverImage { get; set; }
        public string? ProductDeclaration { get; set; }
        public int CategoryID { get; set; } 
        public Category Category { get; set; }

        public ICollection<Menu> Menus { get; set; }

        public ICollection<ShoppingCartElement> ShoppingCartElements { get; set;}

        public ICollection<MenuCartElement> MenuCartElements { get; set; }
      
    }
}
