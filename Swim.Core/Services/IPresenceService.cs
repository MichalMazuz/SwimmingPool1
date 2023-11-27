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
    public interface IPresenceService
    {
        List<Presence> GetAllPresence();
        ActionResult<Presence> GetPresenceById(int idT, int idL, int idS);
        void PutPresence(Presence pre, int idT, int idL, int idS);
        void PostPresence(Presence pre);
    }
}
