using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Controllers.Zheng;
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
        public async Task<IEnumerable<CartItem>> GetCartItems()
        {
            return await _context.CartItems.ToListAsync();
        }

        // GET: api/CartItems/5
        [HttpGet("GetCartItems")]
        public async Task<IEnumerable<GetCartItemsDto>> GetCartItems(int cartId, int categoryId)
        {
            var cartItems = _context.CartItems.Where(x => x.ServicerCategoryId == categoryId && x.CartId == cartId).ToList().Select(x => new GetCartItemsDto { selected = false, Id = x.Id, CategoryId = categoryId, cartItem = GetItem(x.ItemId, categoryId), quantity = x.Quantity });

            if (categoryId == 0) cartItems = _context.CartItems.Where(x => x.CartId == cartId).ToList().Select(x => new GetCartItemsDto { selected = false, Id = x.Id, cartItem = GetItem(x.ItemId, x.ServicerCategoryId), quantity = x.Quantity ,CategoryId=x.ServicerCategoryId});

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


            var checkItem = _context.CartItems.Where(x => x.ItemId == cartItemDto.itemId && x.ServicerCategoryId == cartItemDto.categoryId).FirstOrDefault();

            if (checkItem != null) 
            {
                checkItem.Quantity += cartItemDto.quantity;

                await _context.SaveChangesAsync();
            }
            else
            {

                var item = new CartItem
                {
                    CartId = cart.Id,
                    ItemId = cartItemDto.itemId,
                    Quantity = cartItemDto.quantity,
                    ServicerCategoryId = cartItemDto.categoryId,
                };
                _context.CartItems.Add(item);
                await _context.SaveChangesAsync();
            }

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

        //[HttpDelete("DeleteCartAllItem")]
        //public async Task<string> DeleteCartAllItem(int cartId)
        //{
        //    var cartAllItem = await _context.CartItems.Where(x => x.CartId == cartId).ToListAsync();
        //    if (cartAllItem == null)
        //    {
        //        return "結帳失敗";
        //    }

        //    _context.CartItems.RemoveRange(cartAllItem);
        //    await _context.SaveChangesAsync();

        //    return "結帳成功";
        //}

        [HttpPost("CreatOrder")]
        public async Task<OrderVm> CreatOrder([FromBody]IEnumerable<int> cartItemIds)
        {
            var cartItems = cartItemIds.Select(x => _context.CartItems.Include(y => y.Cart).Where(y => y.Id == x).SingleOrDefault()).ToList();

            AttractionOrder attractionOrder = null;

            HotelOrder hotelOrder = null;

            var attractionOrderTotal = 0;

            var hotelOrderTotal = 0;

            foreach (var cartItem in cartItems)
            {
                switch (cartItem.ServicerCategoryId)
                {
                    case 1: // 景點訂單                       

                        // 如果訂單不存在，則新建一個
                        
                        if (attractionOrder == null)
                        {
                            attractionOrder = new AttractionOrder
                            {
                                MemberId = cartItem.Cart.MemberId,
                                OrderDate = DateTime.Now,
                                TicketTotalPrice = 0,
                                AttractionOrderStatusId = 1,
                            };
                            _context.AttractionOrders.Add(attractionOrder);
                            await _context.SaveChangesAsync();
                        }

                        var attration = new AttrationOrderItem
                        {
                            AttractionOrderId = attractionOrder.Id,
                            AttractionTicketId = cartItem.ItemId,
                            Qty = cartItem.Quantity,
                            UnitPrice = _context.AttractionTickets.Find(cartItem.ItemId).Price,
                        };

                        attractionOrderTotal += attration.Qty * (int)attration.UnitPrice;

                        attractionOrder.AttrationOrderItems.Add(attration);

                        await _context.SaveChangesAsync();

                        break;
                    case 2: // 房間訂單                        
                        

                        if (hotelOrder == null)
                        {
                            hotelOrder = new HotelOrder
                            {
                                OrderSn = "123",
                                NumberOfPeople = 1,
                                Breakfast = true,
                                HotelOrderStatusId = 1,
                                Phone = "0932112383",
                                CreditCard = "8786-7576-5372-8908",
                                MemberId = cartItem.Cart.MemberId,
                                Price = 0,
                                Checkin = DateTime.Now,
                                Checkout = DateTime.Now.AddDays(5),
                            };
                            _context.HotelOrders.Add(hotelOrder);

                            await _context.SaveChangesAsync();
                        }
                        
                        var hotel = new HotelOrderItem
                        {
                            HotelRoomId = cartItem.ItemId,
                            HotelOrderId = hotelOrder.Id,
                        };
                        hotelOrder.HotelOrderItems.Add(hotel);
                        hotelOrderTotal += _context.HotelRooms.Find(cartItem.ItemId).Price * cartItem.Quantity;

                        await _context.SaveChangesAsync();

                        break;
                    case 3: // 套裝行程訂單

                        var packageOrder = new PackageOrder
                        {
                            OrderDate = DateTime.Now,
                            PackageId = cartItem.Id,
                            PackageOrdeStatusId = 1,
                            MemberId = cartItem.Cart.MemberId,
                            Quantity = cartItem.Quantity,
                            TotalAmt = _context.Packages.Find(cartItem.ItemId).Price,
                        };
                        _context.PackageOrders.Add(packageOrder);

                        await _context.SaveChangesAsync();

                        break;
                    case 4:
                        var carOrder = new CarOrder
                        {
                            MemberId = 55,
                            CarId = cartItem.ItemId,
                            AdminId = 69,
                            StartDateTime = DateTime.Now,
                            EndDateTime = DateTime.Now.AddDays(5),
                            Price = _context.CarModels.Find(cartItem.ItemId).FeePerDay * 5,
                            CarOrderStatusId = 1,
                        };
                        _context.CarOrders.Add(carOrder);
                        
                        await _context.SaveChangesAsync();
                        break;
                }
                // 儲存對資料庫的更改
            }

          
            if (attractionOrder != null) attractionOrder.TicketTotalPrice = attractionOrderTotal;

            if (hotelOrder != null) hotelOrder.Price = hotelOrderTotal;

            var orderVm = new OrderVm
            {
                Total = attractionOrderTotal + hotelOrderTotal
            };
            _context.RemoveRange(cartItems);

            await _context.SaveChangesAsync();



            return orderVm;

        }

        private ICartItem GetItem(int itemId, int categoryId)
        {

            if (categoryId == 1) return _context.AttractionTickets.Include(x => x.Attraction).Where(x => x.Id == itemId).SingleOrDefault();//景點

            if (categoryId == 2) return _context.HotelRooms.Find(itemId);//房間

            if (categoryId == 3) return _context.Packages.Find(itemId);//套裝行程

            if (categoryId == 4 ) return _context.CarModels.Find(itemId);

            return null;
        }

        //private bool CartItemExists(int id)
        //{
        //    return _context.CartItems.Any(e => e.Id == id);
        //}

    }
}
