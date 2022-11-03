using Application.Constants;
using Application.Dtos;
using Application.Repository;
using AutoMapper;
using Core.Abstract;
using Core.Concrete;

namespace Application.Services
{
    public class PersonService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public IDataResult<PersonDto> GetPersonById(int id)
        {
            var person = _personRepository.GetById(id);
            if (person == null)
                return new ErrorDataResult<PersonDto>(BusinessMessages.DataNotFound);

            var mappedPerson = _mapper.Map<PersonDto>(person);
            return new SuccessDataResult<PersonDto>(mappedPerson);
        }

        public IDataResult<List<PersonWorkingTimeDto>> GetPersonWorkingTimes()
        {
            var personWorkingTimes = _personRepository.GetPersonWorkingTimes();
            var mappedPersonWorkingTimes = _mapper.Map<List<PersonWorkingTimeDto>>(personWorkingTimes);
            return new SuccessDataResult<List<PersonWorkingTimeDto>>(mappedPersonWorkingTimes);
        }

        public IDataResult<List<FemaleMalePersonsInDateStatisticsDto>> GetFemaleMalePersonInDateStatistics()
        {
            var personInDateStatistics = _personRepository.GetFemaleMaleInDateStatistics();
            var mappedPersonInDateStatistics = _mapper.Map<List<FemaleMalePersonsInDateStatisticsDto>>(personInDateStatistics);
            return new SuccessDataResult<List<FemaleMalePersonsInDateStatisticsDto>>(mappedPersonInDateStatistics);
        }
    }
}
