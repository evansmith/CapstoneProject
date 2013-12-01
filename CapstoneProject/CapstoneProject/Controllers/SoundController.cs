using CapstoneProject.DAL;
using CapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CapstoneProject.Controllers
{
    public class SoundController : ApiController
    {
        private SoundContext db = new SoundContext();
        // GET api/sound
        public IEnumerable<Sound> GetSounds()
        {
            return db.Sounds.AsEnumerable();
        }

        // GET api/sound/5
        public Sound GetSound(int id)
        {
            Sound sound = db.Sounds.Find(id);
            if (sound == null)
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            return sound; 
        }

        // POST api/sound
        public void Post([FromBody]string value)
        {
        }

        // PUT api/sound/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/sound/5
        public void Delete(int id)
        {
        }
    }
}
