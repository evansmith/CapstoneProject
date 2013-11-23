using CapstoneProject.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace CapstoneProject.DAL 
{
    public class SoundContext : DbContext
    {
        public DbSet<Sound> Sounds { get; set; } 
    }
}