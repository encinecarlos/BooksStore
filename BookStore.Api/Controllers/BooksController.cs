using BookStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            return Ok("Lista e livros");
        }

        [HttpPost]
        public async Task<IActionResult> SaveBook([FromBody] Book book)
        {
            return Ok(book);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBook(string bookId)
        {
            return Ok(bookId);
        }

        [HttpPut("{bookId}")]
        public async Task<IActionResult> UpdateBook(string bookId, Book book)
        {
            return Ok(new
            {
                bookId = bookId,
                data = new
                {
                    title = book.Title
                }
            });
        }

        [HttpDelete("{bookId}")]
        public async Task<IActionResult> RemoveBook(string bookId)
        {
            return NoContent();
        }
    }
}
