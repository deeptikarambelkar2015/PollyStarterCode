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
            //this should come from the db.
            //For this example we will be returning Grade 7
            return 7;

            // return StatusCode(StatusCodes.Status500InternalServerError);

        }

    }
}
