namespace MVCFoodShop.Entities
{
    public class ShoppingCart:BaseEntity
    {
        public ShoppingCart()
        {
            ShoppingCartElements = new HashSet<ShoppingCartElement>();
        }
        public decimal ShoppingCartPrice { get; set; }
        public bool ShoppingCartIsActive { get; set; }
        public ICollection<ShoppingCartElement> ShoppingCartElements { get; set; }
        public int AppUserID { get;set; }
        public AppUser AppUser { get; set; }
    }
}
