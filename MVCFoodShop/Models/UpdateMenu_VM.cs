namespace MVCFoodShop.Models
{
    public class UpdateMenu_VM
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public int FoodCount { get; set; }
        public int BeverageCount { get; set; }
        public int SauceCount { get; set; }
        public int UpdatedMenuPrice { get; set; }
        public string? MenuCoverImage { get; set; }
        public string? MenuDeclaration { get; set; }
        public int[] SelectedProducts { get; set; } = new int[1];
    }
}
