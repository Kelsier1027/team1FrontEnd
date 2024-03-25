using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myapi._01_BLL.IBILL;
using myapi._03_Infrastructure.DTOs;
using myapi.Models;

namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionTicketsController : ControllerBase
    {
        private readonly dbTeam1Context _context;
        private readonly IAttractionTicketService _service;

        public AttractionTicketsController(dbTeam1Context context,IAttractionTicketService service)
        {
            _context = context;
            _service = service;
        }

        [HttpGet("GetTicketById/{id}")]
        public async Task<IEnumerable<AttractionTicketDTO>> GetTicketById(int id)
        {
            return await  _service.GetTicketContent(id);
        }





        ////-----------------------------------------------------------------------------------------//
        //// GET: api/AttractionTickets
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<AttractionTicket>>> GetAttractionTickets()
        //{
        //    return await _context.AttractionTickets.ToListAsync();
        //}

        //// GET: api/AttractionTickets/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<AttractionTicket>> GetAttractionTicket(int id)
        //{
        //    var attractionTicket = await _context.AttractionTickets.FindAsync(id);

        //    if (attractionTicket == null)
        //    {
        //        return NotFound();
        //    }

        //    return attractionTicket;
        //}

        //// PUT: api/AttractionTickets/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutAttractionTicket(int id, AttractionTicket attractionTicket)
        //{
        //    if (id != attractionTicket.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(attractionTicket).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!AttractionTicketExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/AttractionTickets
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<AttractionTicket>> PostAttractionTicket(AttractionTicket attractionTicket)
        //{
        //    _context.AttractionTickets.Add(attractionTicket);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetAttractionTicket", new { id = attractionTicket.Id }, attractionTicket);
        //}

        //// DELETE: api/AttractionTickets/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAttractionTicket(int id)
        //{
        //    var attractionTicket = await _context.AttractionTickets.FindAsync(id);
        //    if (attractionTicket == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.AttractionTickets.Remove(attractionTicket);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool AttractionTicketExists(int id)
        //{
        //    return _context.AttractionTickets.Any(e => e.Id == id);
        //}
    }
}
