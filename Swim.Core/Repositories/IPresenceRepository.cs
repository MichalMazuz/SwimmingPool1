using Microsoft.AspNetCore.Mvc;
using Swim.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swim.Core.Repositories
{
    public interface IPresenceRepository
    {
        List<Presence> GetAllPresence();
        ActionResult<Presence> GetPresenceById(int idT, int idL, int idS);
        void PostPresence(Presence pre);
        ActionResult PutPresence(Presence pre, int idT, int idL, int idS);
       
    }
}
