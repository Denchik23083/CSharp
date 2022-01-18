using Microsoft.AspNetCore.Mvc;
using MvcEntity.Logic;

namespace MvcEntity.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var order = _service.List();

            return View(order);
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
            _service.RemovePhoneFromOrder(id);

            return RedirectToAction(nameof(Index), "Order");
        }
    }
}