using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetProvei.Data;
using PetProvei.Models;

namespace PetProvei.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasProdutosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public VendasProdutosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/VendasProdutos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VendaProduto>>> GetVendaProduto()
        {
            return await _context.VendaProduto.ToListAsync();
        }

        // GET: api/VendasProdutos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VendaProduto>> GetVendaProduto(Guid id)
        {
            var vendaProduto = await _context.VendaProduto.FindAsync(id);

            if (vendaProduto == null)
            {
                return NotFound();
            }

            return vendaProduto;
        }

        // PUT: api/VendasProdutos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendaProduto(Guid id, VendaProduto vendaProduto)
        {
            if (id != vendaProduto.VendaId)
            {
                return BadRequest();
            }

            _context.Entry(vendaProduto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendaProdutoExists(id))
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

        // POST: api/VendasProdutos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VendaProduto>> PostVendaProduto(VendaProduto vendaProduto)
        {
            _context.VendaProduto.Add(vendaProduto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VendaProdutoExists(vendaProduto.VendaId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetVendaProduto", new { id = vendaProduto.VendaId }, vendaProduto);
        }

        // DELETE: api/VendasProdutos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendaProduto(Guid id)
        {
            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            _context.VendaProduto.Remove(vendaProduto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VendaProdutoExists(Guid id)
        {
            return _context.VendaProduto.Any(e => e.VendaId == id);
        }
    }
}
