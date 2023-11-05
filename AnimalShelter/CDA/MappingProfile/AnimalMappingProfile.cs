using AutoMapper;
using CDA.Model;
using DAL.Models;

namespace CDA.MappingProfile
{
    public class AnimalMappingProfile : Profile
    {
        public AnimalMappingProfile() 
        {
            CreateMap<DomainAnimalModel, DALAnimalModel>();
            CreateMap<DALAnimalModel, DomainAnimalModel>();
        }   
    }
}
