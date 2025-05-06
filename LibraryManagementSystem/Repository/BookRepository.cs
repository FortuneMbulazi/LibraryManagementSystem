using BO;
using LibraryManagementSystemApi.Interfaces;

namespace LibraryManagementSystemApi.Repository
{
    public class BookRepository : IBook
    {
        private readonly IConfiguration _configuration;
        public BookRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return new List<Book>();
        }

        public async Task<Book> GetByIdAsync(long id)
        {
            return new Book();
        }

        public async Task<bool> CreateAsync(Book book)
        {
            return true;
        }

        public async Task<bool> UpdateAsync(Book book)
        {
            return true;
        }
    }
}
