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
    public class PatientDrugTreatmentsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public PatientDrugTreatmentsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/PatientDrugTreatments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientDrugTreatment>>> GetPatientDrugTreatments()
        {
            return await _context.PatientDrugTreatments.ToListAsync();
        }

        // GET: api/PatientDrugTreatments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientDrugTreatment>> GetPatientDrugTreatment(int id)
        {
            var patientDrugTreatment = await _context.PatientDrugTreatments.FindAsync(id);

            if (patientDrugTreatment == null)
            {
                return NotFound();
            }

            return patientDrugTreatment;
        }

        // PUT: api/PatientDrugTreatments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientDrugTreatment(int id, PatientDrugTreatment patientDrugTreatment)
        {
            if (id != patientDrugTreatment.Id)
            {
                return BadRequest();
            }

            _context.Entry(patientDrugTreatment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientDrugTreatmentExists(id))
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

        // POST: api/PatientDrugTreatments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PatientDrugTreatment>> PostPatientDrugTreatment(PatientDrugTreatment patientDrugTreatment)
        {
            _context.PatientDrugTreatments.Add(patientDrugTreatment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientDrugTreatment", new { id = patientDrugTreatment.Id }, patientDrugTreatment);
        }

        // DELETE: api/PatientDrugTreatments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientDrugTreatment(int id)
        {
            var patientDrugTreatment = await _context.PatientDrugTreatments.FindAsync(id);
            if (patientDrugTreatment == null)
            {
                return NotFound();
            }

            _context.PatientDrugTreatments.Remove(patientDrugTreatment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientDrugTreatmentExists(int id)
        {
            return _context.PatientDrugTreatments.Any(e => e.Id == id);
        }
    }
}
