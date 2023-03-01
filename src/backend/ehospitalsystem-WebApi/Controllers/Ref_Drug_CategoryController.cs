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
    public class Ref_Drug_CategoryController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public Ref_Drug_CategoryController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/Ref_Drug_Category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ref_Drug_Category>>> GetRef_Drug_Categories()
        {
            return await _context.Ref_Drug_Categories.ToListAsync();
        }

        // GET: api/Ref_Drug_Category/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ref_Drug_Category>> GetRef_Drug_Category(int id)
        {
            var ref_Drug_Category = await _context.Ref_Drug_Categories.FindAsync(id);

            if (ref_Drug_Category == null)
            {
                return NotFound();
            }

            return ref_Drug_Category;
        }

        // PUT: api/Ref_Drug_Category/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRef_Drug_Category(int id, Ref_Drug_Category ref_Drug_Category)
        {
            if (id != ref_Drug_Category.Id)
            {
                return BadRequest();
            }

            _context.Entry(ref_Drug_Category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Ref_Drug_CategoryExists(id))
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

        // POST: api/Ref_Drug_Category
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ref_Drug_Category>> PostRef_Drug_Category(Ref_Drug_Category ref_Drug_Category)
        {
            _context.Ref_Drug_Categories.Add(ref_Drug_Category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRef_Drug_Category", new { id = ref_Drug_Category.Id }, ref_Drug_Category);
        }

        // DELETE: api/Ref_Drug_Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRef_Drug_Category(int id)
        {
            var ref_Drug_Category = await _context.Ref_Drug_Categories.FindAsync(id);
            if (ref_Drug_Category == null)
            {
                return NotFound();
            }

            _context.Ref_Drug_Categories.Remove(ref_Drug_Category);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Ref_Drug_CategoryExists(int id)
        {
            return _context.Ref_Drug_Categories.Any(e => e.Id == id);
        }
    }
}
