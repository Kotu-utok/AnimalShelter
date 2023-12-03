using DAL.Models;

namespace DAL.DALServices.Interface
{
    public interface IRegisterAnimalDALService
    {
        public Task<int> AddAnimalToDB(DALAnimalModel animal);

        public Task<List<DALAnimalModel>> GetAnimalsFromDB();
    }
}
