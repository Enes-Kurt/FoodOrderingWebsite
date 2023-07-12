﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MVCFoodShop.Entities
{
    public class ShoppingCartElement:BaseEntity
    {
        public int Amount { get; set; }
        public decimal Price { get; set; }



        public int? ProductID { get;set; }

        public Product Product { get; set; }

        public int? MenuCartID { get; set; }
        public MenuCart MenuCart { get; set; }
        
        public int ShoppingCartID { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
