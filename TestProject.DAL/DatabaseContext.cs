using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Models.Entities;

namespace TestProject.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CompanyUser.Configure(modelBuilder);
            User.Configure(modelBuilder);

            modelBuilder.Entity<Company>().HasData(new { Id = 1, Name = "Company 1" }, new { Id = 2, Name = "Company 2" });
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "usr1", Email = "testMail1@gmail.com" },
                new User { Id = 2, UserName = "usr2", Email = "testMail2@gmail.com" },
                new User { Id = 3, UserName = "usr3", Email = "testMail3@gmail.com" },
                new User { Id = 4, UserName = "usr4", Email = "testMail4@gmail.com" },
                new User { Id = 5, UserName = "usr5", Email = "testMail5@gmail.com" },
                new User { Id = 6, UserName = "usr6", Email = "testMail6@gmail.com" }
                );
        }
    }
}