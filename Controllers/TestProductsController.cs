using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceProject.Data;
using ECommerceProject.Models;
using ECommerceProject.Interfaces.IServices;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public TestProductsController(IProductService _productService)
        {
            productService = _productService;
        }

        // GET: api/TestProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var result = await productService.GetAll();
            return Ok(result);
        }

        // GET: api/TestProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            return await productService.GetById(id);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            var result = await productService.Add(product);
            return Ok(result);
        }

        // DELETE: api/TestProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var result = await productService.Delete(id); 
            return NoContent();
        }
    }
}
