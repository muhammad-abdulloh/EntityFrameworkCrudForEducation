using Microsoft.EntityFrameworkCore;
using NewEF.Models;
using NewEF.NewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEF.Data
{
    public class DbContexts : DbContext
    {
        /**
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        */

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.CONNECTION_STRING);
        
        }

/** SitIn methods
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country() { Id = 1, Name = "Moldava", ShortName = "Md"},
                new Country() { Id = 2, Name = "Moskva", ShortName = "Ru"},
                new Country() { Id = 3, Name = "Uzbekistan", ShortName = "Uz"}
                );

            builder.Entity<Hotel>().HasData(
                new Hotel() { Id = 1, Name = "GlobalHotel", Country = "ShriLanka", CountryId = 1001100, Raiting = 7},
                new Hotel() { Id = 2, Name = "WorldEnjoy", Country = "Bobil", CountryId = 1001111, Raiting = 2},
                new Hotel() { Id = 3, Name = "MoreMore", Country = "Rim", CountryId = 1001111, Raiting = 1}
                );
        }

*/


    }
}
