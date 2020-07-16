using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestProject.BL.Abstractions;
using TestProject.Filters;
using TestProject.Helpers;
using TestProject.Models.Entities;
using TestProject.Models.ViewModels;

namespace TestProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery]GetUserViewModel getUserViewModel)
        {
            if (getUserViewModel.Id.HasValue)
            {
                var result = await userService.GetUserByIdAsync((int)getUserViewModel.Id);

                return ResultHelper.GetActionResult<User>(result);
            }
            else
            {
                var result = await userService.GetUsersAsync(getUserViewModel);

                return ResultHelper.GetActionResult<IEnumerable<User>>(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(UserViewModel userViewModel)
        {
            var result = await userService.AddUserAsync(userViewModel);

            return ResultHelper.GetActionResult<User>(result);
        }
    }
}
