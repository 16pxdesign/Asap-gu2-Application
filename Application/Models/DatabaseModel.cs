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
                optionsBuilder.UseSqlite("Data Source=file:Data/db.db");
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
               .HasForeignKey<Player>(m => m.SRU);
           
           modelBuilder.Entity<Player>()
               .Property(m => m.Position)
               .HasConversion<int>();

           modelBuilder.Entity<Player>()
               .HasOne(m => m.Doctor)
               .WithOne(m=>m.Player)
               .HasForeignKey<Player>();
           
            //Senior
            modelBuilder.Entity<Senior>()
                .HasKey(k => k.SRU);
            
            modelBuilder.Entity<Senior>()
                .HasOne(s => s.Player)
                .WithOne(m => m.Senior)
                .HasForeignKey<Senior>(m => m.SRU);

            modelBuilder.Entity<Senior>()
                .HasOne(s => s.Kin)
                .WithOne(m => m.Senior)
                .HasForeignKey<Senior>();
            
            //Junior
            modelBuilder.Entity<Junior>()
                .HasKey(k => k.SRU);
            
            modelBuilder.Entity<Junior>()
                .HasOne(s => s.Player)
                .WithOne(m => m.Junior)
                .HasForeignKey<Junior>(m => m.SRU);

            modelBuilder.Entity<Junior>()
                .HasMany(m => m.Guardians)
                .WithOne(m => m.Junior)
                .OnDelete(DeleteBehavior.Restrict);
            //Doctor
            modelBuilder.Entity<Doctor>()
                .HasOne(m => m.Address)
                .WithOne()
                .HasForeignKey<Doctor>();
          
            
            
            
            /*
            //Kin
            modelBuilder.Entity<Kin>()
                .HasOne<Address>(m => m.Address)
                .WithOne()
                .HasForeignKey<Kin>(m=>m.AddressId);
            */
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
