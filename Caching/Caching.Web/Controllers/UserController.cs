using Caching.Logic;
using Microsoft.AspNetCore.Mvc;

namespace Caching.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ICachingService _service;

        public UserController(ICachingService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _service.GetUsersAsync();
            
            return View(users);
        }

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var user = await _service.GetUserAsync(id);

                return Content($"User: {user.Name}");
            }
            catch (ArgumentNullException e)
            {
                return Content(e.Message);
            }
        }
    }
}
