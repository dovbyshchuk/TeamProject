using Data;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class MainDbContext : DbContext
{
    public MainDbContext(DbContextOptions<MainDbContext> options):base(options)
    {
        
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<StorageItem> StorageItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().ToTable("Products");
        modelBuilder.Entity<Customer>().ToTable("Customers");
        modelBuilder.Entity<StorageItem>().ToTable("StorageItems");
    }
}