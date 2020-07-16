using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models.Entities;
using TestProject.Models.ViewModels;

namespace TestProject.BL.Abstractions
{
    public interface IUserService
    {
        public Task<ResultViewModel<User>> GetUserByIdAsync(int userId);
        public Task<ResultViewModel<IEnumerable<User>>> GetUsersAsync(GetUserViewModel getUserViewModel);
        public Task<ResultViewModel<User>> AddUserAsync(UserViewModel userViewModel);
    }
}
