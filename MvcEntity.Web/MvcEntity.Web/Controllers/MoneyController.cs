using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using MvcEntity.Db.Entities;
using MvcEntity.Logic;
using MvcEntity.Web.Models;

namespace MvcEntity.Web.Controllers
{
    public class MoneyController : Controller
    {
        private readonly IMoneyService _service;

        public MoneyController(IMoneyService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Payment()
        {
            var payment = await _service.Payment();

            if (!payment)
            {
                return RedirectToAction(nameof(OrderController.Index), "Order");
            }

            return RedirectToAction(nameof(PhoneController.Index), "Phone");
        }

        [HttpPost]
        public IActionResult Replenish(ReplenishModel model)
        {
            _service.Replenish(Map(model));

            return RedirectToAction(nameof(UserController.Index), "User");
        }

        private static Replenish Map(ReplenishModel model)
        {
            return new Replenish
            {
                Money = model.Money
            };
        }
    }
}