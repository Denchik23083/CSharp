using IdentityApp.Logic.UserService;
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

        /*[HttpGet]
        public IActionResult Create()
        {
            return View();
        }*/
    }
}
