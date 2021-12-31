using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookApi.Db.Entities;
using BookApi.Logic;
using BookApi.WebDb;
using BooksApi.Web.Models;

namespace BooksApi.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _service;

        public BooksController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("id")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        [HttpPost]
        public IActionResult CreateBook(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var created = _service.Create(Map(model));


            return Ok(Map(created));
        }

        [HttpPut("id")]
        public IActionResult UpdateBook(int id, BookModel model)
        {
            try
            {
                model.Id = id;
                _service.Update(Map(model));
            }
            catch (ArgumentException)
            {
                return NotFound($"Book with id {id} not found");
            }

            return NoContent();
        }

        [HttpDelete("id")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                _service.Delete(id);
            }
            catch (ArgumentException)
            {
                return NotFound($"Book with id {id} not found");
            }

            return NoContent();
        }

        public static BookModel Map(Book model)
        {
            return new BookModel
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                PagesCount = model.PagesCount,
                PublishDate = model.PublishDate,
            };
        }

        public static Book Map(BookModel model)
        {
            return new Book
            {
                Id = model.Id,
                Title = model.Title,
                Author = model.Author,
                PagesCount = model.PagesCount,
                PublishDate = model.PublishDate,
            };
        }
    }
}