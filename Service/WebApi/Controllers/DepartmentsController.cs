using Application.Repository;
using Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : BaseApiController
    {
        private readonly DepartmentService _departmentService;
        public DepartmentsController(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentService = new DepartmentService(departmentRepository, mapper);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return GetResponseOnlyResultData(_departmentService.GetDepartments());
        }
    }
}
