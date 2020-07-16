using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Models.ViewModels;

namespace TestProject.Helpers
{
    public static class ResultHelper
    {
        public static IActionResult GetActionResult<T>(ResultViewModel<T> resultViewModel)
        {
            if(resultViewModel.Errors.Any())
            {
                return new BadRequestObjectResult(resultViewModel.Errors);
            }
            else
            {
                return new OkObjectResult(resultViewModel.Body);
            }
        }
    }
}
