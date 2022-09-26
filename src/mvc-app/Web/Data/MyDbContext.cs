using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Web.Models;

namespace Web.Data
{
    public class MyDbContext : IdentityDbContext
    {
        public MyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Web.Models.Cart>? Cart { get; set; }

        public DbSet<Web.Models.Order>? Order { get; set; }
    }
}
