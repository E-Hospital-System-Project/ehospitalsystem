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
    public class Medical_EmployeeController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public Medical_EmployeeController(RepositoryContext context)
        {
            _context = context;
        }

        // GET: api/Medical_Employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medical_Employee>>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        // GET: api/Medical_Employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medical_Employee>> GetMedical_Employee(int id)
        {
            var medical_Employee = await _context.Employees.FindAsync(id);

            if (medical_Employee == null)
            {
                return NotFound();
            }

            return medical_Employee;
        }

        // PUT: api/Medical_Employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedical_Employee(int id, Medical_Employee medical_Employee)
        {
            if (id != medical_Employee.Id)
            {
                return BadRequest();
            }

            _context.Entry(medical_Employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Medical_EmployeeExists(id))
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

        // POST: api/Medical_Employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medical_Employee>> PostMedical_Employee(Medical_Employee medical_Employee)
        {
            _context.Employees.Add(medical_Employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedical_Employee", new { id = medical_Employee.Id }, medical_Employee);
        }

        // DELETE: api/Medical_Employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedical_Employee(int id)
        {
            var medical_Employee = await _context.Employees.FindAsync(id);
            if (medical_Employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(medical_Employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Medical_EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
