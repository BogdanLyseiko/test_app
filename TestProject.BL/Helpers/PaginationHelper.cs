using System.Collections.Generic;
using System.Linq;
using TestProject.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace TestProject.BL.Helpers
{
    public class PaginationHelper
    {
        public static async Task<IEnumerable<T>> ApplyPaginationAsync<T>(PaginationViewModel paginationViewModel, IQueryable<T> data)
        {
            return await data.Skip((int)paginationViewModel.ItemsPerPage * (int)paginationViewModel.Page).Take((int)paginationViewModel.ItemsPerPage).ToListAsync();
        }
    }
}
