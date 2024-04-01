using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public HotelsController(dbTeam1Context context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            return await _context.Hotels.ToListAsync();
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
          if (_context.Hotels == null)
          {
              return NotFound();
          }
            var hotel = await _context.Hotels.FindAsync(id);

            if (hotel == null)
            {
                return NotFound();
            }

            return hotel;
        }

        // GET: api/Hotels/search?address=xxx
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<Hotel>>> SearchHotelsByAddress(string address)
        {
            if (_context.Hotels == null)
            {
                return NotFound("No hotels found.");
            }

            if (string.IsNullOrEmpty(address))
            {
                return BadRequest("Address is required for searching.");
            }

            // 使用 EF.Functions.Like 来进行模糊匹配
            var hotels = await _context.Hotels
                .Where(hotel => EF.Functions.Like(hotel.Address, $"%{address}%"))
                .ToListAsync();

            if (hotels == null || hotels.Count == 0)
            {
                return NotFound($"No hotels found with address containing '{address}'.");
            }

            return hotels;
        }

        // GET: api/Hotels/facilities?facilityIds=1,2,3
        [HttpGet("facilities")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotelsByFacilities([FromQuery] List<int> facilityIds)
        {
            if (_context.Hotels == null)
            {
                return NotFound("No hotels found.");
            }

            if (facilityIds == null || facilityIds.Count == 0)
            {
                return BadRequest("Facility IDs are required for searching.");
            }

            var hotels = await _context.Hotels
                .Where(hotel => hotel.HotelFacilities != null && facilityIds.All(fId => hotel.GetFacilityIds().Contains(fId)))
                .ToListAsync();

            if (hotels.Count == 0)
            {
                return NotFound("No hotels found with the specified facilities.");
            }

            return hotels;
        }




        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
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

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hotel>> PostHotel(Hotel hotel)
        {
          if (_context.Hotels == null)
          {
              return Problem("Entity set 'dbTeam1Context.Hotels'  is null.");
          }
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotel", new { id = hotel.Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            if (_context.Hotels == null)
            {
                return NotFound();
            }
            var hotel = await _context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelExists(int id)
        {
            return (_context.Hotels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
