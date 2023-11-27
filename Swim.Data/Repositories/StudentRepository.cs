using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;

        public ActionResult DeleteStudent(int id)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return new NotFoundResult();
            _context.students.Remove(st);
            return new OkResult();
        }

        public List<Student> GetAllStudent()
        {
            return _context.students;
        }

        public ActionResult<Student> GetStudentById(int id)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return new NotFoundResult();
            return st;
        }

        public void PostStudent(Student s)
        {
            _context.students.Add(new Student { StudentId = _context.StudentCount++, StudentFirstName = s.StudentFirstName, StudentLastName = s.StudentLastName, Address = s.Address, StudentPhone = s.StudentPhone, ParentsPhone = s.ParentsPhone, DateOfBirth = s.DateOfBirth, StudentEmail = s.StudentEmail, StudentStatus = s.StudentStatus, StudentStatusDescription = s.StudentStatusDescription });
        }

        public ActionResult PutStudent(Student s, int id)
        {
            var st = _context.students.Find(s => s.StudentId == id);
            if (st == null)
                return new NotFoundResult();
            st.StudentEmail = s.StudentEmail;
            st.StudentStatus = s.StudentStatus;
            st.StudentPhone = s.StudentPhone;
            st.StudentLastName = s.StudentLastName;
            st.DateOfBirth = s.DateOfBirth;
            st.StudentPhone = s.StudentPhone; ;
            st.ParentsPhone = s.ParentsPhone;
            st.StudentFirstName = s.StudentFirstName;
            st.StudentStatusDescription = s.StudentStatusDescription;
            return new  OkResult();
        }

    }
}
