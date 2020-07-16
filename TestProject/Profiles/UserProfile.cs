using AutoMapper;
using TestProject.Models.Entities;
using TestProject.Models.ViewModels;

namespace TestProject.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserViewModel, User>();
        }
    }
}
