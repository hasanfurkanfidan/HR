using Application.Dtos;
using AutoMapper;
using Domain;

namespace Application.DtoProfiles
{
    public class DeparmentProfile : Profile
    {
        public DeparmentProfile()
        {
            CreateMap<Department, DepartmentDto>();
        }
    }
}
