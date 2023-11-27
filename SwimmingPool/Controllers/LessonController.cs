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
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService)
        {
            _lessonService = lessonService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_lessonService.GetAllLessons());
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Lesson> Get(int id)
        {
            var less = _lessonService.LessonGetLessonById(id);
            if (less == null)
                return  NotFound();
            return less;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Lesson less)
        {
            _lessonService.PostLesson(less);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Lesson less)
        {
            _lessonService.PutLesson(less, id);
            return Ok();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _lessonService.DeleteLesson(id);
            return Ok();
        }
    }
}
