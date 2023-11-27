using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeacher();
        ActionResult<Teacher> GetTeacherById(int id);
        void PostTeacher(Teacher stu);
        ActionResult PutTeacher(Teacher stu, int id);
        ActionResult DeleteTeacher(int id);
        
    }
}
