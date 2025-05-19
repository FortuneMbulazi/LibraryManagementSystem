using LibraryManagementSystemApi.Interfaces;
using LibraryManagementSystemApi.Repository;

namespace LibraryManagementSystemApi.Helpers
{
    public static class Services
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient<IBook, BookRepository>();
            services.AddScoped<IDBService, DapperDbService>();
        }
    }
}
