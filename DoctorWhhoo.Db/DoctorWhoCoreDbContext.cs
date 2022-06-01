using Microsoft.EntityFrameworkCore;

namespace DoctorWhhoo.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemys { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EpisodeCompanion> Epcomp { get; set; }
        public DbSet<EpisodeEnemy> EpEnemy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Trusted_Connection=True;Database=DoctorWhoCore;");
        }



    }//class
}