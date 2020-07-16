using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.DAL.Abstractions;
using TestProject.Models.Entities;

namespace TestProject.DAL.Implementations
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DatabaseContext dbContext;
        public CompanyRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Company> GetAsync(int id)
        {
            return await dbContext.Companies.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}