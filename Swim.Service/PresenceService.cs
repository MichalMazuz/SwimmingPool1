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
    public class PresenceService : IPresenceService
    {
        private readonly IPresenceRepository _presenceRepository;
        public PresenceService(IPresenceRepository presenceRepository)
        {
            _presenceRepository = presenceRepository;
        }

        public List<Presence> GetAllPresence()
        {
          return _presenceRepository.GetAllPresence();
        }

        public ActionResult<Presence> GetPresenceById(int idT, int idL, int idS)
        {
           return _presenceRepository.GetPresenceById(idT, idL, idS);
        }

        public void PostPresence(Presence pre)
        {
           _presenceRepository.PostPresence(pre);
        }

        public void PutPresence(Presence pre, int idT, int idL, int idS)
        {
           _presenceRepository.PutPresence(pre, idT, idL, idS);
        }

       
    }
}
