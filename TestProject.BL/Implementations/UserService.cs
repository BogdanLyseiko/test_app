using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.BL.Abstractions;
using TestProject.BL.Helpers;
using TestProject.DAL.Abstractions;
using TestProject.Models.Constatns;
using TestProject.Models.Entities;
using TestProject.Models.ViewModels;
using AutoMapper;

namespace TestProject.BL.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly ICompanyRepository companyRepository;
        private readonly ICompanyUserRepository companyUserRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, ICompanyRepository companyRepository, ICompanyUserRepository companyUserRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.companyRepository = companyRepository;
            this.companyUserRepository = companyUserRepository;
            this.mapper = mapper;
        }

        public async Task<ResultViewModel<User>> AddUserAsync(UserViewModel userViewModel)
        {
            ResultViewModel<User> resultViewModel = new ResultViewModel<User>();
            var relatedCompany = await companyRepository.GetAsync(userViewModel.CompanyId);

            if (relatedCompany == null)
            {
                resultViewModel.Errors.Add(ApiErrors.COMPANY_DOES_NOT_EXIST);
            }

            if (userRepository.Get().Any(x => x.UserName == userViewModel.UserName))
            {
                resultViewModel.Errors.Add(ApiErrors.USER_EXISTS);
            }

            if (resultViewModel.Errors.Count == 0)
            {
                resultViewModel.Body = await userRepository.AddAsync(mapper.Map<User>(userViewModel));
            }

            if (resultViewModel.Body != null)
            {
                companyUserRepository.AddAsync(resultViewModel.Body.Id, userViewModel.CompanyId);
            }

            return resultViewModel;
        }

        public async Task<ResultViewModel<User>> GetUserByIdAsync(int userId)
        {
            return new ResultViewModel<User> { Body = await userRepository.GetAsync(userId) };
        }

        public async Task<ResultViewModel<IEnumerable<User>>> GetUsersAsync(GetUserViewModel getUserViewModel)
        {
            var users = userRepository.Get();

            if (getUserViewModel.PaginationModel != null)
            {
                return new ResultViewModel<IEnumerable<User>> { Body = await PaginationHelper.ApplyPaginationAsync<User>(getUserViewModel.PaginationModel, users) };
            }

            return new ResultViewModel<IEnumerable<User>> { Body = await users.ToListAsync() };
        }
    }
}
