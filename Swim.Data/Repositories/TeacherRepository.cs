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
    public class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;
        public TeacherRepository(DataContext context)
        {
            _context = context;
        }

        public ActionResult DeleteTeacher(int id)
        {
            var teach = _context.teachers.ToList().Find(t => t.TeacherId == id);
            if (teach == null)
                return new NotFoundResult();
            _context.teachers.Remove(teach);
            return new OkResult();
        }

        public List<Teacher> GetAllTeacher()
        {
            return _context.teachers.ToList();
        }

        public ActionResult<Teacher> GetTeacherById(int id)
        {
            var teach = _context.teachers.ToList().Find(t => t.TeacherId == id);
            if (teach == null)
                return new NotFoundResult();
            return teach;
        }

        public void PostTeacher(Teacher t)
        {
            _context.teachers.Add(new Teacher { TeacherId = _context.TeacherCount++, TeacherFirstName = t.TeacherFirstName, TeacherLastName = t.TeacherLastName, TeacherAddress = t.TeacherAddress, TeacherPhone = t.TeacherPhone, TeacherEmail = t.TeacherEmail, TeacherStatus = t.TeacherStatus, TeacherDays=t.TeacherDays ,TeacherHour = t.TeacherHour });
        }

        public ActionResult PutTeacher(Teacher t, int id)
        {
            var teach = _context.teachers.ToList().Find(t => t.TeacherId == id);
            if (teach == null)
                return new NotFoundResult();
            teach.TeacherHour = t.TeacherHour;
            teach.TeacherStatus = t.TeacherStatus;
            teach.TeacherPhone = t.TeacherPhone;
            teach.TeacherEmail = t.TeacherEmail;
            teach.TeacherAddress = t.TeacherAddress;
            teach.TeacherFirstName = t.TeacherFirstName;
            teach.TeacherLastName = t.TeacherLastName;
            teach.TeacherDays = t.TeacherDays;
            return new OkResult();
        }
    }
}
