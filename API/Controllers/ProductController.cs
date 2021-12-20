using infrastructure.Data;
using core.Entities;
using Microsoft.AspNetCore.Mvc;                                                                                                                                                                             
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductController : ControllerBase
    {
        private readonly storecontext _Context;

        public ProductController(storecontext context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<product>>> getproducts()
        {
            var products = await _Context.products.ToListAsync();
            return Ok(products);
        }
        [HttpGet("{id}")] 
        public async Task < ActionResult<product>> getproduct(int id)
        {
            return await _Context.products.FindAsync(id);
        }
        
    }
}