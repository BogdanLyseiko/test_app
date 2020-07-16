
using System.Collections.Generic;

namespace TestProject.Models.Entities
{
    public class Company
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public IEnumerable<CompanyUser> CompanyUsers { get; set; }
    }
}
