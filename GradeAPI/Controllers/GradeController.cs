using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace GradeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradeController : ControllerBase
    {
        //private static int counter;

        [HttpGet]
        [Route("{id}")]
        public ActionResult<int> Get(int id)
        {
            //this should come from the db.
            //For this example we will be returning Grade 7
            return 7;
        }




        //public ActionResult<int> Get(int id)
        //{

        //    try
        //    {
        //        counter++;
        //        int remainder = counter % 3; 
        //        //when counter is a multiple of 3, then no error is returned
        //        if (remainder>0)
        //        {
        //            throw new Exception();
        //        }

        //        return 7;
        //    }
        //    catch
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }

        //}


    }
}
