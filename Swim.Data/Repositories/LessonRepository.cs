using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Swim.Data.Repositories
{
    public class LessonRepository : ILessonRepository
    {
        private readonly DataContext _context;
        public LessonRepository(DataContext context)
        {
            _context = context;
        }

        public ActionResult DeleteLesson(int id)
        {
            var less = _context.lessons.Find(l => l.LessonId == id);
            if (less == null)
                return new NotFoundResult();
            _context.lessons.Remove(less);
            return new OkResult();
        }

        public List<Lesson> GetAllLessons()
        {
            return _context.lessons;
        }

        public ActionResult<Lesson> LessonGetLessonById(int id)
        {
            var less = _context.lessons.Find(l => l.LessonId == id);
            if (less == null)
                return new NotFoundResult();
            return less;
        }

        public void PostLesson(Lesson less)
        {
            _context.lessons.Add(new Lesson { LessonId = _context.LessonCount++, LessonDescription = less.LessonDescription, LessonHour = less.LessonHour, TeacherId = less.TeacherId });
        }

        public ActionResult PutLesson(Lesson less, int id)
        {
            var lesson = _context.lessons.Find(l => l.LessonId == id);
            if (lesson == null)
                return  new NotFoundResult();
            lesson.LessonDescription = less.LessonDescription;
            lesson.LessonHour = less.LessonHour;
            lesson.TeacherId = less.TeacherId;
            return new OkResult();
        }
    }
}
