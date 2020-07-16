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
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext dbContext;
        public UserRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User> AddAsync(User user)
        {
            await this.dbContext.Users.AddAsync(user);
            await this.dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<User> GetAsync(int id)
        {
            return await dbContext.Users.SingleOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<User> Get()
        {
            return dbContext.Users;
        }
    }
}
