using core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.interfaces
{
   public interface IproductRepository
    {
        Task<product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<product>> GetproductsAsunc();
        Task<IReadOnlyList<prodctType>>ProductTypesAsunc();
        Task<IReadOnlyList<ProducBrand>> ProductBrandsAsunc();
    }
}


