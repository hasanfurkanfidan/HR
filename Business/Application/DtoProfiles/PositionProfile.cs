using Application.Dtos;
using Application.SPModels;
using AutoMapper;
using Domain;

namespace Application.DtoProfiles
{
    public class PositionProfile : Profile
    {
        public PositionProfile()
        {
            CreateMap<Position, PositionDto>();
            CreateMap<AverageSalaryOfPositionSPModel, AverageSalaryOfPositionDto>();
        }
    }
}
