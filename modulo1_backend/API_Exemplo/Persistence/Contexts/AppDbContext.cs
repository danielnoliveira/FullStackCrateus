using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using API_Exemplo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Exemplo.Persistence
{
  public class AppDbContext : DbContext {

    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options){

    }

    protected override void OnModelCreating(ModelBuilder builder){
      
      base.OnModelCreating(builder);

      var ECategory = builder.Entity<Category>();
      ECategory.ToTable("Categories");
      ECategory.HasKey(p => p.Id);
      ECategory.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
      ECategory.Property(p => p.Name).IsRequired().HasMaxLength(30);
      ECategory.HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

      ECategory.HasData(
        new Category {Id = 100, Name = "Fruits and Vegetables"},
        new Category {Id = 101, Name = "Dairy"}
      );

      var EProduct = builder.Entity<Product>();
      EProduct.ToTable("Products");
      EProduct.HasKey(p => p.Id);
      EProduct.Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
      EProduct.Property(p => p.Name).IsRequired().HasMaxLength(50);
      EProduct.Property(p => p.QuantityInPackage).IsRequired();
      EProduct.Property(p => p.UnitOfMeasurement).IsRequired();
      
    }
  } 
}