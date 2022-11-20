using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookApi.Db.Entities;
using BookApi.Logic;
using BooksApi.Web.Models;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;
        private readonly IMapper _mapper;

        public BooksController(IBookService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _service.GetAll();

            if (!books.Any())
            {
                return NoContent();
            }

            var mapperBooks = _mapper.Map<IEnumerable<BookModel>>(books);

            return Ok(mapperBooks);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await _service.Get(id);

            if (book is null)
            {
                return NoContent();
            }

            var mapperBook = _mapper.Map<BookModel>(book);

            return Ok(mapperBook);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(BookModel model)
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
        public async Task<IActionResult> UpdateBook(int id, BookModel model)
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