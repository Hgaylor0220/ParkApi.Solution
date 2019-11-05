using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
    public class ParkApiDbContext : DbContext
    {
        public ParkApiDbContext(DbContextOptions<ParkApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park { ParkId = 1, ParkName = "Lava Canyon", Location = "South Cascades, Mount St. Helens", Coordinates = "46.1654, -122.0890", Attraction = "Hiking, Lava Rock, Waterfall, Draw Bridge", Information = "This hike has three sections. The first being very friendly, the second a little adventurest and the third for the experienced no fear of heights hikers. Ether way you will enjoy the one of the many beautiful views of what this powerful mountain has to offer.", RequirmentType = "Parking Pass with Northwest Forest Pass, $5 fee at site. No dogs." } ,

                    new Park {ParkId = 2, ParkName = "Salmon-Morgan Creeks Natrual Area", Location = "SouthWest Washington", Coordinates = "45.7556, -122.5111", Attraction = "Nice short hike surrounded in western redcedar, hemlock and fir trees.", Information = "1.8 miles, Good for kids.", RequirmentType = "No parking pass or fee required. Dogs are allowed on trail."} ,

                    new Park { ParkId = 3, ParkName = "Lewisville Regional Park", Location = "SouthWest Washington, Lewis River Region", Coordinates = "45.8190, -122.5452", Attraction = "Lots of space for family events. Covered pinic areas, play structures for childern, volleyball nets, softball field and a river for cooling off.", Information = "Good for familys, pets,wildlife, fall foilage, and old growth trees", RequirmentType = "Parking Fee required: $2 for motorcycles, 3 for cars, $6 for cars with trailers and $8 for buses or motor homes" } ,

                    new Park { ParkId = 4, ParkName = "Lucia Falls", Location = "SouthWest Washington", Coordinates = "45.8407, -122.4470", Attraction = "Waterfalls, Short 1.1 mile hike round trip with a 20 foot elevation gain.", Information = "Family and pet friendly, waterfalls and rivers", RequirmentType = "No parking pass or fee required" }  ,

                    new Park { ParkId = 5, ParkName = "Siouxon Creek", Location = "Southwest Washington ", Coordinates = "45.9406, -122.2294", Attraction = "Waterfalls, river side.", Information = "13.8 mile hike with 635 ft gain in elevation", RequirmentType = "Northwest Forest Pass" },

                    new Park { ParkId = 6, ParkName = "Siouxon Peak Loop", Location = "South Cascades", Coordinates = "45.9430, -122.1854" , Attraction = "Waterfalls, Rivers, Footbridge, dogs allowed, summit views", Information = "15.3 mile hike with  5120 ft elevation gain", RequirmentType = "Northwest Forest Pass" },

                    new Park { ParkId = 7, ParkName = "June Lake", Location = "South Cascades", Coordinates = "46.1373, -122.1569", Attraction = "Stressfree hike with beutiful ending to a river and waterfall.", Information = "No dogs allowed, waterfall, family friendly, mountain views", RequirmentType = "NorthWest Forest Pass" }

                 


                ); 




        }      
    }
}