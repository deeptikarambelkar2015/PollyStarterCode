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
            //For this example we will be returning a random number between 1 and 10
            return GetStudentGrade();
            // return StatusCode(StatusCodes.Status500InternalServerError);

        }

        private int GetStudentGrade()
        {
            Random rnd = new Random();
            int grade = rnd.Next(1, 11);  // creates a number between 1 and 10
            return grade;
        }

    }
}
