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
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void DeleteStudent(int id)
        {
           _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudent()
        {
           return _studentRepository.GetAllStudent();
        }

        public ActionResult<Student> GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public void PostStudent(Student stu)
        {
            _studentRepository.PostStudent(stu);
        }

        public void PutStudent(Student stu, int id)
        {
           _studentRepository.PutStudent(stu, id);
        }
    }
}
