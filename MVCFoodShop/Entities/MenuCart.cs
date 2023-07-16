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
        public int MenuCartAmount { get; set; }
        public MenuType MenuType { get; set; }

        public ICollection<MenuCartElement> MenuCartElements { get; set; }

        public ShoppingCartElement ShoppingCartElement { get; set; }

        public int MenuID { get; set; }
        public Menu Menu { get; set; }
    }
}
