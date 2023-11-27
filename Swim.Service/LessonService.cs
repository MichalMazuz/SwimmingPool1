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
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;
        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public void DeleteLesson(int id)
        {
            _lessonRepository.DeleteLesson(id);
        }

        public List<Lesson> GetAllLessons()
        {
           return _lessonRepository.GetAllLessons();
        }

        public ActionResult<Lesson> LessonGetLessonById(int id)
        {
            return _lessonRepository.LessonGetLessonById(id);
        }

        public void PostLesson(Lesson less)
        {
            _lessonRepository.PostLesson(less);
        }

        public void PutLesson(Lesson less, int id)
        {
            _lessonRepository.PutLesson(less, id);
        }

        
    }
}
