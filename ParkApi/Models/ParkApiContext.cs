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
                    new Park { ParkId = 1, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 2, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 3, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 4, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 5, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 6, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 7, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 8, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 9, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 10, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 11, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 12, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 13, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 14, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" },

                    new Park { ParkId = 15, ParkName = "", Location = "", Coordinates = , Attraction = "", Information = "", RequirmentType = "" }


                ); 




        }      
    }
}