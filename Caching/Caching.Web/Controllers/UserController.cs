using AutoMapper;
using Caching.Db.Entities;
using Caching.Logic;
using Caching.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace Caching.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly ICachingService _service;
        private readonly IMapper _mapper;

        public UserController(ICachingService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                var users = await _service.GetUsersAsync();

                var mappedUsers = _mapper.Map<IEnumerable<UserViewModel>>(users);

                return View(mappedUsers);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            try
            {
                var user = await _service.GetUserAsync(id);

                var mappedUser = _mapper.Map<UserViewModel>(user);

                return View(mappedUser);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(UserViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var mappedUser = _mapper.Map<User>(model);

                await _service.CreateAsync(mappedUser);

                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var user = await _service.GetUserAsync(id);

                var mappedUser = _mapper.Map<UserViewModel>(user);

                return View(mappedUser);
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserViewModel model)
        {
            try
            {
                var mappedUser = _mapper.Map<User>(model);

                await _service.UpdateAsync(mappedUser);

                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.DeleteAsync(id);

                return RedirectToAction(nameof(Index));
            }
            catch (ArgumentNullException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
