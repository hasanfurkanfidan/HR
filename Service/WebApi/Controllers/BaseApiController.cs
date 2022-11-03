using Core.Abstract;
using Core.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BaseApiController : ControllerBase
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        internal ActionResult GetResponseOnlyResultData<T>(IDataResult<T> result)
        {
            if (result == null)
                return NotFound(new ErrorResult());

            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        internal ActionResult GetResponseOnlyResult(Core.Abstract.IResult result)
        {
            if (result == null)
                return NotFound(new ErrorResult());

            return result.IsSuccessful ? Ok(result) : BadRequest(result);
        }
    }
}
