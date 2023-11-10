using Microsoft.AspNetCore.Mvc;
using SwimmingPool.Entities;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _context;
        public StudentController(DataContext context)
        {
            _context = context;
        }

        // GET: api/<StudentController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return _context.students;
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return NotFound();
            return st;
        }

        // POST api/<StudentController>
        [HttpPost]
        public ActionResult Post([FromBody] Student s)
        {
            //if (s.StudentId.ToString().Length != 9)
            //    return BadRequest();
            _context.students.Add(new Student { StudentId = _context.StudentCount++, StudentFirstName = s.StudentFirstName, StudentLastName = s.StudentLastName, Address = s.Address, StudentPhone = s.StudentPhone, ParentsPhone = s.ParentsPhone, DateOfBirth = s.DateOfBirth, StudentEmail = s.StudentEmail, StudentStatus = s.StudentStatus, StudentStatusDescription = s.StudentStatusDescription });
            return Ok();

        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Student s)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return NotFound();
            st.StudentEmail = s.StudentEmail;
            st.StudentStatus = s.StudentStatus;
            st.StudentPhone = s.StudentPhone;
            st.StudentLastName = s.StudentLastName;
            st.DateOfBirth = s.DateOfBirth;
            st.StudentPhone = s.StudentPhone; ;
            st.ParentsPhone = s.ParentsPhone;
            st.StudentFirstName = s.StudentFirstName;
            st.StudentStatusDescription = s.StudentStatusDescription;
            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return NotFound();
            _context.students.Remove(st);
            return Ok();
        }
    }
}
