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
    public interface ITeacherService
    {
        List<Teacher> GetAllTeacher();
        ActionResult<Teacher> GetTeacherById(int id);
        void PutTeacher(Teacher stu, int id);
        void DeleteTeacher(int id);
        void PostTeacher(Teacher stu);
    }
}
