using Application.Dtos;
using Application.Repository;
using AutoMapper;
using Core.Abstract;
using Core.Concrete;

namespace Application.Services
{
    public class DepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public IDataResult<List<DepartmentDto>> GetDepartments()
        {
            var mappedDepartments = _mapper.Map<List<DepartmentDto>>(_departmentRepository.GetAll());
            return new SuccessDataResult<List<DepartmentDto>>(mappedDepartments);
        }
    }
}
