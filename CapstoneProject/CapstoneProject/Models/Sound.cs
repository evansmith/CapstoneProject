using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Sound
    {
        //This is the sound database model I'm currently using. 
        public int SoundID { get; set; }
        public string Title {get; set; }
        public string Location {get; set;}
        public string Time { get; set; }
        public string Genre { get; set; }

    }
}