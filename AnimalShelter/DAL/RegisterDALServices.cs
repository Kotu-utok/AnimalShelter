using DAL.DALServices.Implementation;
using DAL.DALServices.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class RegisterDALServices
    {
        public static IServiceCollection ManageDepenciesDAL(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<MyDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
            serviceCollection.AddScoped<IRegisterAnimalDALService, RegisterAnimalDALService>();
            return serviceCollection;
        }
    }
}
