using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models.Entities;

namespace TestProject.DAL.Abstractions
{
    public interface IUserRepository
    {
        public Task<User> GetAsync(int id);
        public IQueryable<User> Get();

        public Task<User> AddAsync(User user);
    }
}
