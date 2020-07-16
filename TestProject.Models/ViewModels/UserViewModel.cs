using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TestProject.Models.ViewModels
{
    public class UserViewModel
    {
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Required]
        public int CompanyId { get; set; }
    }
}
