using MVCFoodShop.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFoodShop.Entities
{
    public class MenuCart:BaseEntity
    {
        public MenuCart()
        {
            MenuCartElements = new HashSet<MenuCartElement>();
        }
        public int Amount { get; set; }
        public MenuType MenuType { get; set; }

        public ICollection<MenuCartElement> MenuCartElements { get; set; }

        public ShoppingCartElement ShoppingCartElement { get; set; }
    }
}
