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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
            .HasData(
             new Author
             {   AuthorId = 1,
                 AuthorName = "hazem" },
             new Author
             {   AuthorId = 2,
                 AuthorName = "ahmad"},
             new Author
             {   AuthorId = 3,
                 AuthorName = "montaser" },
             new Author
             {   AuthorId = 4,
                 AuthorName = "mohammad" },
             new Author
             {    AuthorId = 5,
                 AuthorName = "omar" } ) ;

            modelBuilder.Entity<Doctor>()
           .HasData(
                new Doctor
                {   DoctorId=1,
                    DoctorNumber=0597316748,
                    DoctorName = "Hamza",
                    BirthDate = new DateTime(1998,03,12),
                    FirstEpisodeDate= new DateTime(2011,03,12),
                    LastEpisodeDate= new DateTime(2019,03,12) },
                 new Doctor
                 {   DoctorId = 2,
                     DoctorNumber = 0597316748,
                     DoctorName = "Adel",
                     BirthDate = new DateTime(1998, 03, 12),
                     FirstEpisodeDate = new DateTime(2012, 04, 12),
                     LastEpisodeDate = new DateTime(2019, 03, 12)},
                  new Doctor
                  {   DoctorId = 3,
                      DoctorNumber = 0597316748,
                      DoctorName = "Ibrahem",
                      BirthDate = new DateTime(1996, 03, 12),
                      FirstEpisodeDate = new DateTime(2017, 03, 12),
                      LastEpisodeDate = new DateTime(2019, 03, 12)},
                   new Doctor
                   {   DoctorId = 4,
                       DoctorNumber = 0597316748,
                       DoctorName = "Omar",
                       BirthDate = new DateTime(1995, 03, 12),
                       FirstEpisodeDate = new DateTime(2011, 03, 12),
                       LastEpisodeDate = new DateTime(2019, 03, 12) },
                    new Doctor
                    {   DoctorId = 5,
                        DoctorNumber = 0597316748,
                        DoctorName = "Saef",
                        BirthDate = new DateTime(1994, 03, 12),
                        FirstEpisodeDate = new DateTime(2021, 03, 12),
                        LastEpisodeDate = new DateTime(2019, 03, 12) });

            modelBuilder.Entity<Companion>()
          .HasData(
                new Companion
                {   CompanionId = 1,
                    CompanionName= "Atheer",
                    WhoPlayed=true },
                 new Companion
                 {  CompanionId = 2,
                    CompanionName = "Aseel",
                    WhoPlayed = false },
              new Companion
              {     CompanionId = 3,
                    CompanionName = "Hadeel",
                    WhoPlayed = true  },
             new Companion 
             {      CompanionId = 4,
                    CompanionName = "Majed",
                    WhoPlayed = false },
              new Companion
              {     CompanionId = 5,
                    CompanionName = "Shahd",
                    WhoPlayed = true } );

            modelBuilder.Entity<Enemy>()
          .HasData(
                new Enemy
                {   EnemyId = 1,
                    EnemyName= "Masa",
                    Description= "strong working hard"  },
                 new Enemy
                 {   EnemyId = 2,
                     EnemyName = "Maya",
                     Description = "strong working hard"  },
                  new Enemy
                  {   EnemyId = 3,
                      EnemyName = "Menna",
                      Description = "strong working hard"  },
                   new Enemy
                   {   EnemyId = 4,
                       EnemyName = "Marah",
                       Description = "strong working hard"   },
                    new Enemy
                    {   EnemyId = 5,
                        EnemyName = "Lana",
                        Description = "strong working hard" } );

            modelBuilder.Entity<Episode>()
          .HasData(
                new Episode
                {   EpisodeId = 1,
                    SeriesNumber = 123,
                    EpisodeNumber=10,
                    EpisodeType= "action",
                    Title= "go",
                    EpisodeDate= new DateTime(2011,03,12),
                    AuthorId=4,
                    DoctorId=1,
                    Notes= " long episode" },
                new Episode
                {   EpisodeId = 2,
                    SeriesNumber = 478,
                    EpisodeNumber = 8,
                    EpisodeType = "horror",
                    Title = "be carefull",
                    EpisodeDate = new DateTime(2012, 04, 12),
                    AuthorId = 4,
                    DoctorId = 2,
                    Notes = " long episode" },
                new Episode
                {   EpisodeId = 3,
                    SeriesNumber = 159,
                    EpisodeNumber = 5,
                    EpisodeType = "action",
                    Title = "sing",
                    EpisodeDate = new DateTime(2021, 03, 12),
                    AuthorId = 3,
                    DoctorId = 1,
                    Notes = " long episode" },
                new Episode
                {   EpisodeId = 4,
                    SeriesNumber = 867,
                    EpisodeNumber = 4,
                    EpisodeType = "horror",
                    Title = "jump",
                    EpisodeDate = new DateTime(2019, 03, 12),
                    AuthorId = 2,
                    DoctorId = 3,
                    Notes = " long episode" },
                new Episode
                {   EpisodeId = 5,
                    SeriesNumber = 989,
                    EpisodeNumber = 1,
                    EpisodeType = "horror",
                    Title = "listen",
                    EpisodeDate = new DateTime(2017, 03, 12),
                    AuthorId = 5,
                    DoctorId = 4,
                    Notes = " long episode" }) ;

            modelBuilder.Entity<EpisodeEnemy>()
          .HasData(
                new EpisodeEnemy
                {   EpisodeEnemyId = 1,
                    EpisodeId=1,
                    EnemyId=1  },
                 new EpisodeEnemy
                 {   EpisodeEnemyId = 2,
                     EpisodeId = 2,
                     EnemyId = 2 },
                  new EpisodeEnemy
                  {   EpisodeEnemyId = 3,
                      EpisodeId = 3,
                      EnemyId = 5 },
                   new EpisodeEnemy
                   {   EpisodeEnemyId = 4,
                       EpisodeId = 1,
                       EnemyId = 1 },
                    new EpisodeEnemy
                    {   EpisodeEnemyId = 5,
                        EpisodeId = 4,
                        EnemyId = 4 });

            modelBuilder.Entity<EpisodeCompanion>()
          .HasData(
                new EpisodeCompanion
                {   EpisodeCompanionId = 1,
                    EpisodeId=5,
                    CompanionId=4 },
                 new EpisodeCompanion
                 {   EpisodeCompanionId = 2,
                     EpisodeId = 4,
                     CompanionId = 4 },
                  new EpisodeCompanion
                  {   EpisodeCompanionId = 3,
                      EpisodeId = 2,
                      CompanionId = 5 },
                   new EpisodeCompanion
                   {   EpisodeCompanionId = 4,
                       EpisodeId = 1,
                       CompanionId = 1 },
                    new EpisodeCompanion
                    {   EpisodeCompanionId = 5,
                        EpisodeId = 3,
                        CompanionId = 5 }  );
        }//onmodelcreating


    }//class
}