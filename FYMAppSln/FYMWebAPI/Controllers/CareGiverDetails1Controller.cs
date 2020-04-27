using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FYMWebAPI.Models;

namespace FYMWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CareGiverDetails1Controller : ControllerBase
    {
        private readonly FYMAppContext _context;

        public CareGiverDetails1Controller(FYMAppContext context)
        {
            _context = context;
        }

        // GET: api/CareGiverDetails1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CareGiverDetails>>> GetCareGiversDetails()
        {
            return await _context.CareGiversDetails.ToListAsync();
        }

        // GET: api/CareGiverDetails1/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CareGiverDetails>> GetCareGiverDetails(int id)
        {
            var careGiverDetails = await _context.CareGiversDetails.FindAsync(id);

            if (careGiverDetails == null)
            {
                return NotFound();
            }

            return careGiverDetails;
        }

        // PUT: api/CareGiverDetails1/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCareGiverDetails(int id, CareGiverDetails careGiverDetails)
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

        // POST: api/CareGiverDetails1
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<CareGiverDetails>> PostCareGiverDetails(CareGiverDetails careGiverDetails)
        {
            _context.CareGiversDetails.Add(careGiverDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCareGiverDetails", new { id = careGiverDetails.ID }, careGiverDetails);
        }

        // DELETE: api/CareGiverDetails1/5
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
