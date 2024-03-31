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
    public class HotelRoomsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public HotelRoomsController(dbTeam1Context context)
        {
            _context = context;
        }

        // GET: api/HotelRooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> GetHotelRooms()
        {
            return await _context.HotelRooms.ToListAsync();
        }

        // GET: api/HotelRooms/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelRoom>> GetHotelRoom(int id)
        {
            var hotelRoom = await _context.HotelRooms.FindAsync(id);

            if (hotelRoom == null)
            {
                return NotFound();
            }

            return hotelRoom;
        }

        // 修改后的代码
        // GET: api/HotelRooms/hotel/5
        [HttpGet("hotel/{hotelId}")]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> GetHotelRoomsByHotelId(int hotelId)
        {
            var hotelRooms = await _context.HotelRooms
                                            .Where(hr => hr.HotelId == hotelId)
                                            .ToListAsync();

            if (hotelRooms == null || hotelRooms.Count == 0)
            {
                return NotFound();
            }

            return hotelRooms;
        }

        // PUT: api/HotelRooms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelRoom(int id, HotelRoom hotelRoom)
        {
            if (id != hotelRoom.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotelRoom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelRoomExists(id))
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

        // POST: api/HotelRooms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HotelRoom>> PostHotelRoom(HotelRoom hotelRoom)
        {
            _context.HotelRooms.Add(hotelRoom);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelRoom", new { id = hotelRoom.Id }, hotelRoom);
        }

        // DELETE: api/HotelRooms/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHotelRoom(int id)
        {
            var hotelRoom = await _context.HotelRooms.FindAsync(id);
            if (hotelRoom == null)
            {
                return NotFound();
            }

            _context.HotelRooms.Remove(hotelRoom);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HotelRoomExists(int id)
        {
            return _context.HotelRooms.Any(e => e.Id == id);
        }
    }
}
