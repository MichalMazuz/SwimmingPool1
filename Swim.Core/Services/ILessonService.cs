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
    public interface ILessonService
    {
        List<Lesson> GetAllLessons();
        ActionResult<Lesson> LessonGetLessonById(int id);//מחזיר משהו
        void PutLesson(Lesson less,int id);//לא מחזירים כלום מזמנים לי את הפעולה שכתובה בריפוזטורי
        void DeleteLesson(int id);
        void PostLesson(Lesson less);
    }
}
