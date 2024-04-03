using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using team1FrontEnd.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace team1FrontEnd.Server.Controllers.Huang
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
		public async Task<IEnumerable<CartItem>> GetCartItems()
		{
			return await _context.CartItems.ToListAsync();
		}

		// GET: api/CartItems/5
		[HttpGet("GetCartItems")]
		public async Task<IEnumerable<GetCartItemsDto>> GetCartItems(int cartId, int categoryId)
		{
			var cartItems =  _context.CartItems.Where(x => x.ServicerCategoryId == categoryId && x.CartId==cartId).ToList().Select(x => new GetCartItemsDto {Id=x.Id, cartItem = GetItem(x.ItemId, categoryId),quantity=x.Quantity });
			
			return  cartItems;
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
		[HttpPost("addCartItem")]
		public async Task<string> PostCartItem([FromBody] CartItemDto cartItemDto)
		{
			Cart cart;

			if (!_context.Carts.Any(x => x.MemberId == cartItemDto.memberId))
			{
				_context.Carts.Add(new Cart() { MemberId = cartItemDto.memberId });
				await _context.SaveChangesAsync();
			}

			cart = _context.Carts.Where(x => x.MemberId == cartItemDto.memberId).Single();

			var item = new CartItem
			{
				CartId = cart.Id,
				ItemId = cartItemDto.itemId,
				Quantity = cartItemDto.quantity,
				ServicerCategoryId = cartItemDto.categoryId,
			};
			_context.CartItems.Add(item);
			await _context.SaveChangesAsync();

			return "已成功加入購物車";
		}

		// DELETE: api/CartItems/5
		[HttpDelete("DeleteCartItem")]
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

		[HttpDelete("DeleteCartAllItem")]
		public async Task<string> DeleteCartAllItem(int cartId)
		{
			var cartAllItem = await _context.CartItems.Where(x => x.CartId == cartId).ToListAsync();
			if (cartAllItem == null)
			{
				return "結帳失敗";
			}

			_context.CartItems.RemoveRange(cartAllItem);
			await _context.SaveChangesAsync();

			return "結帳成功";
		}

		[HttpPost("CreatOrder")]
		public async Task CreatOrder(int categoryId, int orderId, IEnumerable<CartItem> cartItems)
		{
			switch (categoryId)
			{
				case 1: // 景點訂單                       

					// 如果訂單不存在，則新建一個
					var attractionOrder = new AttractionOrder
					{
						MemberId = cartItems.First().Cart.MemberId,
						OrderDate = DateTime.Now,
						TicketTotalPrice = cartItems.Select(x => _context.AttractionTickets.Find(x.ItemId).Price).Aggregate((sum, x) => sum += x),
						AttractionOrderStatusId = 1,
					};
					_context.AttractionOrders.Add(attractionOrder);
					await _context.SaveChangesAsync();

					foreach (var item in cartItems)
					{
						var attration = new AttrationOrderItem
						{
							AttractionOrderId = attractionOrder.Id,
							AttractionTicketId = item.ItemId,
							Qty = item.Quantity,
							UnitPrice = _context.AttractionTickets.Find(item.ItemId).Price,
						};
						attractionOrder.AttrationOrderItems.Add(attration);
						await _context.SaveChangesAsync();
					}
					break;
				case 2: // 房間訂單                        

					var hotelOrder = new HotelOrder
					{
						OrderSn = "123",
						NumberOfPeople = 1,
						Breakfast = true,
						HotelOrderStatusId = 1,
						Phone = "0932112383",
						CreditCard = "8786-7576-5372-8908",
						MemberId = cartItems.First().Cart.MemberId,
						Price = cartItems.Select(x => _context.HotelRooms.Find(x.ItemId).Price).Aggregate((sum, x) => sum += x),
						Checkin = DateTime.Now,
						Checkout = DateTime.Now,
					};
					_context.HotelOrders.Add(hotelOrder);
					await _context.SaveChangesAsync();
					foreach (var item in cartItems)
					{
						var hotel = new HotelOrderItem
						{
							HotelRoomId = item.Id,
							HotelOrderId = hotelOrder.Id,
						};
						hotelOrder.HotelOrderItems.Add(hotel);
						await _context.SaveChangesAsync();
					}

					break;
				case 3: // 套裝行程訂單
					foreach (var item in cartItems)
					{
						var packageOrder = new PackageOrder
						{
							OrderDate = DateTime.Now,
							PackageId = item.Id,
							PackageOrdeStatusId = 1,
							MemberId = cartItems.First().Cart.MemberId,
							Quantity = item.Quantity,
							TotalAmt = cartItems.Select(x => _context.Packages.Find(x.ItemId).Price).Aggregate((sum, x) => sum += x),
						};
						_context.PackageOrders.Add(packageOrder);
						await _context.SaveChangesAsync();
					}
					break;
			}
			// 儲存對資料庫的更改
			await _context.SaveChangesAsync();
		}

		private ICartItem GetItem(int itemId, int categoryId)
		{

			if (categoryId == 1) return _context.AttractionTickets.Include(x=> x.Attraction).Where(x => x.Id == itemId).SingleOrDefault();//景點

			if (categoryId == 2) return _context.HotelRooms.Find(itemId);//房間

			if (categoryId == 3) return _context.Packages.Find(itemId);//套裝行程

			throw new NotImplementedException();
		}

		//private bool CartItemExists(int id)
		//{
		//    return _context.CartItems.Any(e => e.Id == id);
		//}
	}
}
