using Microsoft.EntityFrameworkCore;
using OrderspgDB.Models;
namespace OrderspgDB.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orders>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);

            modelBuilder.Entity<Orders>().HasOne(o => o.Product).WithMany(p => p.Orders).HasForeignKey(o => o.ProductID);   
        }

    }
}
