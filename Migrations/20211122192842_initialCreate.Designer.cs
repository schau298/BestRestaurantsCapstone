﻿// <auto-generated />
using FavoriteRestaurantsCapstone.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FavoriteRestaurantsCapstone.Migrations
{
    [DbContext(typeof(RestaurantsContext))]
    [Migration("20211122192842_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FavoriteRestaurantsCapstone.Models.Restaurants", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AverageCost")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuisineType")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("MenuItems")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AverageCost = 9,
                            City = "Traverse City",
                            CuisineType = "Chinese",
                            MenuItems = "Seasame Chicken, Chicken Fried Rice, Vegetable Lo Mein, Egg Rolls, Crab Rangoon",
                            RestaurantName = "Fu Hua",
                            StreetAddress = "742 Munson Ave"
                        },
                        new
                        {
                            ID = 2,
                            AverageCost = 6,
                            City = "St. Ignace",
                            CuisineType = "Burgers",
                            MenuItems = "Cheeseburger, French Fries, Clyde Burger, Onion Rings",
                            RestaurantName = "Clyde's Drive In",
                            StreetAddress = "3 US Highway 2 W"
                        },
                        new
                        {
                            ID = 3,
                            AverageCost = 12,
                            City = "Birch Run",
                            CuisineType = "American",
                            MenuItems = "Sandwiches, Fish and Chips, Bacon, Bananna Split",
                            RestaurantName = "Tonys I75",
                            StreetAddress = "8781  Main Street"
                        },
                        new
                        {
                            ID = 4,
                            AverageCost = 10,
                            City = "Traverse City",
                            CuisineType = "Wings",
                            MenuItems = "Boneless Wings, Traditional Wings, Poutine, Mac & Cheese",
                            RestaurantName = "Detroit Wing Company",
                            StreetAddress = "1201 East Front Street"
                        },
                        new
                        {
                            ID = 5,
                            AverageCost = 16,
                            City = "Cross Village",
                            CuisineType = "Polish",
                            MenuItems = "Kielbasa, Kotlet, Golabki, Pierogi",
                            RestaurantName = "Legs Inn",
                            StreetAddress = "6425 N Lake Shore Dr"
                        },
                        new
                        {
                            ID = 6,
                            AverageCost = 20,
                            City = "Ann Arbor",
                            CuisineType = "Steakhouse Entrees",
                            MenuItems = "Steak, Prime Rib, Pork Tenderloin, Halibut",
                            RestaurantName = "Kinght's Steakhouse",
                            StreetAddress = "2324 Dexter Ave"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}