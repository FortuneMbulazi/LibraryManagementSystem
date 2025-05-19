using System.Data;

namespace LibraryManagementSystemApi.Interfaces
{
    public interface IDBService
    {
        IDbConnection CreateConnection();
    }
}
