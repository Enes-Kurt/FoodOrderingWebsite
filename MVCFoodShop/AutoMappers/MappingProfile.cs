using AutoMapper;
using MVCFoodShop.Entities;
using MVCFoodShop.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MVCFoodShop.AutoMappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductList_VM, Product>();
            CreateMap<ProductList_VM, Menu>();
            CreateMap<UpdateMenu_VM, Menu>();
        }
    }
}
