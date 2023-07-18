namespace MVCFoodShop.Models
{
    public class UpdateProduct_VM
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductCoverImage { get; set; }
        public int CategoryID { get; set; }
        public string ProductDeclaration { get; set; }
    }
}
