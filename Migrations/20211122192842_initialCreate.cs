using Microsoft.EntityFrameworkCore.Migrations;

namespace FavoriteRestaurantsCapstone.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(maxLength: 50, nullable: false),
                    StreetAddress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    CuisineType = table.Column<string>(maxLength: 40, nullable: false),
                    AverageCost = table.Column<int>(nullable: false),
                    MenuItems = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "AverageCost", "City", "CuisineType", "MenuItems", "RestaurantName", "StreetAddress" },
                values: new object[,]
                {
                    { 1, 9, "Traverse City", "Chinese", "Seasame Chicken, Chicken Fried Rice, Vegetable Lo Mein, Egg Rolls, Crab Rangoon", "Fu Hua", "742 Munson Ave" },
                    { 2, 6, "St. Ignace", "Burgers", "Cheeseburger, French Fries, Clyde Burger, Onion Rings", "Clyde's Drive In", "3 US Highway 2 W" },
                    { 3, 12, "Birch Run", "American", "Sandwiches, Fish and Chips, Bacon, Bananna Split", "Tonys I75", "8781  Main Street" },
                    { 4, 10, "Traverse City", "Wings", "Boneless Wings, Traditional Wings, Poutine, Mac & Cheese", "Detroit Wing Company", "1201 East Front Street" },
                    { 5, 16, "Cross Village", "Polish", "Kielbasa, Kotlet, Golabki, Pierogi", "Legs Inn", "6425 N Lake Shore Dr" },
                    { 6, 20, "Ann Arbor", "Steakhouse Entrees", "Steak, Prime Rib, Pork Tenderloin, Halibut", "Kinght's Steakhouse", "2324 Dexter Ave" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurants");
        }
    }
}
