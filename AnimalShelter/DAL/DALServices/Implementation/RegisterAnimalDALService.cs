
using Commun;
using DAL.DALServices.Interface;
using DAL.Models;

namespace DAL.DALServices.Implementation
{
    public class RegisterAnimalDALService : IRegisterAnimalDALService
    {
        MyDbContext dbContext;
        public RegisterAnimalDALService(MyDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<int> AddAnimalToDB(DALAnimalModel animal)
        {
            dbContext.Animals.Add(animal);

            await dbContext.SaveChangesAsync();

            return animal.AnimalID;
        }

        public async Task<List<DALAnimalModel>> GetAnimalsFromDB()
        {
            return dbContext.Animals.ToList();
        }
    }
}
