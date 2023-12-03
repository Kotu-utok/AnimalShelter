using AutoMapper;
using CDA.Model;
using CDA.Services.Implementation;
using Commun;
using DAL.DALServices.Interface;
using DAL.Models;


namespace CDA.Services.Interface
{
    public class RegisterAnimalServices : IRegisterAnimalsServices
    {
        private readonly IRegisterAnimalDALService _registerDALServices;
        private readonly IMapper _mapper; 
        public RegisterAnimalServices(IRegisterAnimalDALService registerDALServices, IMapper mapper) 
        {
            _registerDALServices = registerDALServices;
            _mapper = mapper;
        }

        public async Task<OperationResult> RegisterAnimal(DomainAnimalModel animal)
        {
            int animalIdCreated = await _registerDALServices.AddAnimalToDB(_mapper.Map<DALAnimalModel>(animal));

            return new OperationResult(true, animalIdCreated);
        }

        public async Task<FetchOperationResult<List<DomainAnimalModel>>> GetAnimals()
        {
            List<DALAnimalModel> animalsFromDb = await _registerDALServices.GetAnimalsFromDB();

            return animalsFromDb != null && animalsFromDb.Any()
                ? new FetchOperationResult<List<DomainAnimalModel>>(_mapper.Map<List<DomainAnimalModel>>(animalsFromDb), true)
                : new FetchOperationResult<List<DomainAnimalModel>>(false, "No animals found");
        }
    }
}
