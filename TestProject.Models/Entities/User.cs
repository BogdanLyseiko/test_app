
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace TestProject.Models.Entities
{
    public class User
    { 
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<CompanyUser> CompanyUsers { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(x => x.UserName).IsUnique();
            });
        }
    }
}
