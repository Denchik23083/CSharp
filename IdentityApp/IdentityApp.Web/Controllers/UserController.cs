using IdentityApp.Core.Exceptions;
using IdentityApp.Db.Entities;
using IdentityApp.Logic.UserService;
using IdentityApp.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _service.GetUsersAsync();

            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = model.Email, UserName = model.UserName, Year = model.Year };

                var result = await _service.CreateUserAsync(user, model.Password);

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

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Update(string id)
        {
            try
            {
                var user = await _service.GetUserAsync(id);

                return View(new UpdateUserViewModel { Id = user.Id, UserName = user.UserName, Email = user.Email, Year = user.Year });
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = new User { Id = model.Id, Email = model.Email, UserName = model.UserName, Year = model.Year };

                    var result = await _service.UpdateUserAsync(user);

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
                catch (UserNotFoundException e)
                {
                    return NotFound(e.Message);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                var result = await _service.DeleteUserAsync(id);

                return RedirectToAction("Index");
            }
            catch (UserNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
