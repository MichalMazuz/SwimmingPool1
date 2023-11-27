using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Services
{
    public interface IStudentService
    {
        List<Student> GetAllStudent();
        ActionResult<Student> GetStudentById(int id);
        void PutStudent(Student stu,int id);
        void DeleteStudent(int id);
        void PostStudent(Student stu);
    }
}
