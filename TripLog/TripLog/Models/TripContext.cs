using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripLog.Models
{
    public class TripContext : DbContext
    {

        public TripContext(DbContextOptions<TripContext> options) 
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Trip>().HasData(
                    new Trip
                    {
                        TripId = 1,
                        Destination = "Honolulu",
                        StartDate = new DateTime(2022, 5, 15),
                        EndDate = new DateTime(2022, 6, 22),
                        Accomodation = "Hotel Blitz",
                        AccomodationPhone = "123-123-1234",
                        AccomodationEmail = "Bliz@blitz.blitz",
                        ThingsToDo1 = "Check the Feifel Tower",
                    },
                    new Trip
                    {
                        TripId = 2,
                        Destination = "Las Vegas",
                        StartDate = new DateTime(2021, 5, 22),
                        EndDate = new DateTime(2021, 6, 22),
                        Accomodation = "Hotel Bungalo",
                        AccomodationPhone = "333-333-4444",
                        AccomodationEmail = "Bungalo@Bungalo.com",
                        ThingsToDo1 = "Visit the desert",
                        ThingsToDo2 = "Sleep as much as you can",
                        ThingsToDo3 = "Play black jack"
                    }
                );

        }

    }
}
