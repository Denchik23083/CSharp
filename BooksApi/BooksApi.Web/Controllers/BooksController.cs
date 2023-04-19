using AutoMapper;
using BooksApi.Db.Entities;
using BooksApi.Logic.BooksService;
using BooksApi.Web.Models.BooksModels;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _service;
        private readonly IMapper _mapper;

        public BooksController(IBooksService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _service.GetAll();

            var mapperBooks = _mapper.Map<IEnumerable<BooksReadModel>>(books);

            return Ok(mapperBooks);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _service.Get(id);

            var mapperBook = _mapper.Map<BooksReadModel>(book);

            return Ok(mapperBook);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(BooksWriteModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdBook = _mapper.Map<Book>(model);

            await _service.Create(createdBook);

            return NoContent();
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateBook(BooksWriteModel model, int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updatedBook = _mapper.Map<Book>(model);

            await _service.Update(updatedBook, id);

            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _service.Delete(id);

            return NoContent();
        }
    }
}
