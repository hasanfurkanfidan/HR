using Application.Dtos;
using Application.SPModels;
using AutoMapper;
using Domain;

namespace Application.DtoProfiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<PersonWorkingTimeSPModel, PersonWorkingTimeDto>();
            CreateMap<FemaleMalePersonsInDateStatisticsSPModel, FemaleMalePersonsInDateStatisticsDto>();
        }
    }
}
