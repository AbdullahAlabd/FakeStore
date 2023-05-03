using FakeStore.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace FakeStore.API
{
    public static class ConfigurationServiceCollectionExtension
    {
        public static void AppCollectionExtension(this IServiceCollection services, IConfiguration configuration)
        {
            #region resolve the context 
            services.AddDbContext<ApplicationDBContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            #endregion            
        }
    }
}
