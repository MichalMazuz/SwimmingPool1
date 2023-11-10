using Microsoft.AspNetCore.Mvc;
using SwimmingPool.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly DataContext _context;
        public TeacherController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<Teacher> Get()
        {
            return _context.teachers;
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public ActionResult<Teacher> Get(int id)
        {
            var teach = _context.teachers.Find(t => t.TeacherId == id);
            if (teach == null)
                return NotFound();
            return teach;
        }

        // POST api/<TeacherController>
        [HttpPost]
        public ActionResult Post([FromBody] Teacher t)
        {
            //if (t.TeacherId.ToString().Length != 9)
            //    return BadRequest();
            _context.teachers.Add(new Teacher { TeacherId = _context.TeacherCount++, TeacherFirstName = t.TeacherFirstName, TeacherLastName = t.TeacherLastName, TeacherAddress = t.TeacherAddress, TeacherPhone = t.TeacherPhone, TeacherEmail = t.TeacherEmail, TeacherStatus = t.TeacherStatus, /*TeacherDays = t.TeacherDays,*/ TeacherHour = t.TeacherHour });
            return Ok();

        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Teacher t)
        {
            var teach = _context.teachers.Find(t => t.TeacherId == id);
            if (teach == null)
                return NotFound();
            teach.TeacherHour = t.TeacherHour;
            teach.TeacherStatus = t.TeacherStatus;
            teach.TeacherPhone = t.TeacherPhone;
            teach.TeacherEmail = t.TeacherEmail;
            teach.TeacherAddress = t.TeacherAddress;
            teach.TeacherFirstName = t.TeacherFirstName;
            teach.TeacherLastName = t.TeacherLastName;
            //teach.TeacherDays = t.TeacherDays;
            return Ok();
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var teach = _context.teachers.Find(t => t.TeacherId == id);
            if (teach == null)
                return NotFound();
            _context.teachers.Remove(teach);
            return Ok();
        }
    }
}
