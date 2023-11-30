using EcommerceAPI.Entitys;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Database
{
    public class EcommContext : DbContext
    {
        public DbSet<User>? Users { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = MSI\\SQLEXPRESS; Initial Catalog= Ecomm119;User Id=kotesh;Password=Kolli@123;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
