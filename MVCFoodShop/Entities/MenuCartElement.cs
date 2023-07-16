namespace MVCFoodShop.Entities
{
    public class MenuCartElement:BaseEntity
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int MenuCartID { get; set; }
        public MenuCart MenuCart { get; set; }

    }
}
