using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface ILessonRepository
    {
       List<Lesson> GetAllLessons();
        ActionResult<Lesson> LessonGetLessonById(int id);
        void PostLesson(Lesson less);
        ActionResult PutLesson(Lesson less,int id);
        ActionResult DeleteLesson(int id);
       
    }
}
