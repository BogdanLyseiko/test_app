using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestProject.Models.Entities;

namespace TestProject.DAL.Abstractions
{
    public interface ICompanyRepository
    {
       Task<Company> GetAsync(int id);
    }
}
