using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.DAL.Abstractions
{
    public interface ICompanyUserRepository
    {
        public void AddAsync(int userId, int companyId);
    }
}
