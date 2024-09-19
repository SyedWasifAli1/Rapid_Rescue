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
    public class ambulancesController : ControllerBase
    {
        private readonly Rapid_RescueDbContext _context;

        public ambulancesController(Rapid_RescueDbContext context)
        {
            _context = context;
        }

        // GET: api/ambulances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ambulance>>> Getambulances()
        {
            return await _context.ambulances.ToListAsync();
        }

        // GET: api/ambulances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ambulance>> Getambulance(int id)
        {
            var ambulance = await _context.ambulances.FindAsync(id);

            if (ambulance == null)
            {
                return NotFound();
            }

            return ambulance;
        }

        // PUT: api/ambulances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putambulance(int id, ambulance ambulance)
        {
            if (id != ambulance.ambulancesid)
            {
                return BadRequest();
            }

            _context.Entry(ambulance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ambulanceExists(id))
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

        // POST: api/ambulances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ambulance>> Postambulance(ambulance ambulance)
        {
            _context.ambulances.Add(ambulance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getambulance", new { id = ambulance.ambulancesid }, ambulance);
        }

        // DELETE: api/ambulances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deleteambulance(int id)
        {
            var ambulance = await _context.ambulances.FindAsync(id);
            if (ambulance == null)
            {
                return NotFound();
            }

            _context.ambulances.Remove(ambulance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ambulanceExists(int id)
        {
            return _context.ambulances.Any(e => e.ambulancesid == id);
        }
    }
}
