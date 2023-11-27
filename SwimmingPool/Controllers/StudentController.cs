using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_studentService.GetAllStudent());
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var stu = _studentService.GetStudentById(id);
            if (stu == null)
                return NotFound();
            return stu;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Student stu)
        {
            _studentService.PostStudent(stu);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student stu)
        {
            _studentService.PutStudent(stu, id);
            return Ok();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return Ok();
        }
    }
}
