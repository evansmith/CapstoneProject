using CapstoneProject.DAL;
using CapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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
        public IEnumerable<Sound> GetSounds(string s = null, string sort = null, bool desc = false, int? limit = null, int offset = 0)
        {
            var soundList = ((IObjectContextAdapter)db).ObjectContext.CreateObjectSet<Sound>();
            IQueryable<Sound> sounds = string.IsNullOrEmpty(sort) ? soundList.OrderBy(o => o.SoundID)
                : soundList.OrderBy(String.Format("it.{0} {1}", sort, desc ? "DESC" : "ASC"));
            if (!string.IsNullOrEmpty(s) && s != "undefined")
            {
                sounds = sounds.Where(t => t.Title.Contains(s) || t.Genre.Contains(s));
            }

            if (offset > 0)
                sounds = sounds.Skip(offset);
            if (limit.HasValue)
                sounds = sounds.Take(limit.Value);

            return sounds;
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
