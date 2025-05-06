using BO;

namespace LibraryManagementSystemApi.Interfaces
{
    public interface IBook
    {
        public Task<List<Book>> GetAllAsync();
        public Task<Book> GetByIdAsync(long id);
        public Task<bool> CreateAsync(Book book);
        public Task<bool> UpdateAsync(Book book);
    }
}
