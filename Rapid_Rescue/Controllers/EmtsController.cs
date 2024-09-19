using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rapid_Rescue.Model;

namespace Rapid_Rescue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmtsController : ControllerBase
    {
        private readonly Rapid_RescueDbContext _context;

        public EmtsController(Rapid_RescueDbContext context)
        {
            _context = context;
        }

        // GET: api/Emts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emt>>> GetEmts()
        {
            return await _context.Emts.ToListAsync();
        }

        // GET: api/Emts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emt>> GetEmt(int id)
        {
            var emt = await _context.Emts.FindAsync(id);

            if (emt == null)
            {
                return NotFound();
            }

            return emt;
        }

        // PUT: api/Emts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmt(int id, Emt emt)
        {
            if (id != emt.emdId)
            {
                return BadRequest();
            }

            _context.Entry(emt).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmtExists(id))
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

        // POST: api/Emts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Emt>> PostEmt(Emt emt)
        {
            _context.Emts.Add(emt);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmt", new { id = emt.emdId }, emt);
        }

        // DELETE: api/Emts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmt(int id)
        {
            var emt = await _context.Emts.FindAsync(id);
            if (emt == null)
            {
                return NotFound();
            }

            _context.Emts.Remove(emt);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmtExists(int id)
        {
            return _context.Emts.Any(e => e.emdId == id);
        }
    }
}
