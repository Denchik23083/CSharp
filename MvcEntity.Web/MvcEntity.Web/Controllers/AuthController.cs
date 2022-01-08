using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using MvcEntity.Db.Entities;
using MvcEntity.Logic;
using MvcEntity.Web.Models;

namespace MvcEntity.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var user = await _service.Login(Map(model));

            if (user is null)
            {
                return RedirectToAction("Login", "Auth");
            }

            await Authenticate(user.Name);
            
            return RedirectToAction("Main", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (model.ConfirmPassword == model.Password)
            {
                await _service.Register(Map(model));

                return RedirectToAction("Register", "Auth");
            }

            return RedirectToAction("Login", "Auth");
        }

        private async Task Authenticate(string userName)
        {

            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }

        private User Map(RegisterModel model)
        {
            return new User
            {
                Id = model.Id,
                Name = model.Name,
                Balance = 0,
                Email = model.Email,
                Password = model.Password
            };
        }

        private User Map(LoginModel model)
        {
            return new User
            {
                Id = model.Id,
                Email = model.Email,
                Password = model.Password,
            };
        }
    }
}