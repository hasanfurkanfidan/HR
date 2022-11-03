using Application.Repository;
using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : BaseApiController
    {
        private readonly PersonService _personService;
        public PersonsController(IPersonRepository personRepository, IMapper mapper)
        {
            _personService = new PersonService(personRepository, mapper);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return GetResponseOnlyResultData(_personService.GetPersonById(id));
        }

        /// <summary>
        /// Çalışanların ne kadar süredir çalıştığını döner(ay bazlı)
        /// </summary>
        [HttpGet("working-times")]
        public IActionResult GetWorkingTimes()
        {
            return GetResponseOnlyResultData(_personService.GetPersonWorkingTimes());
        }

        /// <summary>
        /// Yıllara göre kadın,erkek işe alım istatistiklerini döner
        /// </summary>

        [HttpGet("female-male-indate-statistics")]
        public IActionResult GetFemaleMaleInDateStatistics()
        {
            return GetResponseOnlyResultData(_personService.GetFemaleMalePersonInDateStatistics());
        }
    }
}
