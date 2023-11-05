using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class RegisterDALServices
    {
        public static IServiceCollection ManageDepenciesDAL(this IServiceCollection serviceCollection, string connectionString)
        {
            return serviceCollection.AddDbContext<MyDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}
