using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        [HttpGet("GetHotelsByFacilities")]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels([FromQuery] List<int> facilities)
        {
            try
            {
                // 確認_context.Hotels是否為null
                if (_context.Hotels == null)
                {
                    return NotFound("沒有找到任何飯店資料。");
                }

                // 確認是否有提供設施ID
                if (facilities == null || facilities.Count == 0)
                {
                    return Ok(_context.Hotels); // 如果沒有提供設施ID,返回所有飯店
                }

                // 嘗試找到匹配所有提供設施ID的飯店列表
                var hotels = await _context.Hotels
                    .ToListAsync(); // 先把所有飯店資料拉到內存中

                hotels = hotels
                    .Where(hotel => hotel.HotelFacilities != null &&
                                    facilities.All(fId => ParseFacilityIds(hotel.HotelFacilities).Contains(fId)))
                    .ToList(); // 現在的過濾是在內存中進行的

                // 檢查找到的飯店列表是否為空
                if (hotels.Count == 0)
                {
                    return NotFound("沒有找到符合指定設施的飯店。");
                }

                // 回傳找到的飯店列表
                return Ok(hotels);
            }
            catch (Exception ex)
            {
                // 記錄錯誤
                return StatusCode(500, $"Error in GetHotels: {ex.Message}");
            }
        }

        private List<int> ParseFacilityIds(string facilityIdsString)
        {
            if (string.IsNullOrEmpty(facilityIdsString))
            {
                return new List<int>();
            }

            // 直接使用 JSON 反序列化方法來轉換
            try
            {
                var facilityIds = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, List<int>>>(facilityIdsString);
                return facilityIds?["FacilityIds"] ?? new List<int>();
            }
            catch (JsonException)
            {
                // 如果 JSON 格式不正確，則處理異常
                return new List<int>();
            }
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
