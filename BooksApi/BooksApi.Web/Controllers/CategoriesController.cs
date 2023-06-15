using AutoMapper;
using BooksApi.Db.Entities;
using BooksApi.Logic.CategoriesService;
using BooksApi.Web.Models.CategoriesModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoriesService _service;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoriesService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var categories = await _service.GetAll();

            var mapperCategories = _mapper.Map<IEnumerable<CategoriesReadModel>>(categories);

            return Ok(mapperCategories);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetCategory(int id)
        {
            try
            {
                var category = await _service.Get(id);

                var mapperCategory = _mapper.Map<CategoriesReadModel>(category);

                return Ok(mapperCategory);
            }
            catch (ArgumentException)
            {
                return NotFound($"Category with id {id} not found");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoriesWriteModel model)
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
        public async Task<IActionResult> UpdateCategory(CategoriesWriteModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedCategory = _mapper.Map<Category>(model);

                await _service.Update(updatedCategory, id);

                return NoContent();
            }
            catch (ArgumentException)
            {
                return NotFound($"Category with id {id} not found");
            }
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            try
            {
                await _service.Delete(id);

                return NoContent();
            }
            catch (ArgumentException)
            {
                return NotFound($"Category with id {id} not found");
            }
        }
    }
}
