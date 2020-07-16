using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace TestProject.Models.ViewModels
{
    public class GetUserViewModel: PaginationViewModel
    {
        [BindProperty(Name = "id", SupportsGet = true)]
        public int? Id { get; set; }

        [BindProperty]
        public PaginationViewModel PaginationModel { get; set; }
    }
}
