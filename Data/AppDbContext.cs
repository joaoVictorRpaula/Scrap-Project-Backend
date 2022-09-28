using Microsoft.EntityFrameworkCore;
using SCRAP_API.Models;

namespace SCRAP_API.Data
{
    public class AppDbContext : DbContext
    {
        internal object apontamentos;

        public AppDbContext(DbContextOptions opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Users>()
                .HasOne(c => c.CentroCusto)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.CostCenterId);

            builder.Entity<Partnumbers>()
                .HasOne(p => p.Produto)
                .WithMany(p2 => p2.Partnumbers)
                .HasForeignKey(p => p.ProdutoId);

            builder.Entity<Machines>()
                .HasOne(o => o.Operation)
                .WithMany(m => m.Machines)
                .HasForeignKey(o => o.OperationId);

        }

        public DbSet<Partnumbers> Partnumbers { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<CostCenter> CostCenter { get; set; }
        public DbSet<Operations> Operations { get; set; }
        public DbSet<Machines> Machines { get; set; }
        public DbSet<Defeitos> Defeitos { get; set; }
        public DbSet<Apontamentos> Apontamentos { get; set; }
    }
}
