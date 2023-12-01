using BookStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Api.Extensions
{
    public static class DatabaseExtension
    {
        public static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(opt => 
            {
                opt.UseInMemoryDatabase(configuration.GetConnectionString("ConnectionString"));            
            });
        }
    }
}
