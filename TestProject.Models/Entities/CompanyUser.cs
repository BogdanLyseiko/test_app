using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Models.Entities
{
    public class CompanyUser
    {
        public int UserId { get; set; }
        public int CompanyId { get; set; }

        public User User { get; set; }
        public Company Company { get; set; }

        public static void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyUser>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.UserId });

                entity.HasOne<User>(e => e.User)
                .WithMany(e => e.CompanyUsers)
                .HasForeignKey(e => e.UserId);

                entity.HasOne<Company>(e => e.Company)
                .WithMany(e => e.CompanyUsers)
                .HasForeignKey(e => e.CompanyId);
            });
        }
    }
}
