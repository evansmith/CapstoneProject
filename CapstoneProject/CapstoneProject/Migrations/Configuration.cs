namespace CapstoneProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CapstoneProject.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<CapstoneProject.DAL.SoundContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CapstoneProject.DAL.SoundContext context)
        {
            //This seed method populates initial data into the database. 
            var sounds = new List<Sound> {
               new Sound { Title = "24 Beep", Genre = "Television", Location = "http://localhost:50990/Sounds/ctu-24-ringtone.mp3", Time = "00:03"},
               new Sound {Title = "Hi-Hat", Genre="Drums", Location = "http://localhost:50990/Sounds/45666_pjcohen_Zildjian_A_Custom_Hi_Hat_Cymbals_Loose_Hit.WAV", Time = "00:01"},
               new Sound {Title = "1 Continuous Thunder", Genre = "Nature", Location = "http://localhost:50990/Sounds/1 Continuous Thunder.mp3", Time="00:55"},
               new Sound {Title = "2 Champagne Cork Pops", Genre="Restaurant", Location = "http://localhost:50990/Sounds/2 Champagne Cork Pops.mp3", Time = "00:15"},
               new Sound {Title = "3 Horse Whinnies & Snorts", Genre="Animals", Location = "http://localhost:50990/Sounds/3 Horse Whinnies & Snorts.mp3", Time = "00:25"},
               new Sound {Title = "4 Wild Dogs and Wolves", Genre="Animals", Location = "http://localhost:50990/Sounds/4 Wild Dogs And Wolves.mp3", Time = "00:25"},
               new Sound {Title = "5 Crowd in a Panic", Genre="People", Location = "http://localhost:50990/Sounds/5 Crowd In A Panic.mp3", Time = "01:33"}, 
               new Sound {Title = "6 Heavy Breathing & Heartbeat", Genre="People", Location = "http://localhost:50990/Sounds/6 Heavy Breathing & Heartbeat.mp3", Time = "00:28"},
               new Sound {Title = "7 Angry Mob (Small)", Genre="People", Location = "http://localhost:50990/Sounds/7 Angry Mob (Small).mp3", Time = "00:24"}, 
               new Sound {Title = "8 Old Fashioned Toilet Flush", Genre="Home", Location = "http://localhost:50990/Sounds/8 Old Fashioned Toilet Flush.mp3", Time = "00:31"},
               new Sound {Title = "9 Brushing Teeth Sequence", Genre="People", Location = "http://localhost:50990/Sounds/9 Brushing Teeth Sequence.mp3", Time = "01:15"}, 
               new Sound {Title = "10 Shower Sequence", Genre="People", Location = "http://localhost:50990/Sounds/10 Shower Sequence.mp3", Time = "01:16"}, 
               new Sound {Title = "11 Electronic Flourish Magic", Genre = "Random", Location = "http://localhost:50990/Sounds/11 Electronic Flourish Magic.mp3", Time = "00:17"},
               new Sound {Title = "12 Anti-Aircraft Fire", Genre="Weapons", Location = "http://localhost:50990/Sounds/12 Anti-Aircraft Fire.mp3", Time = "00:29" }, 
               new Sound {Title = "13 Plane Crash", Genre = "Automobiles", Location ="http://localhost:50990/Sounds/13 Plane Crash (Stereofect).mp3", Time = "00:29" },
               new Sound {Title = "14 Fire Engine Pass", Genre="Automobiles", Location = "http://localhost:50990/Sounds/14 Fire Engine Pass.mp3", Time = "00:24" }, 
               new Sound {Title = "15 Two Children Laughing", Genre = "People", Location = "http://localhost:50990/Sounds/15 Two Children Laughing.mp3", Time = "00:31" }, 
               new Sound {Title = "16 Baby Crying", Genre = "People", Location = "http://localhost:50990/Sounds/16 Baby Crying.mp3", Time = "00:40" }, 
               new Sound {Title = "17 Baby Laughing", Genre = "People", Location = "http://localhost:50990/Sounds/17 Baby Laughing.mp3", Time = "00:34" }, 
               new Sound {Title = "18 Carnival Midway", Genre = "Events", Location = "http://localhost:50990/Sounds/18 Carnival Midway.mp3", Time = "01:27" }, 
               new Sound {Title = "19 Shooting Game - Midway", Genre = "Events", Location = "http://localhost:50990/Sounds/19 Shooting Game - Midway.mp3", Time = "00:28" }, 
               new Sound {Title = "20 Fireworks - With Crowd", Genre = "Events", Location = "http://localhost:50990/Sounds/20 Fireworks - With Crowd.mp3", Time = "01:28" }, 
               new Sound {Title = "21 Firecrackers", Genre = "Events", Location = "http://localhost:50990/Sounds/21 Firecrackers.mp3", Time = "00:46"}, 
               new Sound {Title = "22 707 Jet Take Off", Genre = "Automobiles", Location = "http://localhost:50990/Sounds/22 707 Jet Take Off.mp3", Time = "00:41" }, 
               new Sound {Title = "23 707 Jet Land", Genre="Automobiles", Location = "http://localhost:50990/Sounds/23 707 Jet Land.mp3", Time = "00:48" }, 
               new Sound {Title = "24 Jet Fly-By", Genre = "Automobiles", Location ="http://localhost:50990/Sounds/24 Jet Fly-By.mp3", Time = "00:15"},
               new Sound {Title = "25 Clock Ticking", Genre = "Home", Location = "http://localhost:50990/Sounds/25 Clock Ticking.mp3", Time = "00:28"}, 
               new Sound {Title = "26 Slot Machine, Coins Drop", Genre="Casino", Location = "http://localhost:50990/Sounds/26 Slot Machine, Coins Drop.mp3", Time = "00:28" }, 
               new Sound {Title = "27 Cuckoo Clock", Genre = "Home", Location = "http://localhost:50990/Sounds/27 Cuckoo Clock.mp3", Time = "00:39" },
               new Sound {Title = "28 Cannon Shots", Genre = "Weapons", Location = "http://localhost:50990/Sounds/28 Cannon Shots.mp3", Time = "00:16" }, 
               new Sound {Title =  "29 Artillery Bursts", Genre = "Weapons", Location = "http://localhost:50990/Sounds/29 Artillery Bursts (3).mp3", Time = "00:16" }, 
               new Sound {Title = "30 Rifle Shots", Genre = "Weapons", Location = "http://localhost:50990/Sounds/30 Rifle Shots.mp3", Time = "00:23" }
           };
            //this little loop auto assigns an id to each sound
            for(int i = 0; i < sounds.Count; i++){
                sounds[i].SoundID = i;
            }
            sounds.ForEach(s => context.Sounds.AddOrUpdate(p => p.Title, s));
            context.SaveChanges(); //need to save it!
        }
    }
}
