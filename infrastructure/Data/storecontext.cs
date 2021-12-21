

using core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace infrastructure.Data 
{
    public class storecontext : DbContext
    {
        public storecontext(DbContextOptions <storecontext> options) :base(options)
        {

        }
        public DbSet <product> products {get;set;}
        public DbSet<ProducBrand> producBrands  { get; set; }
        public DbSet<prodctType> prodctTypes { get; set; }

       protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
    
}