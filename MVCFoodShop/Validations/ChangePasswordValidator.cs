using FluentValidation;
using MVCFoodShop.Entities;

namespace MVCFoodShop.Validations
{
    public class ChangePasswordValidator: AbstractValidator<AppUser>
    {
        public ChangePasswordValidator()
        {
           
        }
    }
}
