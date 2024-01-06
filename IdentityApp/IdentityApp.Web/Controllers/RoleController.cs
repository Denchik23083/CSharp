using IdentityApp.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;
using IdentityApp.Logic.RoleService;
using Microsoft.AspNetCore.Identity;
using IdentityApp.Logic.UserService;
using IdentityApp.Web.Models;

namespace IdentityApp.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IRoleService _service;
        private readonly IUserService _userService;

        public RoleController(IRoleService service, IUserService userService)
        {
            _service = service;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var roles = await _service.GetRolesAsync();

            return View(roles);
        }

        public async Task<IActionResult> UserList()
        {
            var users = await _userService.GetUsersAsync();

            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                var role = new IdentityRole(name);

                var result = await _service.CreateRoleAsync(role);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            return View(name);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string userId)
        {
            try
            {
                var role = await _service.GetRoleAsync(userId);

                return View(new ChangeRoleViewModel { UserId = role.UserId, UserName = role.UserName, UserRoles = role.UserRoles, AllRoles = role.AllRoles });
            }
            catch (RoleNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(string userId, List<string> roles)
        {
            try
            {
                await _service.UpdateRoleAsync(userId, roles);

                return RedirectToAction("UserList");
            }
            catch (RoleNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var result = await _service.DeleteRoleAsync(id);

                return RedirectToAction("Index");
            }
            catch (RoleNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
