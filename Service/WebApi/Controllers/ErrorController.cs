using Core.Concrete;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Handle()
        {
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            var message = context.Error.Message;
            return StatusCode(StatusCodes.Status500InternalServerError, new ErrorResult(message));
        }
    }
}
