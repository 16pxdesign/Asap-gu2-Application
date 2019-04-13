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
        public DbSet<Member> Members { get; set; }
        public DbSet<Senior> Seniors { get; set; }
        
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
            //MemberType
           
            //Member
            modelBuilder.Entity<Member>()
                .HasKey(k => k.SRU);
            modelBuilder.Entity<Member>()
                .Property(m => m.SRU)
                .ValueGeneratedNever();

            modelBuilder.Entity<Member>()
                .Property(m => m.Type)
                .HasConversion<string>();
            
           //Player
           modelBuilder.Entity<Player>()
               .HasKey(k => k.SRU);
            
           modelBuilder.Entity<Player>()
               .HasOne<Member>(s => s.Member)
               .WithOne(m => m.Player)
               .HasForeignKey<Player>(m => m.SRU);
           modelBuilder.Entity<Player>()
               .Property(m => m.Position)
               .HasConversion<int>();
                
            //Senior
            modelBuilder.Entity<Senior>()
                .HasKey(k => k.SRU);
            
            modelBuilder.Entity<Senior>()
                .HasOne<Player>(s => s.Player)
                .WithOne(m => m.Senior)
                .HasForeignKey<Senior>(m => m.SRU);
            
            //Junior
            modelBuilder.Entity<Junior>()
                .HasKey(k => k.SRU);
            
            modelBuilder.Entity<Junior>()
                .HasOne<Player>(s => s.Player)
                .WithOne(m => m.Junior)
                .HasForeignKey<Junior>(m => m.SRU);
            
            /*
            modelBuilder.Entity<Profile>()
                .HasKey(c => new { c.PlayerId, c. SkillId });
            modelBuilder.Entity<Attendance>()
                .HasKey(c => new { c.PlayerId, c. TrainingId });
            
            */

            base.OnModelCreating(modelBuilder);
        }




    }
}
