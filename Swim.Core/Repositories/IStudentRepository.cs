using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudent();
        ActionResult<Student> GetStudentById(int id);
        void PostStudent(Student stu);
        ActionResult PutStudent(Student stu,int id);
        ActionResult DeleteStudent(int id);
       
    }
}
