using System;
using System.Collections.Generic;
using System.Text;
using TestProject.DAL.Abstractions;
using TestProject.Models.Entities;

namespace TestProject.DAL.Implementations
{
    public class CompanyUserRepository : ICompanyUserRepository
    {
        private readonly DatabaseContext dbContext;
        public CompanyUserRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async void AddAsync(int userId, int companyId)
        {
            await dbContext.AddAsync(new CompanyUser { CompanyId = companyId, UserId = userId});
            await dbContext.SaveChangesAsync();
        }
    }
}
