using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FYMWebAPI.Models;

namespace FYMWebAPI.Controllers
{
        [Route("api/[controller]")]
        [ApiController]
        public class CareGiverDetailsController : ControllerBase
        {
            private readonly FYMAppContext _context;

            public CareGiverDetailsController(FYMAppContext context)
            {
                _context = context;
            }

            // GET: api/CareGiverDetails
            [HttpGet]
            public async Task<ActionResult<IEnumerable<CareGiverDetails>>> GetCareGiversDetails()
            {
                return await _context.CareGiversDetails.ToListAsync();
            }

            // GET: api/StudentDetails/5

            // PUT: api/StudentDetails/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            [HttpPut("{id}")]
            public async Task<IActionResult> PutStudentDetails(int id, CareGiverDetails careGiverDetails)
            {
                if (id != careGiverDetails.ID)
                {
                    return BadRequest();
                }

                _context.Entry(careGiverDetails).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CareGiverDetailsExists(id))
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

            // POST: api/StudentDetails
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for
            // more details see https://aka.ms/RazorPagesCRUD.
            [HttpPost]
            public async Task<ActionResult<CareGiverDetails>> PostStudentDetails(CareGiverDetails careGiverDetails)
            {
                _context.CareGiversDetails.Add(careGiverDetails);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetCareGiverDetails", new { id = careGiverDetails.ID }, careGiverDetails);
            }

            // DELETE: api/StudentDetails/5
            [HttpDelete("{id}")]
            public async Task<ActionResult<CareGiverDetails>> DeleteCareGiverDetails(int id)
            {
                var careGiverDetails = await _context.CareGiversDetails.FindAsync(id);
                if (careGiverDetails == null)
                {
                    return NotFound();
                }

                _context.CareGiversDetails.Remove(careGiverDetails);
                await _context.SaveChangesAsync();

                return careGiverDetails;
            }

            private bool CareGiverDetailsExists(int id)
            {
                return _context.CareGiversDetails.Any(e => e.ID == id);
            }
        }
    
}
