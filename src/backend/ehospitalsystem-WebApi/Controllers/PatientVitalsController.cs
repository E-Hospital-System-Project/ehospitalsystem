using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ehospitalsystem_WebApi.Data;
using ehospitalsystem_WebApi.Models;

namespace ehospitalsystem_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientVitalsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public PatientVitalsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/PatientVitals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientVitals>>> GetPatientVitals()
        {
            return await _context.PatientVitals.ToListAsync();
        }

        // GET: api/PatientVitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientVitals>> GetPatientVitals(int id)
        {
            var patientVitals = await _context.PatientVitals.FindAsync(id);

            if (patientVitals == null)
            {
                return NotFound();
            }

            return patientVitals;
        }

        // PUT: api/PatientVitals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientVitals(int id, PatientVitals patientVitals)
        {
            if (id != patientVitals.Id)
            {
                return BadRequest();
            }

            _context.Entry(patientVitals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientVitalsExists(id))
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

        // POST: api/PatientVitals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PatientVitals>> PostPatientVitals(PatientVitals patientVitals)
        {
            _context.PatientVitals.Add(patientVitals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientVitals", new { id = patientVitals.Id }, patientVitals);
        }

        // DELETE: api/PatientVitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientVitals(int id)
        {
            var patientVitals = await _context.PatientVitals.FindAsync(id);
            if (patientVitals == null)
            {
                return NotFound();
            }

            _context.PatientVitals.Remove(patientVitals);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientVitalsExists(int id)
        {
            return _context.PatientVitals.Any(e => e.Id == id);
        }
    }
}
