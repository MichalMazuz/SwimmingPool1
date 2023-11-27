using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swim.Core.Entities;
using Swim.Core.Services;
using Swim.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwimmingPool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PresenceController : ControllerBase
    {
        private readonly IPresenceService _presenceService;
        public PresenceController(IPresenceService presenceService)
        {
            _presenceService = presenceService;
        }
        // GET: api/<LessonController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_presenceService.GetAllPresence());
        }

        // GET api/<LessonController>/5
        [HttpGet("{id}")]
        public ActionResult<Presence> Get(int idT, int idL, int idS)
        {
            var presence = _presenceService.GetPresenceById(idT,idL,idS);
            if (presence == null)
                return  NotFound();
            return presence;
        }

        // POST api/<LessonController>
        [HttpPost]
        public void Post([FromBody] Presence presence)
        {
            _presenceService.PostPresence(presence);
        }

        // PUT api/<LessonController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Presence presence)
        {
            _presenceService.PostPresence(presence);
            return Ok();
        }

       
    }
}
