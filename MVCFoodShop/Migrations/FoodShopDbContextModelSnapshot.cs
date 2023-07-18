﻿// <auto-generated />
using System;
using MVCFoodShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCFoodShop.Migrations
{
    [DbContext(typeof(FoodShopDbContext))]
    partial class FoodShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MenuProduct", b =>
                {
                    b.Property<int>("MenusID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.HasKey("MenusID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("MenuProduct");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVCFoodShop.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "50aefa15-ecfd-4d7e-9119-a861b027c7ff",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "ca09b6ca-1e4a-4612-8f04-35687f9ac209",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "401192d8-a861-4e91-b650-1e356083d025",
                            Name = "RegisteredUser",
                            NormalizedName = "REGİSTEREDUSER"
                        });
                });

            modelBuilder.Entity("MVCFoodShop.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NewPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<bool>("CategoryIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryIsActive = true,
                            CategoryName = "Food",
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9444)
                        },
                        new
                        {
                            ID = 2,
                            CategoryIsActive = true,
                            CategoryName = "Beverage",
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9466)
                        },
                        new
                        {
                            ID = 3,
                            CategoryIsActive = true,
                            CategoryName = "Sauce",
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9468)
                        });
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BeverageCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodCount")
                        .HasColumnType("int");

                    b.Property<string>("MenuCoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MenuDeclaration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MenuIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MenuName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MenuPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SauceCount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.MenuCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MenuCartAmount")
                        .HasColumnType("int");

                    b.Property<int>("MenuID")
                        .HasColumnType("int");

                    b.Property<int>("MenuType")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.ToTable("MenuCarts");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.MenuCartElement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MenuCartID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuCartID");

                    b.HasIndex("ProductID");

                    b.ToTable("MenuCartElements");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDeclaration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ProductIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9668),
                            ProductCoverImage = "coca-cola.png",
                            ProductDeclaration = "A delightful flavor that dances with ice particles: Cola, the perfect choice for a refreshing break.",
                            ProductIsActive = true,
                            ProductName = "Cola",
                            ProductPrice = 30m
                        },
                        new
                        {
                            ID = 2,
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9675),
                            ProductCoverImage = "fdb65e80-0777-443f-ad15-6045ef4f1a0c-fanta.png",
                            ProductDeclaration = "Fanta, with its sweet and fruity flavor, delights your taste buds and provides a refreshing beverage experience with every sip.",
                            ProductIsActive = true,
                            ProductName = "Fanta",
                            ProductPrice = 30m
                        },
                        new
                        {
                            ID = 3,
                            CategoryID = 2,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9677),
                            ProductCoverImage = "ayran-195-ml.png",
                            ProductDeclaration = "Ayran, the traditional Turkish delicacy, instantly refreshes and relaxes you with its cooling and invigorating taste.",
                            ProductIsActive = true,
                            ProductName = "Ayran",
                            ProductPrice = 20m
                        },
                        new
                        {
                            ID = 4,
                            CategoryID = 1,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9678),
                            ProductCoverImage = "double-kofteburger-1.png",
                            ProductDeclaration = "A burger that combines delicious meatballs with fresh vegetables, cooked to perfection. With every bite, it delights the palate with rich meat flavors and exquisite spices. The perfect choice for an exceptional meatball burger experience!",
                            ProductIsActive = true,
                            ProductName = "Köfte Burger",
                            ProductPrice = 80m
                        },
                        new
                        {
                            ID = 5,
                            CategoryID = 1,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9680),
                            ProductCoverImage = "tavukburger.png",
                            ProductDeclaration = "Moist and tender chicken meat, combined with crispy breading, creates the unique taste of a chicken burger. It is a light and healthy choice that offers both delicious flavor and nutritional value. A favorite among chicken lovers!",
                            ProductIsActive = true,
                            ProductName = "Chicken Burger",
                            ProductPrice = 70m
                        },
                        new
                        {
                            ID = 6,
                            CategoryID = 3,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9681),
                            ProductCoverImage = "mini-mayonez.png",
                            ProductDeclaration = "Mayonnaise, with its creamy texture and slightly tangy taste, adds a distinct flavor to every bite. It is a must-have condiment for burgers.",
                            ProductIsActive = true,
                            ProductName = "Mayonnaise",
                            ProductPrice = 8m
                        },
                        new
                        {
                            ID = 7,
                            CategoryID = 3,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9682),
                            ProductCoverImage = "mini-ketcap.png",
                            ProductDeclaration = "Ketchup, a sweet, tangy, and slightly spicy flavor bomb, is one of the essential sauces for burgers.",
                            ProductIsActive = true,
                            ProductName = "Ketchup",
                            ProductPrice = 8m
                        },
                        new
                        {
                            ID = 8,
                            CategoryID = 3,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9683),
                            ProductCoverImage = "mini-ranch.png",
                            ProductDeclaration = "Ranch sauce, with its creamy consistency and refreshing flavor, adds a wonderful touch to burgers.",
                            ProductIsActive = true,
                            ProductName = "Ranch Sauce",
                            ProductPrice = 10m
                        },
                        new
                        {
                            ID = 9,
                            CategoryID = 3,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9684),
                            ProductCoverImage = "mini-buffalo-1.png",
                            ProductDeclaration = "Bufala sauce, a rich and spicy condiment, adds a mildly spicy and sweet flavor to burgers.",
                            ProductIsActive = true,
                            ProductName = "Bufala Sauce",
                            ProductPrice = 10m
                        },
                        new
                        {
                            ID = 10,
                            CategoryID = 1,
                            CreationDate = new DateTime(2023, 7, 18, 10, 27, 41, 745, DateTimeKind.Local).AddTicks(9685),
                            ProductCoverImage = "potato.png",
                            ProductDeclaration = "Crispy and delicious, golden fries offer a satisfying snack option. These thinly sliced and carefully fried potatoes provide a perfect taste experience when served as a side dish or enjoyed on their own. A favorite choice for potato lovers!",
                            ProductIsActive = true,
                            ProductName = "potatoes",
                            ProductPrice = 50m
                        });
                });

            modelBuilder.Entity("MVCFoodShop.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AppUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ShoppingCartIsActive")
                        .HasColumnType("bit");

                    b.Property<decimal>("ShoppingCartPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("AppUserID");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.ShoppingCartElement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenuCartID")
                        .HasColumnType("int");

                    b.Property<int?>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartElementAmount")
                        .HasColumnType("int");

                    b.Property<decimal>("ShoppingCartElementPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ShoppingCartID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MenuCartID")
                        .IsUnique()
                        .HasFilter("[MenuCartID] IS NOT NULL");

                    b.HasIndex("ProductID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("ShoppingCartElements");
                });

            modelBuilder.Entity("MenuProduct", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.Menu", null)
                        .WithMany()
                        .HasForeignKey("MenusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCFoodShop.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCFoodShop.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVCFoodShop.Entities.MenuCart", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.MenuCartElement", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.MenuCart", "MenuCart")
                        .WithMany("MenuCartElements")
                        .HasForeignKey("MenuCartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCFoodShop.Entities.Product", "Product")
                        .WithMany("MenuCartElements")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuCart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Product", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.ShoppingCart", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.AppUser", "AppUser")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("AppUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.ShoppingCartElement", b =>
                {
                    b.HasOne("MVCFoodShop.Entities.MenuCart", "MenuCart")
                        .WithOne("ShoppingCartElement")
                        .HasForeignKey("MVCFoodShop.Entities.ShoppingCartElement", "MenuCartID");

                    b.HasOne("MVCFoodShop.Entities.Product", "Product")
                        .WithMany("ShoppingCartElements")
                        .HasForeignKey("ProductID");

                    b.HasOne("MVCFoodShop.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany("ShoppingCartElements")
                        .HasForeignKey("ShoppingCartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuCart");

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.AppUser", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.MenuCart", b =>
                {
                    b.Navigation("MenuCartElements");

                    b.Navigation("ShoppingCartElement")
                        .IsRequired();
                });

            modelBuilder.Entity("MVCFoodShop.Entities.Product", b =>
                {
                    b.Navigation("MenuCartElements");

                    b.Navigation("ShoppingCartElements");
                });

            modelBuilder.Entity("MVCFoodShop.Entities.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartElements");
                });
#pragma warning restore 612, 618
        }
    }
}
