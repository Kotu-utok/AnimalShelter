using AnimalShelterApi.Model;
using AutoMapper;
using CDA.Model;

namespace AnimalShelterApi.MappingProfile
{
    public class AnimalMappingProfile : Profile
    {
        public AnimalMappingProfile() 
        {
            CreateMap<AnimalModel, DomainAnimalModel>().ReverseMap();
        }   
    }
}
