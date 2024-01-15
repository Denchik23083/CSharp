using Caching.Logic;
using Caching.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Caching.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICachingService _service;

        public HomeController(ILogger<HomeController> logger, ICachingService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public new async Task<IActionResult> User(int id)
        {
            try
            {
                var user = await _service.GetUser(id);

                return Content($"User: {user.Name}");
            }
            catch (ArgumentNullException e)
            {
                return Content(e.Message);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}