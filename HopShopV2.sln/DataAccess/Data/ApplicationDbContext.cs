using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>().Property(x => x.Name).HasMaxLength(60).IsRequired();
            builder.Entity<Product>().Property(x => x.Description).HasMaxLength(250).IsRequired();
            builder.Entity<Product>().Property(x => x.ABV).IsRequired();
            builder.Entity<Product>().Property(x => x.Price).HasPrecision(5, 2).IsRequired();
            builder.Entity<Product>().Property(x => x.Country).HasMaxLength(25).IsRequired();
            builder.Entity<Product>().Property(x => x.Size).HasMaxLength(10).IsRequired();

            builder.Entity<Tag>().Property(x => x.Name).HasMaxLength(30);

        }
    }
}
