using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using Swim.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Data.Repositories
{
    public class PresenceRepository : IPresenceRepository
    {
        private readonly DataContext _context;

        public List<Presence> GetAllPresence()
        {
            return _context.presences;
        }

        public ActionResult<Presence> GetPresenceById(int idT, int idL, int idS)
        {
            var pre = _context.presences.Find(p => p.TeacherId == idT && p.StudentId == idS && p.LessonId == idL);
            if (pre == null)
                return new NotFoundResult();
            return pre;
        }

        public void PostPresence(Presence p)
        {
            _context.presences.Add(new Presence { LessonId = p.LessonId, TeacherId = p.TeacherId, StudentId = p.StudentId, IsPresent = p.IsPresent });
        }

        public ActionResult PutPresence(Presence p, int idT, int idL, int idS)
        {
            var pre = _context.presences.Find(p => p.TeacherId == idT && p.StudentId == idS && p.LessonId == idL);
            if (pre == null)
                return new NotFoundResult();
            pre.IsPresent = p.IsPresent;
            return new OkResult();
        }
    }
}
