using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Main_Site.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", GameName = "Winter Olympics" },
                new Game { GameID = "summer", GameName = "Summer Olympics" },
                new Game { GameID = "youth", GameName = "Youth Olympic Games" },
                new Game { GameID = "paralympics", GameName = "Paralympics" }
                ); 

            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", SportName = "Curling", SportType = "indoor" },
                new Sport { SportID = "bobsleigh", SportName = "Bobsliegh", SportType = "outdoor" },
                new Sport { SportID = "diving", SportName = "Diving", SportType = "indoor" },
                new Sport { SportID = "road cycling", SportName = "Road Cycling", SportType = "outdoor" },
                new Sport { SportID = "archery", SportName = "Archery", SportType = "indoor" },
                new Sport { SportID = "canoe sprint", SportName = "Canoe Sprint", SportType = "outdoor" },
                new Sport { SportID = "breakdancing", SportName = "Breakdancing", SportType = "indoor" },
                new Sport { SportID = "skateboarding", SportName = "Skatebarding", SportType = "outdoor" }

                );

            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", CountryName = "Canada ", GameID = "winter", SportID = "curling" },
                new { CountryID = "sweden", CountryName = "Sweden ", GameID = "winter", SportID = "curling" },
                new { CountryID = "great britain", CountryName = "Great Britain", GameID = "winter", SportID = "curling" },
                new { CountryID = "jamaica", CountryName = "Jamaica", GameID = "winter", SportID = "bobsleigh" },
                new { CountryID = "italy", CountryName = "Italy", GameID = "winter", SportID = "bobsleigh" },
                new { CountryID = "japan", CountryName = "Japan", GameID = "winter", SportID = "bobsleigh" },
                new { CountryID = "germany", CountryName = "Germany", GameID = "summer", SportID = "diving" },
                new { CountryID = "china", CountryName = "China", GameID = "summer", SportID = "diving" },
                new { CountryID = "mexico", CountryName = "Mexico", GameID = "summer", SportID = "diving" },
                new { CountryID = "brazil", CountryName = "Brazil", GameID = "summer", SportID = "road cycling" },
                new { CountryID = "netherlands", CountryName = "Netherlands", GameID = "summer", SportID = "road cycling" },
                new { CountryID = "usa", CountryName = "USA", GameID = "summer", SportID = "road cycling" },
                new { CountryID = "thailand", CountryName = "Thailand", GameID = "paralympics", SportID = "archery" },
                new { CountryID = "uruguay", CountryName = "Uruguay", GameID = "paralympics", SportID = "archery" },
                new { CountryID = "ukraine", CountryName = "Ukraine", GameID = "paralympics", SportID = "archery" },
                new { CountryID = "austria", CountryName = "Austria", GameID = "paralympics", SportID = "canoe sprint" },
                new { CountryID = "pakistan", CountryName = "Pakistan ", GameID = "paralympics", SportID = "canoe sprint" },
                new { CountryID = "zimbabwe", CountryName = "Zimbabwe", GameID = "paralympics", SportID = "canoe sprint" },
                new { CountryID = "france", CountryName = "France", GameID = "youth", SportID = "breakdancing" },
                new { CountryID = "cyprus", CountryName = "Cyprus", GameID = "youth", SportID = "breakdancing" },
                new { CountryID = "russia", CountryName = "Russia", GameID = "youth", SportID = "breakdancing" },
                new { CountryID = "finland", CountryName = "Finland", GameID = "youth", SportID = "skateboarding" },
                new { CountryID = "slovakia", CountryName = "Slovakia", GameID = "youth", SportID = "skateboarding" },
                new { CountryID = "portugal", CountryName = "Portugal", GameID = "youth", SportID = "skateboarding" }

                );
        }
    }
}

