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
    public class PatientMedicalRecordsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public PatientMedicalRecordsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/PatientMedicalRecords
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatientMedicalRecord>>> GetPatientMedicalRecords()
        {
            return await _context.PatientMedicalRecords.ToListAsync();
        }

        // GET: api/PatientMedicalRecords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatientMedicalRecord>> GetPatientMedicalRecord(int id)
        {
            var patientMedicalRecord = await _context.PatientMedicalRecords.FindAsync(id);

            if (patientMedicalRecord == null)
            {
                return NotFound();
            }

            return patientMedicalRecord;
        }

        // PUT: api/PatientMedicalRecords/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatientMedicalRecord(int id, PatientMedicalRecord patientMedicalRecord)
        {
            if (id != patientMedicalRecord.Id)
            {
                return BadRequest();
            }

            _context.Entry(patientMedicalRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatientMedicalRecordExists(id))
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

        // POST: api/PatientMedicalRecords
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PatientMedicalRecord>> PostPatientMedicalRecord(PatientMedicalRecord patientMedicalRecord)
        {
            _context.PatientMedicalRecords.Add(patientMedicalRecord);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatientMedicalRecord", new { id = patientMedicalRecord.Id }, patientMedicalRecord);
        }

        // DELETE: api/PatientMedicalRecords/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePatientMedicalRecord(int id)
        {
            var patientMedicalRecord = await _context.PatientMedicalRecords.FindAsync(id);
            if (patientMedicalRecord == null)
            {
                return NotFound();
            }

            _context.PatientMedicalRecords.Remove(patientMedicalRecord);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PatientMedicalRecordExists(int id)
        {
            return _context.PatientMedicalRecords.Any(e => e.Id == id);
        }
    }
}
