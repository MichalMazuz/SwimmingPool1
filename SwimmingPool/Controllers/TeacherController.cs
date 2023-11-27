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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_teacherService.GetAllTeacher());
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var less = _teacherService.GetTeacherById(id);
            if (less == null)
                return NotFound();
            return less;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Teacher less)
        {
            _teacherService.PostTeacher(less);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher less)
        {
            _teacherService.PutTeacher(less, id);
            return Ok();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _teacherService.DeleteTeacher(id);
            return Ok();
        }
    }
}
