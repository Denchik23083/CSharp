using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookApi.Db.Entities;
using BookApi.Logic;
using BooksApi.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _service.GetAll();

            if (!categories.Any())
            {
                return NoContent();
            }

            var mapperCategories = _mapper.Map<IEnumerable<CategoryReadModel>>(categories);

            return Ok(mapperCategories);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var category = await _service.Get(id);

            if (category is null)
            {
                return NoContent();
            }

            var mapperCategory = _mapper.Map<CategoryReadModel>(category);

            return Ok(mapperCategory);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryWriteModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdCategory = _mapper.Map<Category>(model);

            await _service.Create(createdCategory);

            return NoContent();
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateCategory(int id, CategoryWriteModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedCategory = _mapper.Map<Category>(model);

            await _service.Update(updatedCategory, id);

            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _service.Delete(id);

            return NoContent();
        }
    }
}
