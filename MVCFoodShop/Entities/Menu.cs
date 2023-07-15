namespace MVCFoodShop.Entities
{
    public class Menu:BaseEntity
    {
        public Menu()
        {
            Products = new HashSet<Product>();
        }
        public string MenuName { get; set; }
        public decimal MenuPrice { get; set; }

        public bool MenuIsActive { get; set; }

        public ICollection<Product> Products { get; set; }  
    }
}
