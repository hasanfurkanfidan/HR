using Application.Repository;
using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : BaseApiController
    {
        private readonly PositionService _positionService;
        public PositionsController(IPositionRepository positionRepository, IMapper mapper)
        {
            _positionService = new PositionService(positionRepository, mapper);
        }

        [HttpGet("{position}/average-salary")]
        public IActionResult GetAverageSalaryOfPosition(string position)
        {
            return GetResponseOnlyResultData(_positionService.GetAverageSalaryOfPosition(position));
        }
    }
}
