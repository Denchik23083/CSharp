using AutoMapper;
using BooksApi.Logic.BooksService;
using BooksApi.Web.Models.BooksModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksCategoriesController : ControllerBase
    {
        private readonly IBooksService _service;
        private readonly IMapper _mapper;

        public BooksCategoriesController(IBooksService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooksCategories()
        {
            var books = await _service.GetAllBooksCategories();

            var mapperBooks = _mapper.Map<IEnumerable<BooksReadModel>>(books);

            return Ok(mapperBooks);
        }
    }
}
