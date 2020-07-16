using Microsoft.Extensions.DependencyInjection;
using TestProject.BL.Abstractions;
using TestProject.BL.Implementations;
using TestProject.DAL.Abstractions;
using TestProject.DAL.Implementations;

namespace TestProject.Infrastructure
{
    public class ServiceRegistry
    {
        public static void RegisterCustomServices(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICompanyUserRepository, CompanyUserRepository>();
        }
    }
}
