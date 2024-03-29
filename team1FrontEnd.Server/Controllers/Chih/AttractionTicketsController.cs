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
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Chih._03_Infrastructure.DTOs;

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

        [HttpGet("GetCartItems")]
        public async Task<IEnumerable<CartItemsDTO>> GetCartItems(int memberid)
        {
            //check是否有符合id資料
            var exist = await _context.AttractionCarts.AsNoTracking().AnyAsync(e => e.MemberId == memberid);
            //創建條件false

            if (!exist)
            {
                var newCart = new AttractionCart
                {
                    MemberId = memberid,
                    AttractionCartItems = new List<AttractionCartItem>(),
                };
                _context.AttractionCarts.Add(newCart);
                await _context.SaveChangesAsync();
            }
           
            //return member cart
            var cartItem = await _context.AttractionCarts.AsNoTracking().Where(c=>c.MemberId==memberid)
                    .Include(c => c.AttractionCartItems)
                    .ThenInclude(item => item.ItemsNavigation)
                    .Select(c => new CartItemsDTO
                    {
                        
                        CartId = c.Id,
                        MemberId = c.MemberId,
                        CartItems = c.AttractionCartItems.Select(x=>new CartTicketDTO
                        {
                           Id = x.Id,   
                           TicketName=x.ItemsNavigation.TicketTitle,
                           Price=x.ItemsNavigation.Price,
                           Qty=x.Quantity,
                        }).ToList(),
                        Total=c.AttractionCartItems
                             .Sum(item=>item.ItemsNavigation.Price*item.Quantity)
                            
                    }).ToListAsync();
            return cartItem;
              
        }

        [HttpPost("AddCartItem")]
        public async Task<String> AddCartItem([FromBody]AddItemDTO addItemDTO)
        {
            //判斷cart內是否有相同商品
            //這裡不能用asnotracking不然會被當成new entity而無法修改原有的資料
            var foundItem = await _context.AttractionCartItems.FirstOrDefaultAsync(x=>x.CartId==addItemDTO.CartId && x.Items==addItemDTO.ItemId);
            
            if(foundItem != null)
            {
                foundItem.Quantity+=addItemDTO.Quantity;
               
            }
            else
            {
                _context.AttractionCartItems.Add(new AttractionCartItem
                {
                    CartId = addItemDTO.CartId,
                    Items = addItemDTO.ItemId,
                    Quantity = addItemDTO.Quantity,

                });
            }
           await _context.SaveChangesAsync();
            return "新增成功";

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
