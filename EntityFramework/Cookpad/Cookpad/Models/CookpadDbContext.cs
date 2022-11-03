using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookpad.Models
{
    public class CookpadDbContext : DbContext
    {
        public CookpadDbContext() : base(nameOrConnectionString: "CookpadDbContext")
        { }
        public DbSet<Botoa> Botoa { get; set; }
        public DbSet<Erabiltzailea> Erabiltzailea { get; set; }
        public DbSet<Errezeta> Errezeta { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

