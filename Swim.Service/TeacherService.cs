using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using Swim.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Service
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public void DeleteTeacher(int id)
        {
            _teacherRepository.DeleteTeacher(id);
        }

        public List<Teacher> GetAllTeacher()
        {
            return _teacherRepository.GetAllTeacher();
        }

        public ActionResult<Teacher> GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }

        public void PostTeacher(Teacher stu)
        {
            _teacherRepository.PostTeacher(stu);
        }

        public void PutTeacher(Teacher stu, int id)
        {
            _teacherRepository.PutTeacher(stu, id);
        }

        
    }
}
