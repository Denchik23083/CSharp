using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcEntity.Db.Entities;
using MvcEntity.Logic;
using MvcEntity.Web.Models;

namespace MvcEntity.Web.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IPhoneService _service;

        public PhoneController(IPhoneService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var phone = await _service.GetPhone();

            return View(phone);
        }

        [HttpGet("id")]
        public async Task<IActionResult> Push(int id)
        {
            await _service.Push(id);

            return NoContent();
        }

        private static Phone Map(PhoneModel model)
        {
            return new Phone
            {
                Id = model.Id,
                Name = model.Name,
                Company = model.Company,
                Price = model.Price
            };
        }
    }
}