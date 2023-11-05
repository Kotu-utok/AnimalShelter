using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CDA.MappingProfile;

namespace CDA
{
    public static class RegisterCDAServices
    {
        public static IServiceCollection RegisterTypeServiceCollectionExtention(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddAutoMapper(typeof(AnimalMappingProfile));
		}
    }
}
