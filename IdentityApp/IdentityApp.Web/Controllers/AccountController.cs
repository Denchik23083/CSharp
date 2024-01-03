using AutoMapper;
using Identity.Db.Entities;
using Identity.Logic;
using IdentityApp.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _service;
        private readonly IMapper _mapper;
        private readonly SignInManager<User> _signInManager;

        public AccountController(IUserService service, 
            IMapper mapper, 
            SignInManager<User> signInManager)
        {
            _service = service;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = model.Email, UserName = model.UserName, Year = model.Year };

                //var user = _mapper.Map<User>(model);

                var result = await _service.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
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
    }
}
