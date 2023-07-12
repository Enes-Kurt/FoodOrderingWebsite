namespace MVCFoodShop.Entities
{
    public class BaseEntity
    {
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }=DateTime.Now;
    }
}
