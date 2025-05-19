using LibraryManagementSystemApi.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibraryManagementSystemApi.Helpers
{
    public class DapperDbService : IDBService
    {
        private readonly IConfiguration _configuration;
        public DapperDbService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("LibraryManagementSystem");
            return new SqlConnection(connectionString);
        }
    }
}
