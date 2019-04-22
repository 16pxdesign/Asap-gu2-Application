using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application.Data.Models;

namespace Application.Data.Models
{
    /*
     * 
     */
    public class DatabaseModel : DbContext
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Activities> Activities { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Player> Player { get; set; }

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
                optionsBuilder.UseSqlite(
                    @"Data Source=C:\Users\pingu\Documents\GitHub\Asap-gu2-Application\Application.Data\Data\Database.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Member
            modelBuilder.Entity<Member>()
                .HasKey(k => k.SRU);
            modelBuilder.Entity<Member>()
                .Property(m => m.SRU)
                .ValueGeneratedNever();

            modelBuilder.Entity<Member>()
                .Property(m => m.Type)
                .HasConversion<string>();


            modelBuilder.Entity<Member>()
                .HasOne(m => m.Address)
                .WithOne()
                .HasForeignKey<Member>();

            //Player
            modelBuilder.Entity<Player>()
                .HasKey(k => k.SRU);

            modelBuilder.Entity<Player>()
                .HasOne(s => s.Member)
                .WithOne(m => m.Player)
                .HasForeignKey<Player>(m => m.SRU)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Player>()
                .Property(m => m.Position)
                .HasConversion<int>();

            modelBuilder.Entity<Player>()
                .HasOne(m => m.Doctor)
                .WithOne(m => m.Player)
                .HasForeignKey<Doctor>()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Player>()
                .HasMany(m => m.HealthIssues)
                .WithOne(m => m.Player)
                .OnDelete(DeleteBehavior.Cascade);

            //Senior
            modelBuilder.Entity<Senior>()
                .HasKey(k => k.SRU);

            modelBuilder.Entity<Senior>()
                .HasOne(s => s.Player)
                .WithOne(m => m.Senior)
                .HasForeignKey<Senior>(m => m.SRU)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Senior>()
                .HasOne(s => s.Kin)
                .WithOne(m => m.Senior)
                .HasForeignKey<Kin>()
                .OnDelete(DeleteBehavior.Cascade);

            //Junior
            modelBuilder.Entity<Junior>()
                .HasKey(k => k.SRU);

            modelBuilder.Entity<Junior>()
                .HasOne(s => s.Player)
                .WithOne(m => m.Junior)
                .HasForeignKey<Junior>(m => m.SRU)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Junior>()
                .HasMany(m => m.Guardians)
                .WithOne(m => m.Junior)
                .OnDelete(DeleteBehavior.Cascade);

            //Doctor
            modelBuilder.Entity<Doctor>()
                .HasOne(m => m.Address)
                .WithOne()
                .HasForeignKey<Doctor>("AddressId")
                .OnDelete(DeleteBehavior.Cascade);

            //Kin
            modelBuilder.Entity<Kin>()
                .HasOne<Address>(m => m.Address)
                .WithOne()
                .HasForeignKey<Kin>("AddressId")
                .OnDelete(DeleteBehavior.Cascade);

            //Guradian
            modelBuilder.Entity<Guardian>()
                .HasOne<Address>(m => m.Address)
                .WithOne()
                .HasForeignKey<Guardian>("AddressId")
                .OnDelete(DeleteBehavior.Cascade);
            //Training
            modelBuilder.Entity<Training>()
                .HasMany(m => m.Activities)
                .WithOne(m => m.Training)
                .HasForeignKey(x => x.TrainingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Training>()
                .HasOne(m => m.Coach)
                .WithMany()
                .HasForeignKey(m => m.CoachSRU)
                .OnDelete(DeleteBehavior.Restrict);
        

            //Attendance
              modelBuilder.Entity<Attendance>()
                  .HasKey(c => new { c.PlayerSRU, c. TrainingId });
            modelBuilder.Entity<Attendance>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<Attendance>()
                .HasOne(m => m.Player)
                .WithMany()
                .HasForeignKey(m => m.PlayerSRU)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Attendance>()
                .HasOne(m => m.Training)
                .WithMany()
                .HasForeignKey(m => m.TrainingId)
                .OnDelete(DeleteBehavior.Restrict);

            //Profile
            modelBuilder.Entity<Profile>()
                .HasKey(c => new {c.PlayerSRU, c.SkillId});

            modelBuilder.Entity<Profile>()
                .HasOne(m => m.Player)
                .WithOne()
                .HasForeignKey<Profile>(m => m.PlayerSRU)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Profile>()
                .HasOne(m => m.Skill)
                .WithOne()
                .HasForeignKey<Profile>(m => m.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            //Game
            modelBuilder.Entity<Game>()
                .HasMany(m => m.Scores)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .Property(m => m.Location)
                .HasConversion<int>();

            modelBuilder.Entity<Game>()
                .Property(m => m.Result)
                .HasConversion<int>();

            //Scores
            modelBuilder.Entity<Scores>()
                .Property(m => m.Half)
                .HasConversion<int>();

            modelBuilder.Entity<Scores>()
                .Property(m => m.Team)
                .HasConversion<int>();

            base.OnModelCreating(modelBuilder);
        }
    }
}