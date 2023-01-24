using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MilkWebShopAPI.Data;
using MilkWebShopAPI.Models;

namespace MilkWebShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MilkProductsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MilkProductsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/MilkProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MilkProduct>>> GetMilkProducts()
        {
          if (_context.MilkProducts == null)
          {
              return NotFound();
          }
            return await _context.MilkProducts.ToListAsync();
        }

        // GET: api/MilkProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MilkProduct>> GetMilkProduct(Guid id)
        {
          if (_context.MilkProducts == null)
          {
              return NotFound();
          }
            var milkProduct = await _context.MilkProducts.FindAsync(id);

            if (milkProduct == null)
            {
                return NotFound();
            }

            return milkProduct;
        }

        // PUT: api/MilkProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMilkProduct(Guid id, MilkProduct milkProduct)
        {
            if (id != milkProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(milkProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MilkProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MilkProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MilkProduct>> PostMilkProduct(MilkProduct milkProduct)
        {
          if (_context.MilkProducts == null)
          {
              return Problem("Entity set 'AppDbContext.MilkProducts'  is null.");
          }
            _context.MilkProducts.Add(milkProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMilkProduct", new { id = milkProduct.Id }, milkProduct);
        }

        // DELETE: api/MilkProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMilkProduct(Guid id)
        {
            if (_context.MilkProducts == null)
            {
                return NotFound();
            }
            var milkProduct = await _context.MilkProducts.FindAsync(id);
            if (milkProduct == null)
            {
                return NotFound();
            }

            _context.MilkProducts.Remove(milkProduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MilkProductExists(Guid id)
        {
            return (_context.MilkProducts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
