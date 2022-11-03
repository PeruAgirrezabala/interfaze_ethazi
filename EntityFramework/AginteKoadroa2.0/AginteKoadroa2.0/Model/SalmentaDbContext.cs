using AginteKoadroa_PG.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;



namespace AginteKoadroa_PG.Models
{
    public class SalmentaDbContext : DbContext
    {
        public SalmentaDbContext() : base(nameOrConnectionString: "SalmentaDbContext")
        { }
        public DbSet<Bezeroa> Bezeroa { get; set; }
        public DbSet<Salmenta> Salmenta { get; set; }
        public DbSet<Saltzailea> Saltzailea { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
