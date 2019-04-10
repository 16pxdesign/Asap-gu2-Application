using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Application.Models
{
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
                optionsBuilder.UseSqlite("Data Source=db.db");
            }

        }

        public DbSet<Address> Addresses { get; set; }




    }
}
