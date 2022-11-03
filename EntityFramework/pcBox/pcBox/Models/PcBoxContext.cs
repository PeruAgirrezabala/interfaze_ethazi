using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace pcBox.Models
{
    public class PcBoxContext : DbContext
    {
        public PcBoxContext() : base(nameOrConnectionString: "pcBoxContext")
        { }
        public DbSet<res_partner> res_partner { get; set; }
        public DbSet<sale_order> sale_order   { get; set; }
        public DbSet<saleorderline> SaleOrderLine { get; set; }
        public DbSet<stockvaluationlayer> StockValuationLayer { get; set; }
        public DbSet<stockmove> StockMove { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
