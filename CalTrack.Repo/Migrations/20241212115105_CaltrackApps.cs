using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalTrack.Repo.Migrations
{
    public partial class CaltrackApps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ActivityLevel = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PortionCalorie = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodMeals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    Portion = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MealType = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodMeals_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9796), "Ana Yemekler", 0 },
                    { 2, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9805), "Atıştırmalıklar", 0 },
                    { 3, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9806), "İçecekler", 0 },
                    { 4, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9807), "Salatalar", 0 },
                    { 5, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9808), "Çorbalar", 0 },
                    { 6, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9808), "Tatlılar", 0 },
                    { 7, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9809), "Et Yemekleri", 0 },
                    { 8, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9810), "Sebze Yemekleri", 0 },
                    { 9, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9811), "Deniz Ürünleri", 0 },
                    { 10, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9812), "Hamur İşleri", 0 },
                    { 11, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9812), "Kahvaltılıklar", 0 },
                    { 12, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9813), "Dondurmalar", 0 },
                    { 13, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9814), "Meyve", 0 },
                    { 14, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9815), "Soslar", 0 },
                    { 15, new DateTime(2024, 12, 12, 14, 51, 4, 818, DateTimeKind.Local).AddTicks(9816), "Makarna Çeşitleri", 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ActivityLevel", "BirthDate", "City", "CreateDate", "Height", "LastName", "Name", "Password", "Status", "Username", "Width", "gender" },
                values: new object[,]
                {
                    { 1, "active", new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "İstanbul", new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(1529), 182m, "Admin", "Admin", "Admin123*", 0, "admin@gmail.com", 100m, "Male" },
                    { 2, "moderate", new DateTime(1995, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ankara", new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(1853), 165m, "Kaya", "Emine", "Emine123*", 0, "emine.kaya@hotmail.com", 60m, "Female" },
                    { 3, "sedentary", new DateTime(1987, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "İzmir", new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(1948), 180m, "Öztürk", "Mehmet", "Mehmet123*", 0, "mehmet@gmail.com", 90m, "Male" },
                    { 4, "active", new DateTime(1992, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bursa", new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(2033), 160m, "Demir", "Zeynep", "Zeynep123*", 0, "zeynep@gmail.com", 55m, "Female" },
                    { 5, "moderate", new DateTime(1985, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antalya", new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(2090), 185m, "Çelik", "Murat", "Murat123*", 0, "murat@gmail.com", 95m, "Male" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "PhotoPath", "PortionCalorie", "Status" },
                values: new object[,]
                {
                    { 1, 7, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(75), "Köfte", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Köfte.jpg", 250m, 0 },
                    { 2, 10, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(77), "Börek", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Börek.jpg", 300m, 0 },
                    { 3, 3, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(78), "Çay", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çay.jpg", 2m, 0 },
                    { 4, 4, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(79), "Kısır", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Kısır.jpeg", 250m, 0 },
                    { 5, 5, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(80), "Mercimek Çorbası", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\MercimekÇorbası.jpg", 150m, 0 },
                    { 6, 6, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(81), "Kadayıf", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Kadayıf.jpg", 350m, 0 },
                    { 7, 7, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(82), "Tavuk Şiş", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Tavuk Şil.png", 270m, 0 },
                    { 8, 8, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(83), "Sebze Sote", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Sebze Sote.jpg", 180m, 0 },
                    { 9, 9, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(84), "Balık Izgara", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Balık Izgara.jpg", 220m, 0 },
                    { 10, 10, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(85), "Poğaça", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Poğaça.jpg", 230m, 0 },
                    { 11, 11, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(86), "Menemen", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Menemen.jpg", 150m, 0 },
                    { 12, 12, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(87), "Çikolatalı Dondurma", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çikolatalı Dondurma.jpeg", 180m, 0 },
                    { 13, 13, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(88), "Meyve Salatası", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Meyve Salatası.png", 120m, 0 },
                    { 14, 8, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(89), "Zeytinyağlı Enginar", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Enginar.jpg", 140m, 0 },
                    { 15, 14, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(90), "Tatlı Sos", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Tatlı Sos.jpg", 80m, 0 },
                    { 16, 15, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(91), "Spagetti", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Spagetti.jpg", 200m, 0 },
                    { 17, 10, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(92), "Simit", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Simit.jpg", 280m, 0 },
                    { 18, 3, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(93), "Limonata", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\lemonade.jpg", 100m, 0 },
                    { 19, 5, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(94), "Sebze Çorbası", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Sebze Çorbası.jpg", 120m, 0 },
                    { 20, 6, new DateTime(2024, 12, 12, 14, 51, 4, 819, DateTimeKind.Local).AddTicks(132), "Çikolatalı Kek", "C:\\Users\\Lenovo\\Desktop\\CalTrack.Core\\FoodPhotos\\Çikolatalı Kek.jpg", 350m, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_FoodId",
                table: "FoodMeals",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_MealId",
                table: "FoodMeals",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_UserId",
                table: "FoodMeals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
