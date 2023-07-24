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
        private readonly IGradeService _gradeService;
        public StudentController(IGradeService gradeService)
        {
            _gradeService = gradeService;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetStudent(int id)
        {
            int grade = 0;
            grade = await _gradeService.GetStudentGrade(id);
            Student student = new Student { Id=id,FirstName="Paul",LastName="Davis",Grade=grade};
            return Ok(student);
        }
    }
}
