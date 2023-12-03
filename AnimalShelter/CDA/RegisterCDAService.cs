using Microsoft.Extensions.DependencyInjection;
using CDA.MappingProfile;
using CDA.Services.Implementation;
using CDA.Services.Interface;

namespace CDA
{
    public static class RegisterCDAServices
    {
        public static IServiceCollection RegisterTypeServiceCollectionExtention(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(typeof(AnimalMappingProfile));
            serviceCollection.AddScoped<IRegisterAnimalsServices, RegisterAnimalServices>();
            return serviceCollection;
		}
    }
}
