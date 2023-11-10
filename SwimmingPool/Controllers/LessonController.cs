using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SwimmingPool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        private readonly DataContext _context;
        public LessonController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public IEnumerable<Lesson> Get()
        {
            return _context.lessons;
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Lesson> Get(int id)
        {
            var less = _context.lessons.Find(l => l.LessonId == id);
            if (less == null)
                return NotFound();
            return less;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Lesson less)
        {
            _context.lessons.Add(new Lesson { LessonId = _context.LessonCount++, LessonDescription = less.LessonDescription, LessonHour = less.LessonHour, TeacherId = less.TeacherId });

        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Lesson less)
        {
            var lesson = _context.lessons.Find(l => l.LessonId == id);
            if (lesson == null)
                return NotFound();
            lesson.LessonDescription = less.LessonDescription;
            lesson.LessonHour = less.LessonHour;
            lesson.TeacherId = less.TeacherId;
            return Ok();
        }

        // DELETE api/<LessonController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var less = _context.lessons.Find(l => l.LessonId == id);
            if (less == null)
                return NotFound();
            _context.lessons.Remove(less);
            return Ok();
        }
    }
}
