using core.Entities;
using core.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Data
{
    public class ProductRepository : IproductRepository
    {
        private readonly storecontext _context;

        public ProductRepository(storecontext context)
        {
            _context = context;

        }

        public async   Task<product> GetProductByIdAsync(int id)
        {
            return await _context.products
                .Include(p => p.ProdctType)
                .Include(p => p.producBrand)
                .FirstOrDefaultAsync(p=>p.Id==id);
        }

        public async Task<IReadOnlyList<product>> GetproductsAsunc()

        {
            
            return await _context.products
               .Include(p=>p.ProdctType) 
               .Include(p=>p.producBrand)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<ProducBrand>> ProductBrandsAsunc()
        {
            return await _context.producBrands.ToListAsync();        }

        public async Task<IReadOnlyList<prodctType>> ProductTypesAsunc()
        {
            return await _context.prodctTypes.ToListAsync();
        }
    }
}
