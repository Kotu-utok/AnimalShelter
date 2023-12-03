using CDA.Model;
using Commun;

namespace CDA.Services.Implementation
{
    public interface IRegisterAnimalsServices
    {
        public Task<OperationResult> RegisterAnimal(DomainAnimalModel animal);

        public Task<FetchOperationResult<List<DomainAnimalModel>>> GetAnimals();
    }
}
