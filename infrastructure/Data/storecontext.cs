

using core.Entities;
using Microsoft.EntityFrameworkCore;
     

namespace infrastructure.Data 
{
    public class storecontext : DbContext
    {
        public storecontext(DbContextOptions <storecontext> options) :base(options)
        {

        }
        public DbSet <product> products {get;set;}
        
    }
}