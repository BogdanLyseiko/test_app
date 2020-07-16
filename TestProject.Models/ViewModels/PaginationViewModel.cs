using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace TestProject.Models.ViewModels
{
    public class PaginationViewModel
    {
        [BindProperty(Name = "itemsPerPage", SupportsGet = true)]
        public int ItemsPerPage { get; set; }
        [BindProperty(Name = "page", SupportsGet = true)]
        public int Page { get; set; }
    }
}
