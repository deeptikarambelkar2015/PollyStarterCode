using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace GradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        private static int counter;
        [HttpGet]
        [Route("{id}")]
        public ActionResult<int> Get(int id)
        {

            try
            {
                if (counter < 5)
                {
                    counter++;
                    throw new Exception();
                }
                else if (counter == 5)
                {
                    counter = 0;
                }
                return 1;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
