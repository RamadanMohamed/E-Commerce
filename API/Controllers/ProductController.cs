using infrastructure.Data;
using core.Entities;
using Microsoft.AspNetCore.Mvc;                                                                                                                                                                             
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.interfaces;

namespace API.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private IproductRepository _repo;

        public ProductController(IproductRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<product>>> getproducts()
        {
            var products = await _repo.GetproductsAsunc();
            return Ok(products);
        }
        [HttpGet("{id}")] 
        public async Task < ActionResult<product>> getproduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
        }
        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProducBrand>>> GetProductBrands()
        {
            return Ok(await _repo.ProductBrandsAsunc());
        }
        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<prodctType>>> GetProductTypes()
        {
            return Ok(await _repo.ProductTypesAsunc());
        }

    }
}