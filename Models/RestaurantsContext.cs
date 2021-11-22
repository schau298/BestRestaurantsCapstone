using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteRestaurantsCapstone.Models
{
    public class RestaurantsContext : DbContext
    {
        public RestaurantsContext(DbContextOptions<RestaurantsContext> options) : base(options) { }
        public DbSet<Restaurants> Restaurants { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurants>().HasData(
                new Restaurants
                {
                    ID = 1,
                    RestaurantName = "Fu Hua",
                    StreetAddress = "742 Munson Ave",
                    City = "Traverse City",
                    CuisineType = "Chinese",
                    AverageCost = 9,
                    MenuItems = "Seasame Chicken, Chicken Fried Rice, Vegetable Lo Mein, Egg Rolls, Crab Rangoon",
                },
                new Restaurants
                {
                    ID = 2,
                    RestaurantName = "Clyde's Drive In",
                    StreetAddress = "3 US Highway 2 W",
                    City = "St. Ignace",
                    CuisineType = "Burgers",
                    AverageCost = 6,
                    MenuItems = "Cheeseburger, French Fries, Clyde Burger, Onion Rings",
                },
                new Restaurants
                {
                    ID = 3,
                    RestaurantName = "Tonys I75",
                    StreetAddress = "8781  Main Street",
                    City = "Birch Run",
                    CuisineType = "American",
                    AverageCost = 12,
                    MenuItems = "Sandwiches, Fish and Chips, Bacon, Bananna Split",
                },
             new Restaurants
             {
                 ID = 4,
                 RestaurantName = "Detroit Wing Company",
                 StreetAddress = "1201 East Front Street",
                 City = "Traverse City",
                 CuisineType = "Wings",
                 AverageCost = 10,
                 MenuItems = "Boneless Wings, Traditional Wings, Poutine, Mac & Cheese",
             },
             new Restaurants
             {
                 ID = 5,
                 RestaurantName = "Legs Inn",
                 StreetAddress = "6425 N Lake Shore Dr",
                 City = "Cross Village",
                 CuisineType = "Polish",
                 AverageCost = 16,
                 MenuItems = "Kielbasa, Kotlet, Golabki, Pierogi",
             },
             new Restaurants
             {
                 ID = 6,
                 RestaurantName = "Kinght's Steakhouse",
                 StreetAddress = "2324 Dexter Ave",
                 City = "Ann Arbor",
                 CuisineType = "Steakhouse Entrees",
                 AverageCost = 20,
                 MenuItems = "Steak, Prime Rib, Pork Tenderloin, Halibut",
             }
                );
        }
    }

}
