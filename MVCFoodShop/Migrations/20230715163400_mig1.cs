using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCFoodShop.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715163400_mig1.cs
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
========
                    NewPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
>>>>>>>> Busra:MVCFoodShop/Migrations/20230715153402_mig2.cs
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuCarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuCartAmount = table.Column<int>(type: "int", nullable: false),
                    MenuType = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FoodCount = table.Column<int>(type: "int", nullable: false),
                    beverageCount = table.Column<int>(type: "int", nullable: false),
                    SauceCount = table.Column<int>(type: "int", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
========
                    FoodCount = table.Column<int>(type: "int", nullable: false),
                    BeverageCount = table.Column<int>(type: "int", nullable: false),
                    SauceCount = table.Column<int>(type: "int", nullable: false),
                    MenuPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenuIsActive = table.Column<bool>(type: "bit", nullable: false),
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoppingCarts_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
========
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductIsActive = table.Column<bool>(type: "bit", nullable: false),
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuCartElements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    MenuCartID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuCartElements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuCartElements_MenuCarts_MenuCartID",
                        column: x => x.MenuCartID,
                        principalTable: "MenuCarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuCartElements_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuProduct",
                columns: table => new
                {
                    MenusID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuProduct", x => new { x.MenusID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_MenuProduct_Menus_MenusID",
                        column: x => x.MenusID,
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuProduct_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartElements",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartElementAmount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartElementPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    MenuCartID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartElements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoppingCartElements_MenuCarts_MenuCartID",
                        column: x => x.MenuCartID,
                        principalTable: "MenuCarts",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShoppingCartElements_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ShoppingCartElements_ShoppingCarts_ShoppingCartID",
                        column: x => x.ShoppingCartID,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715163400_mig1.cs
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                    { 1, "1d4376c1-fd9a-47e1-9c0f-4b009974689f", "Admin", "ADMIN" },
                    { 2, "7301f6e7-e4fb-4862-a021-c81ff62589e3", "User", "USER" }
========
                    { 1, "e228a05f-16e1-4509-8092-f3bbd527423c", "Admin", "ADMIN" },
                    { 2, "0a8a189a-2934-43d9-b2d0-9a2a5be2d7ed", "User", "USER" }
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
========
                    { 1, "a6bcbc9b-a3a3-4c55-a685-27159cf4a1c0", "Admin", "ADMIN" },
                    { 2, "c16d92cd-e13f-450a-9336-180fe0aac188", "User", "USER" }
>>>>>>>> Busra:MVCFoodShop/Migrations/20230715153402_mig2.cs
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryIsActive", "CategoryName", "CreationDate" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715163400_mig1.cs
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                    { 1, "Food", new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3665), true },
                    { 2, "Beverage", new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3679), true },
                    { 3, "Sauce", new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3680), true }
========
                    { 1, true, "Food", new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6404) },
                    { 2, true, "Beverage", new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6414) },
                    { 3, true, "Sauce", new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6415) }
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
========
                    { 1, true, "Food", new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2583) },
                    { 2, true, "Beverage", new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2592) },
                    { 3, true, "Sauce", new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2594) }
>>>>>>>> Busra:MVCFoodShop/Migrations/20230715153402_mig2.cs
                });

            migrationBuilder.InsertData(
                table: "Menus",
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                columns: new[] { "ID", "CoverImage", "CreationDate", "FoodCount", "IsActive", "MenuName", "Price", "SauceCount", "beverageCount" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3772), 0, true, "Whopper", 180m, 0, 0 },
                    { 2, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3775), 0, true, "Big King", 170m, 0, 0 },
                    { 3, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3776), 0, true, "King Chicken", 160m, 0, 0 },
                    { 4, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3777), 0, true, "Kids Menu", 140m, 0, 0 }
========
                columns: new[] { "ID", "BeverageCount", "CreationDate", "FoodCount", "MenuIsActive", "MenuName", "MenuPrice", "SauceCount" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715163400_mig1.cs
                    { 1, 0, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6513), 0, true, "Whopper", 180m, 0 },
                    { 2, 0, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6517), 0, true, "Big King", 170m, 0 },
                    { 3, 0, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6519), 0, true, "King Chicken", 160m, 0 },
                    { 4, 0, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6520), 0, true, "Kids Menu", 140m, 0 }
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
========
                    { 1, 0, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2698), 0, true, "Whopper", 180m, 0 },
                    { 2, 0, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2701), 0, true, "Big King", 170m, 0 },
                    { 3, 0, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2703), 0, true, "King Chicken", 160m, 0 },
                    { 4, 0, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2703), 0, true, "Kids Menu", 140m, 0 }
>>>>>>>> Busra:MVCFoodShop/Migrations/20230715153402_mig2.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715104646_mig1.cs
                columns: new[] { "ID", "CategoryID", "CoverImage", "CreationDate", "IsActive", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1, 2, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3852), true, 30m, "Kola" },
                    { 2, 2, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3856), true, 30m, "Fanta" },
                    { 3, 2, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3857), true, 20m, "Ayran" },
                    { 4, 1, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3858), true, 20m, "Köfte Burger" },
                    { 5, 1, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3859), true, 20m, "Tavuk Burger" },
                    { 6, 3, null, new DateTime(2023, 7, 15, 13, 46, 46, 178, DateTimeKind.Local).AddTicks(3860), true, 20m, "Mayonez" }
========
                columns: new[] { "ID", "CategoryID", "CreationDate", "ProductIsActive", "ProductName", "ProductPrice" },
                values: new object[,]
                {
<<<<<<<< HEAD:MVCFoodShop/Migrations/20230715163400_mig1.cs
                    { 1, 2, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6642), true, "Kola", 30m },
                    { 2, 2, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6649), true, "Fanta", 30m },
                    { 3, 2, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6650), true, "Ayran", 20m },
                    { 4, 1, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6652), true, "Köfte Burger", 20m },
                    { 5, 1, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6653), true, "Tavuk Burger", 20m },
                    { 6, 3, new DateTime(2023, 7, 15, 19, 34, 0, 220, DateTimeKind.Local).AddTicks(6654), true, "Mayonez", 20m }
>>>>>>>> Enes:MVCFoodShop/Migrations/20230715163400_mig1.cs
========
                    { 1, 2, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2773), true, "Kola", 30m },
                    { 2, 2, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2776), true, "Fanta", 30m },
                    { 3, 2, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2778), true, "Ayran", 20m },
                    { 4, 1, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2779), true, "Köfte Burger", 20m },
                    { 5, 1, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2780), true, "Tavuk Burger", 20m },
                    { 6, 3, new DateTime(2023, 7, 15, 18, 34, 2, 661, DateTimeKind.Local).AddTicks(2781), true, "Mayonez", 20m }
>>>>>>>> Busra:MVCFoodShop/Migrations/20230715153402_mig2.cs
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCartElements_MenuCartID",
                table: "MenuCartElements",
                column: "MenuCartID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuCartElements_ProductID",
                table: "MenuCartElements",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuProduct_ProductsID",
                table: "MenuProduct",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartElements_MenuCartID",
                table: "ShoppingCartElements",
                column: "MenuCartID",
                unique: true,
                filter: "[MenuCartID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartElements_ProductID",
                table: "ShoppingCartElements",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartElements_ShoppingCartID",
                table: "ShoppingCartElements",
                column: "ShoppingCartID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_AppUserID",
                table: "ShoppingCarts",
                column: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MenuCartElements");

            migrationBuilder.DropTable(
                name: "MenuProduct");

            migrationBuilder.DropTable(
                name: "ShoppingCartElements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MenuCarts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
