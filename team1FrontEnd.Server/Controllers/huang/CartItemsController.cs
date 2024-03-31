using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Dtos;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers.huang
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public CartItemsController(dbTeam1Context context)
        {
            _context = context;
        }

        // GET: api/CartItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CartItem>>> GetCartItems()
        {
            return await _context.CartItems.ToListAsync();
        }

        // GET: api/CartItems/5
        [HttpGet("{cartId}")]
        public async Task<IEnumerable<ICartItem>> GetCartItems(int cartId, int categoryId)
        {
            var cartItems = _context.Carts.AsNoTracking().
                Where(x => x.Id == cartId).SingleOrDefault().CartItems.Where(x => x.ServicerCategoryId == categoryId).Select(x => x as ICartItem);			

            return cartItems;
        }

        // PUT: api/CartItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCartItem(int id, CartItem cartItem)
        //{
        //    if (id != cartItem.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(cartItem).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CartItemExists(id))
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

        // POST: api/CartItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<string> PostCartItem(int memberId ,int itemId, int categoryId)
        {
            Cart cart;

            if (!_context.Carts.Any(x => x.MemberId == memberId)) _context.Carts.Add(new Cart() { MemberId = memberId });

			cart = _context.Carts.Where(x => x.MemberId == memberId).Single();

            var item = new CartItem
            {
                CartId = cart.Id,
                ItemId = itemId,
                ServicerCategoryId = categoryId,
            };
            _context.CartItems.Add(item);
            await _context.SaveChangesAsync();

            return "已成功加入購物車";
        }

        // DELETE: api/CartItems/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteCartItem(int id)
        {
            var cartItem = await _context.CartItems.FindAsync(id);
            if (cartItem == null)
            {
                return "刪除失敗";
            }

            _context.CartItems.Remove(cartItem);
            await _context.SaveChangesAsync();

            return "刪除成功";
        }

		private ICartItem GetItem(int categoryId, int orderId)
		{

			if (categoryId == 2) _context.AttractionOrders.Find(orderId); //景點

			if (categoryId == 3) _context.HotelOrders.Find(orderId);//房間

			if (categoryId == 4) _context.PackageOrders.Find(orderId);//套裝行程
			throw new Exception();
		}

		//private bool CartItemExists(int id)
		//{
		//    return _context.CartItems.Any(e => e.Id == id);
		//}

	}
}
