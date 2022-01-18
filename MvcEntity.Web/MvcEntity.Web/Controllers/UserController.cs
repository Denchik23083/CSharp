using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;
using MvcEntity.Logic;
using MvcEntity.Web.Models;

namespace MvcEntity.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var getUser = _service.GetUser();

            return View(getUser);
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var getToEditUser = _service.GetUser();

            return View(getToEditUser);
        }

        [HttpPost]
        public async Task<IActionResult> EditUser(UserModel model)
        {
            await _service.EditUser(Map(model));

            return RedirectToAction(nameof(AuthController.Logout), "Auth");
        }

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            await _service.DeleteUser();

            return RedirectToAction(nameof(AuthController.Logout), "Auth");
        }

        private static User Map(UserModel model)
        {
            return new User
            {
                Name = model.Name,
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}