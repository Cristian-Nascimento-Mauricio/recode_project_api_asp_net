using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace recode_work_api.Models
{
    public class TripDbContext : DbContext{

        public TripDbContext(DbContextOptions<TripDbContext> options) : base(options)
        {
        }

        public DbSet<Trip> trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trip>().HasData(

                new Trip { 
                    Id = 1, 
                    Description = "Viajem internacional", 
                    Boarding="Rio de janeiro/Brasil", 
                    Destiny= "Berlim/Alemanha",
                    Date ="2023-10-5",
                    Price=150.00, 
                    Promotion=0.8 
                },
                new Trip
                {
                    Id = 2,
                    Description = "Viajem internacional",
                    Boarding = "São Paulo/Brasil",
                    Destiny = "Tóquio/Japão",
                    Date = "2023-01-12",
                    Price = 500.00,
                    Promotion = 0.85
                },
                new Trip
                {
                    Id = 3,
                    Description = "Viajem internacional",
                    Boarding = "Rio de janeiro/Brazil",
                    Destiny = "Berlim/Alemanha",
                    Date = "2023-12-7",
                    Price = 100.00,
                    Promotion = 1
                },
                new Trip
                {
                    Id = 4,
                    Description = "Viajem internacional",
                    Boarding = "Rio branco/Brasil",
                    Destiny = "Porto/Portugal",
                    Date = "2023-02-30",
                    Price = 150.00,
                    Promotion = 0.75
                },
                new Trip
                {
                    Id = 5,
                    Description = "Viajem internacional",
                    Boarding = "Florianopólis/Brasil",
                    Destiny = "Nova Yorque/Estados Unidos",
                    Date = "2023-08-10",
                    Price = 850.00,
                    Promotion = 0.95
                },
                new Trip
                {
                    Id = 6,
                    Description = "Viajem internacional",
                    Boarding = "Rio de janeiro/Brazil",
                    Destiny = "Buenos Ares/Argentina",
                    Date = "2023-02-20",
                    Price = 100.50,
                    Promotion = 0.85
                },
                new Trip
                {
                    Id = 7,
                    Description = "Viajem internacional",
                    Boarding = "Gramados/Brasil",
                    Destiny = "Madri/Espanha",
                    Date = "2023-04-25",
                    Price = 650.00,
                    Promotion = 0.75
                },
                new Trip
                {
                    Id = 8,
                    Description = "Viajem internacional",
                    Boarding = "Rio de janeiro/Brazil",
                    Destiny = "Berlim/Alemanha",
                    Date = "2023-07-5",
                    Price = 100.00,
                    Promotion = 0.8
                },
                new Trip
                {
                    Id = 9,
                    Description = "Viajem internacional",
                    Boarding = "Salvador/Brasil",
                    Destiny = "Capital da Angola/Angola",
                    Date = "2023-08-12",
                    Price = 250.00,
                    Promotion = 0.9
                },
                new Trip
                {
                    Id = 10,
                    Description = "Viajem internacional",
                    Boarding = "Vitória/Brazil",
                    Destiny = "Paris/França",
                    Date = "2023-12-15",
                    Price = 725.00,
                    Promotion = 0.85
                }

            );
        }

    }
}
