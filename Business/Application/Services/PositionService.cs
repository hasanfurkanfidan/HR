using Application.Dtos;
using Application.Repository;
using AutoMapper;
using Core.Abstract;
using Core.Concrete;

namespace Application.Services
{
    public class PositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IMapper _mapper;
        public PositionService(IPositionRepository positionRepository, IMapper mapper)
        {
            _positionRepository = positionRepository;
            _mapper = mapper;
        }

        public IDataResult<AverageSalaryOfPositionDto> GetAverageSalaryOfPosition(string position)
        {
            var data = _positionRepository.GetAverageSalaryOfPosition(position);
            return new SuccessDataResult<AverageSalaryOfPositionDto>(_mapper.Map<AverageSalaryOfPositionDto>(data));
        }
    }
}
