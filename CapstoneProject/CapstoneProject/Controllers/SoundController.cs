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
        private SoundContext db = new SoundContext(); //sets up a database context
        // GET api/sound
        public IEnumerable<Sound> GetSounds(string s = null, string sort = null, bool desc = false, int? limit = null, int offset = 0)
        {
            var soundList = ((IObjectContextAdapter)db).ObjectContext.CreateObjectSet<Sound>(); //gets sounds from the database context.
            IQueryable<Sound> sounds = string.IsNullOrEmpty(sort) ? soundList.OrderBy(o => o.SoundID) //puts the sounds in a list.
                : soundList.OrderBy(String.Format("it.{0} {1}", sort, desc ? "DESC" : "ASC"));
            if (!string.IsNullOrEmpty(s) && s != "undefined") //This is where the search is done
            {
                sounds = sounds.Where(t => t.Title.Contains(s) || t.Genre.Contains(s)); //search for either title or genre
            }

            if (offset > 0) //this offset is related to the paging
                sounds = sounds.Skip(offset);
            if (limit.HasValue) //this limit is related to the paging.
                sounds = sounds.Take(limit.Value);

            return sounds; //return the sounds
        }

        // GET api/sound/5
        public Sound GetSound(int id)
        {
            Sound sound = db.Sounds.Find(id);
            if (sound == null) //if the sound isn't found, throw an exception. 
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            return sound; 
        }

        //These three shells of methods were not used in the project. Though if one wanted to add or delete sounds, they would be. 
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
