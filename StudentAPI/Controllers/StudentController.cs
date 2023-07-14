using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Services;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public StudentController() {
            
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetStudent(int id)
        {
            int grade = 1;
            //int grade = await _gradeService.GetStudentGrade(id);
            Student student = new Student { Id=id,FirstName="Paul",LastName="Davis",Grade=grade};
            return Ok(student);
        }
    }
}
