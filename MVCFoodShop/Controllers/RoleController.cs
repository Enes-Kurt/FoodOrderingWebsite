using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;

namespace MVCFoodShop.Controllers
{
    [Authorize(Roles="Admin")]
    public class RoleController : BaseController
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager, IShoppingCartRepository shoppingCartRepository, UserManager<AppUser> userManager) : base(shoppingCartRepository, userManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            List<IdentityRole> roleList = roleManager.Roles.ToList();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole ıdentityRole)
        {
            if (ModelState.IsValid)
            {
                IdentityResult result = await roleManager.CreateAsync(ıdentityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrors(result);
                    return View(ıdentityRole);
                }
            }
            return View(ıdentityRole);
        }

        public async Task<IActionResult> Update(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role is not null)
            {
                return View(role);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(IdentityRole ıdentityRole)
        {
            IdentityRole updateRole = await roleManager.FindByIdAsync(ıdentityRole.Id);
            if (updateRole is not null)
            {
                updateRole.Name = ıdentityRole.Name;
                IdentityResult result = await roleManager.UpdateAsync(updateRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrors(result);
                    return View(ıdentityRole);
                }
            }
            ModelState.AddModelError("Error", "Role not found to be update");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role is not null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrors(result);
                    return RedirectToAction("Index");
                }
            }
            //TempData["info"]="We can't delete this role";
            return RedirectToAction("Index");
        }

        [NonAction]
        private void AddErrors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("Hata", $"{error.Description}");
            }

        }
    }
}
