using Microsoft.EntityFrameworkCore;
using ECommerceProject.Data;
using ECommerceProject.Models;
using ECommerceProject.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

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
            //if (_context.Product == null)
            //{
            //    return NotFound();
            //}
            //  return await _context.Product.ToListAsync();
            var result = await productService.GetAll();
            return Ok(result);
        }

        // GET: api/TestProducts/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product>> GetProduct(int id)
        //{
        //  if (_context.Product == null)
        //  {
        //      return NotFound();
        //  }
        //    var product = await _context.Product.FindAsync(id);

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }

        //    return product;
        //}

        // PUT: api/TestProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduct(int id, Product product)
        //{
        //    if (id != product.ProductId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(product).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/TestProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            //if (_context.Product == null)
            //{
            //    return Problem("Entity set 'ECommerceProjectContext.Product'  is null.");
            //}
            //  _context.Product.Add(product);
            //  await _context.SaveChangesAsync();

            //  return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
            var result = await productService.Add(product);
            return Ok(result);
        }

        // DELETE: api/TestProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            //if (_context.product == null)
            //{
            //    return notfound();
            //}
            //var product = await _context.product.findasync(id);
            //if (product == null)
            //{
            //    return notfound();
            //}

            //_context.product.remove(product);
            //await _context.savechangesasync();
            var result = await productService.Delete(id);
            return NoContent();
        }

        //private bool ProductExists(int id)
        //{
        //    return (_context.Product?.Any(e => e.ProductId == id)).GetValueOrDefault();
        //}
    }
}