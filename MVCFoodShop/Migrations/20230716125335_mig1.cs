﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCFoodShop.Migrations
{
    public partial class mig1 : Migration
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
                    NewPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    FoodCount = table.Column<int>(type: "int", nullable: false),
                    BeverageCount = table.Column<int>(type: "int", nullable: false),
                    SauceCount = table.Column<int>(type: "int", nullable: false),
                    MenuPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MenuIsActive = table.Column<bool>(type: "bit", nullable: false),
                    MenuCoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MenuDeclaration = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ProductPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductIsActive = table.Column<bool>(type: "bit", nullable: false),
                    ProductCoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductDeclaration = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { 1, "ccca77ff-d704-485a-a56c-f8f9fbfa870b", "Admin", "ADMIN" },
                    { 2, "71016508-e741-4cf0-ba36-6c58a61e57b0", "User", "USER" },
                    { 3, "78e4eeb8-5653-4b1b-88e3-ae96c018d337", "RegisteredUser", "REGİSTEREDUSER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryIsActive", "CategoryName", "CreationDate" },
                values: new object[,]
                {
                    { 1, true, "Food", new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(5984) },
                    { 2, true, "Beverage", new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(5996) },
                    { 3, true, "Sauce", new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(5998) }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "ID", "BeverageCount", "CreationDate", "FoodCount", "MenuCoverImage", "MenuDeclaration", "MenuIsActive", "MenuName", "MenuPrice", "SauceCount" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6084), 0, null, null, true, "Whopper", 180m, 0 },
                    { 2, 0, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6087), 0, null, null, true, "Big King", 170m, 0 },
                    { 3, 0, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6118), 0, null, null, true, "King Chicken", 160m, 0 },
                    { 4, 0, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6119), 0, null, null, true, "Kids Menu", 140m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryID", "CreationDate", "ProductCoverImage", "ProductDeclaration", "ProductIsActive", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6195), "coca-cola-g023109b49_1920.jpg", "A delightful flavor that dances with ice particles: Cola, the perfect choice for a refreshing break.", true, "Cola", 30m },
                    { 2, 2, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6199), "fanta.jpg", "Fanta, with its sweet and fruity flavor, delights your taste buds and provides a refreshing beverage experience with every sip.", true, "Fanta", 30m },
                    { 3, 2, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6201), "ayran.jpg", "Ayran, the traditional Turkish delicacy, instantly refreshes and relaxes you with its cooling and invigorating taste.", true, "Ayran", 20m },
                    { 4, 1, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6202), "köfte burger.png", "A burger that combines delicious meatballs with fresh vegetables, cooked to perfection. With every bite, it delights the palate with rich meat flavors and exquisite spices. The perfect choice for an exceptional meatball burger experience!", true, "Köfte Burger", 80m },
                    { 5, 1, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6203), "tavukburger.png", "Moist and tender chicken meat, combined with crispy breading, creates the unique taste of a chicken burger. It is a light and healthy choice that offers both delicious flavor and nutritional value. A favorite among chicken lovers!", true, "Chicken Burger", 70m },
                    { 6, 3, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6205), "mayonez.jpeg", "Mayonnaise, with its creamy texture and slightly tangy taste, adds a distinct flavor to every bite. It is a must-have condiment for burgers.", true, "Mayonnaise", 8m },
                    { 7, 3, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6206), "ketcap.jpg", "Ketchup, a sweet, tangy, and slightly spicy flavor bomb, is one of the essential sauces for burgers.", true, "Ketchup", 8m },
                    { 8, 3, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6207), "ranch-sos.jpg", "Ranch sauce, with its creamy consistency and refreshing flavor, adds a wonderful touch to burgers.", true, "Ranch Sauce", 10m },
                    { 9, 3, new DateTime(2023, 7, 16, 15, 53, 35, 702, DateTimeKind.Local).AddTicks(6208), "buffalosos1.jpeg", "Bufala sauce, a rich and spicy condiment, adds a mildly spicy and sweet flavor to burgers.", true, "Bufala Sauce", 10m }
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
