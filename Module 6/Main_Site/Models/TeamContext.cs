using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Main_Site.Models
{
    public class TeamContext : DbContext
    {
        public TeamContext(DbContextOptions<TeamContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<Division> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Conference>().HasData(
                new Conference { ConferenceID = "afc", Name = "AFC" },
                new Conference { ConferenceID = "nfc", Name = "NFC"}
                );

            modelBuilder.Entity<Division>().HasData(
                new Division { DivisionID = "north", Name = "North"},
                new Division { DivisionID = "west", Name = "West"}
                );

            modelBuilder.Entity<Team>().HasData(
                new {TeamID = "ari", Name = "Arizona Cardinals", ConferenceID = "nfc", DivisionID = "west", LogoImage = "ARI.png"}
                );
        }
    }
}
