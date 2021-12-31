using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcEntity.Db.Entities;
using MvcEntity.Logic;
using MvcEntity.Web.Models;

namespace MvcEntity.Web.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IService _service;

        public PhoneController(IService service)
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

        #region AddEditDeletePhone
        /*
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(PhoneModel model)
        {
            await _service.AddPhone(Map(model));
            
            return RedirectToAction(nameof(Index));
        }
        
        [HttpGet("id")]
        public async Task<IActionResult> Edit(int id)
        {
            var getToEditPhone = await _service.GetToEditPhone(id);

            return View(getToEditPhone);
        }

        [HttpPost]
        public async Task<IActionResult> EditPhone(PhoneModel model)
        {
            await _service.EditPhone(Map(model));

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeletePhone(id);
            
            return RedirectToAction(nameof(Index));
        }*/
        #endregion

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
