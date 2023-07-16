﻿using Microsoft.EntityFrameworkCore;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Repositories.Concrete
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly FoodShopDbContext dbContext;

        public ShoppingCartRepository(FoodShopDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public ShoppingCart? GetShoppingCartIncludeAllData(int id)
        {
            return dbContext.ShoppingCarts.Include(s => s.ShoppingCartElements)
                            .ThenInclude(p => p.MenuCart)
                                .ThenInclude(mc => mc.MenuCartElements)
                        .Include(s => s.ShoppingCartElements)
                                .ThenInclude(p => p.MenuCart)
                                    .ThenInclude(mc => mc.Menu)
                        .Include(s => s.ShoppingCartElements)
                            .ThenInclude(p => p.MenuCart)
                                .ThenInclude(mc => mc.MenuCartElements)
                                    .ThenInclude(mce => mce.Product)
                         .Include(s => s.ShoppingCartElements)
                            .ThenInclude(p => p.Product)
                        .FirstOrDefault(s => s.ID == id);
        }

        public ShoppingCart? GetShoppingCartIncludeElementsWithAllData(int id)
        {
            return dbContext.ShoppingCarts.Include(s => s.ShoppingCartElements)
                .ThenInclude(p => p.MenuCart)
                    .ThenInclude(mc => mc.MenuCartElements)
                .Include(s => s.ShoppingCartElements)
                    .ThenInclude(p => p.MenuCart)
                        .ThenInclude(mc => mc.Menu)
                .Include(s => s.ShoppingCartElements)
                    .ThenInclude(p => p.MenuCart)
                        .ThenInclude(mc => mc.MenuCartElements)
                            .ThenInclude(mce => mce.Product)
                .FirstOrDefault(s => s.ID == id);
        }

        public ShoppingCart? GetShoppingCartIncludeElementsWithProducts(int id)
        {
            return dbContext.ShoppingCarts.Include(s => s.ShoppingCartElements).ThenInclude(p => p.Product).FirstOrDefault(s => s.ID == id);
        }
    }
}
