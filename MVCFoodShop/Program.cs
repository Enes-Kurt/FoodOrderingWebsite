
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVCFoodShop.AutoMappers;
using MVCFoodShop.Data;
using MVCFoodShop.Entities;
using MVCFoodShop.Repositories.Abstract;
using MVCFoodShop.Repositories.Concrete;
using MVCFoodShop.Utilities;

namespace MVCFoodShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            var connectionString = builder.Configuration.GetConnectionString("ConStr") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<FoodShopDbContext>(options =>
                options.UseSqlServer(connectionString));

                //        builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
                //.AddEntityFrameworkStores<FoodShopDbContext>();

            //            builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddEntityFrameworkStores<FoodShopDbContext>();
            //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddIdentity<AppUser,AppRole>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<AppRole>()
                .AddEntityFrameworkStores<FoodShopDbContext>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddSession(x=>x.IdleTimeout = TimeSpan.FromSeconds(300));
            //Repositories
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<ICategoryRepository, CategoryRepository>();
            builder.Services.AddTransient<IMenuCartElementRepository, MenuCartElementRepository>();
            builder.Services.AddTransient<IMenuCartRepository, MenuCartRepository>();
            builder.Services.AddTransient<IMenuRepository, MenuRepository>();
            builder.Services.AddTransient<IShoppingCartElementRepository, ShoppingCartElementRepository>();
            builder.Services.AddTransient<IShoppingCartRepository, ShoppingCartRepository>();
            builder.Services.AddTransient<IAppUserRepository, AppUserRepository>();
            //AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }



            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            var scope = app.Services.CreateScope();
            var userManager = (UserManager<AppUser>)scope.ServiceProvider.GetService(typeof(UserManager<AppUser>));
            ForLogin.AddSuperUserAsync(userManager);

            app.Run();
        }
    }
}