using BookStore.Domain.Entities;
using BookStore.Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStoreServsice _bookStoreService;

        public BooksController(BookStoreServsice bookStoreService)
        {
            _bookStoreService = bookStoreService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks() 
            => Ok(await _bookStoreService.GetBooks());

        [HttpPost]
        public async Task<IActionResult> SaveBook([FromBody] Book book)
        {
            await _bookStoreService.SaveBook(book);

            return Ok(book);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBook(string bookId) 
            => Ok(await _bookStoreService.GetBookbyId(bookId));

        [HttpPut("{bookId}")]
        [ApiExplorerSettings(IgnoreApi = true)]
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
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> RemoveBook(string bookId)
        {
            return NoContent();
        }
    }
}
