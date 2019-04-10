using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Models
{
    /*
     * 
     */
    public class DatabaseModel : DbContext
    {
        public DatabaseModel() : base()
        {
        }

        public DatabaseModel(DbContextOptions<DatabaseModel> options)
            : base(options)
        {

        }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies();
                optionsBuilder.UseSqlite("Data Source=file:Data/db.db");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasKey(c => new { c.PlayerId, c. SkillId });
            modelBuilder.Entity<Attendance>()
                .HasKey(c => new { c.PlayerId, c. TrainingId });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<HealthIssue> HealthIssues { get; set; }
        public DbSet<Kin> Kins { get; set; }
        public DbSet<PlayerPosition> PlayerPositions { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Senior> Seniors { get; set; }
        public DbSet<Junior> Juniors { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<GameScores> GameScores { get; set; }
        public DbSet<GameHalf> GameHalves { get; set; }
        public DbSet<Game> Games { get; set; }




    }
}
