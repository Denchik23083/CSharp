using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MvcEntity.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}
