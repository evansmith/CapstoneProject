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
            var sounds = new List<Sound> {
               new Sound { Title = "24 Beep", Genre = "Television", Location = "http://localhost:50990/Sounds/ctu-24-ringtone.mp3", Time = "00:03"},
               new Sound {Title = "Hi-Hat", Genre="Drums", Location = "http://localhost:50990/Sounds/45666_pjcohen_Zildjian_A_Custom_Hi_Hat_Cymbals_Loose_Hit.WAV", Time = "00:01"},
               new Sound {Title = "1 Continuous Thunder", Genre = "Nature", Location = "http://localhost:50990/Sounds/1 Continuous Thunder.mp3", Time="00:55"},
               new Sound {Title = "2 Champagne Cork Pops", Genre="Restaurant", Location = "http://localhost:50990/Sounds/2 Champagne Cork Pops.mp3", Time = "00:15"}
           };

            for(int i = 0; i < sounds.Count; i++){
                sounds[i].SoundID = i;
            }
            sounds.ForEach(s => context.Sounds.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();
        }
    }
}
