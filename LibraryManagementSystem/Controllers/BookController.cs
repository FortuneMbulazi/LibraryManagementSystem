using BO;
using LibraryManagementSystemApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystemApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBook _book;

        public BookController(IBook book)
        {
            _book = book;
        }

        [HttpGet("GetAllAsync")]
        public async Task<List<Book>> GetAllAsync()
        {
            return await _book.GetAllAsync();
        }

        [HttpGet("GetByIdAsync")]
        public async Task<Book> GetByIdAsync(long id)
        {
            return await _book.GetByIdAsync(id);
        }

        [HttpPost("CreateAsync")]
        public async Task<bool> CreateAsync(Book book)
        {
            return await _book.CreateAsync(book);
        }

        [HttpPut("UpdateAsync")]
        public async Task<bool> UpdateAsync(Book book)
        {
            return await _book.UpdateAsync(book);
        }
    }
}
