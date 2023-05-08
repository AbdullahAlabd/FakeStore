using FakeStore.Business.EntityManagers;
using FakeStore.DataAccess;
using FakeStore.DataAccess.DAO.Concrete;
using FakeStore.DataAccess.DAO.Interface;
using Microsoft.EntityFrameworkCore;

namespace FakeStore.API
{
    public static class ConfigurationServiceCollectionExtension
    {
        public static void AppCollectionExtension(this IServiceCollection services, IConfiguration configuration)
        {
            #region Resolve Entity Managers
            services.AddScoped<IUserManager, UserManager>();
            #endregion

            #region Resolve Data Access Objects
            services.AddScoped<IUserDAO, UserDAO>();
            #endregion

            #region Resolve DB Context
            services.AddDbContext<ApplicationDBContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            #endregion            
        }
    }
}
