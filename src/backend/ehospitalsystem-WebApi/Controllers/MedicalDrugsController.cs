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
    public class MedicalDrugsController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public MedicalDrugsController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/MedicalDrugs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicalDrug>>> GetMedicalDrugs()
        {
            return await _context.MedicalDrugs.ToListAsync();
        }

        // GET: api/MedicalDrugs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicalDrug>> GetMedicalDrug(int id)
        {
            var medicalDrug = await _context.MedicalDrugs.FindAsync(id);

            if (medicalDrug == null)
            {
                return NotFound();
            }

            return medicalDrug;
        }

        // PUT: api/MedicalDrugs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicalDrug(int id, MedicalDrug medicalDrug)
        {
            if (id != medicalDrug.Id)
            {
                return BadRequest();
            }

            _context.Entry(medicalDrug).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicalDrugExists(id))
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

        // POST: api/MedicalDrugs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicalDrug>> PostMedicalDrug(MedicalDrug medicalDrug)
        {
            _context.MedicalDrugs.Add(medicalDrug);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicalDrug", new { id = medicalDrug.Id }, medicalDrug);
        }

        // DELETE: api/MedicalDrugs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicalDrug(int id)
        {
            var medicalDrug = await _context.MedicalDrugs.FindAsync(id);
            if (medicalDrug == null)
            {
                return NotFound();
            }

            _context.MedicalDrugs.Remove(medicalDrug);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicalDrugExists(int id)
        {
            return _context.MedicalDrugs.Any(e => e.Id == id);
        }
    }
}
