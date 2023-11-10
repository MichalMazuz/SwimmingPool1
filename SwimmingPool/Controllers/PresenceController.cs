using Microsoft.AspNetCore.Mvc;
using SwimmingPool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceController : ControllerBase
    {
        private readonly DataContext _context;
        public PresenceController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<PresenceController>
        [HttpGet]
        public IEnumerable<Presence> Get()
        {
            return _context.presences;
        }

        // GET api/<PresenceController>/5
        [HttpGet("{id,id,id}")]
        public ActionResult<Presence> Get(int idT, int idL, int idS)
        {
            var pre = _context.presences.Find(p => p.TeacherId == idT && p.StudentId == idS && p.LessonId == idL);
            if (pre == null)
                return NotFound();
            return pre;
        }

        // POST api/<PresenceController>
        [HttpPost]
        public void Post([FromBody] Presence p)
        {
            _context.presences.Add(new Presence { LessonId = p.LessonId, TeacherId = p.TeacherId, StudentId = p.StudentId, IsPresent = p.IsPresent });

        }

        // PUT api/<PresenceController>/5
        [HttpPut("{id,id,id}")]
        public ActionResult Put(int idT, int idL, int idS, [FromBody] Presence p)
        {
            var pre = _context.presences.Find(p => p.TeacherId == idT && p.StudentId == idS && p.LessonId == idL);
            if (pre == null)
                return NotFound();
            pre.IsPresent = p.IsPresent;
            return Ok();
        }

        // DELETE api/<PresenceController>/5

    }
}
