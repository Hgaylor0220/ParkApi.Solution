﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkApi.Models;

namespace ParkApi.Migrations
{
    [DbContext(typeof(ParkApiDbContext))]
    partial class ParkApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkApi.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attraction");

                    b.Property<string>("Coordinates");

                    b.Property<string>("Information");

                    b.Property<string>("Location");

                    b.Property<string>("ParkName");

                    b.Property<string>("RequirmentType");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Attraction = "Hiking, Lava Rock, Waterfall, Draw Bridge",
                            Coordinates = "46.1654, -122.0890",
                            Information = "This hike has three sections. The first being very friendly, the second a little adventurest and the third for the experienced no fear of heights hikers. Ether way you will enjoy the one of the many beautiful views of what this powerful mountain has to offer.",
                            Location = "South Cascades, Mount St. Helens",
                            ParkName = "Lava Canyon",
                            RequirmentType = "Parking Pass with Northwest Forest Pass, $5 fee at site. No dogs."
                        },
                        new
                        {
                            ParkId = 2,
                            Attraction = "Nice short hike surrounded in western redcedar, hemlock and fir trees.",
                            Coordinates = "45.7556, -122.5111",
                            Information = "1.8 miles, Good for kids.",
                            Location = "SouthWest Washington",
                            ParkName = "Salmon-Morgan Creeks Natrual Area",
                            RequirmentType = "No parking pass or fee required. Dogs are allowed on trail."
                        },
                        new
                        {
                            ParkId = 3,
                            Attraction = "Lots of space for family events. Covered pinic areas, play structures for childern, volleyball nets, softball field and a river for cooling off.",
                            Coordinates = "45.8190, -122.5452",
                            Information = "Good for familys, pets,wildlife, fall foilage, and old growth trees",
                            Location = "SouthWest Washington, Lewis River Region",
                            ParkName = "Lewisville Regional Park",
                            RequirmentType = "Parking Fee required: $2 for motorcycles, 3 for cars, $6 for cars with trailers and $8 for buses or motor homes"
                        },
                        new
                        {
                            ParkId = 4,
                            Attraction = "Waterfalls, Short 1.1 mile hike round trip with a 20 foot elevation gain.",
                            Coordinates = "45.8407, -122.4470",
                            Information = "Family and pet friendly, waterfalls and rivers",
                            Location = "SouthWest Washington",
                            ParkName = "Lucia Falls",
                            RequirmentType = "No parking pass or fee required"
                        },
                        new
                        {
                            ParkId = 5,
                            Attraction = "Waterfalls, river side.",
                            Coordinates = "45.9406, -122.2294",
                            Information = "13.8 mile hike with 635 ft gain in elevation",
                            Location = "Southwest Washington ",
                            ParkName = "Siouxon Creek",
                            RequirmentType = "Northwest Forest Pass"
                        },
                        new
                        {
                            ParkId = 6,
                            Attraction = "Waterfalls, Rivers, Footbridge, dogs allowed, summit views",
                            Coordinates = "45.9430, -122.1854",
                            Information = "15.3 mile hike with  5120 ft elevation gain",
                            Location = "South Cascades",
                            ParkName = "Siouxon Peak Loop",
                            RequirmentType = "Northwest Forest Pass"
                        },
                        new
                        {
                            ParkId = 7,
                            Attraction = "Stressfree hike with beutiful ending to a river and waterfall.",
                            Coordinates = "46.1373, -122.1569",
                            Information = "No dogs allowed, waterfall, family friendly, mountain views",
                            Location = "South Cascades",
                            ParkName = "June Lake",
                            RequirmentType = "NorthWest Forest Pass"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
