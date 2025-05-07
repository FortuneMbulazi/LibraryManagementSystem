using BO;
using Dapper;
using LibraryManagementSystemApi.Interfaces;
using System.Data;
using Microsoft.Data.SqlClient;

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
            using(var connection = new SqlConnection(_configuration.GetConnectionString("LibraryManagementSystem")))
            {
                return (List<Book>)await connection.QueryAsync<List<Book>>("GetAllBooks", commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<Book> GetByIdAsync(long id)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("LibraryManagementSystem")))
            {
                return (Book)await connection.QueryAsync<Book>("GetBookById", new { Id = id }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<bool> CreateAsync(Book book)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("LibraryManagementSystem")))
            {
                var param = new { Title = book.Title, Author = book.Author, ISBN = book.ISBN };
                var results = await connection.ExecuteScalarAsync<bool>("CreateBook", param, commandType: CommandType.StoredProcedure);
                return results;
            }
        }

        public async Task<bool> UpdateAsync(Book book)
        {
            return true;
        }
    }
}
