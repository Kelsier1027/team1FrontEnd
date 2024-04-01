using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers.Chih
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsOrderController : ControllerBase
    {
        private readonly dbTeam1Context _dbTeam1Context;

        public AttractionsOrderController(dbTeam1Context dbTeam1Context)
        {
            _dbTeam1Context = dbTeam1Context;
        }

        [HttpGet]
        public async Task<string> CreateOrder(int userId)
        {
            //檢查購物車的商品是否為空
            var userCart = await _dbTeam1Context.AttractionCarts
                                                        .Where(x => x.MemberId == userId)
                                                        .Include(x => x.AttractionCartItems)
                                                        .SelectMany(x => x.AttractionCartItems)//壓平集合?
                                                        .AnyAsync();
            if (!userCart)
            {
                return "請新增商品";
            }

            var order = _dbTeam1Context.AttractionOrders.Add(new AttractionOrder
            {
                MemberId = userId,
                OrderDate = DateTime.Now,
                TicketTotalPrice = 0,
                AttractionOrderStatusId = 1,
            });

            await _dbTeam1Context.SaveChangesAsync();

            var cartItems = await _dbTeam1Context.AttractionCarts.Where(x => x.MemberId == userId)
                                                            .Include(x => x.AttractionCartItems)
                                                            .SelectMany(x => x.AttractionCartItems)
                                                            .ToListAsync();
            var orderId = order.Entity.Id;
            decimal ticketTotalPrice = 0;

            foreach (var item in cartItems)
            {
                var ticket = await _dbTeam1Context.AttractionTickets.Where(x => x.Id == item.Items)
                                                                    .FirstOrDefaultAsync();

                var orderItem = new AttrationOrderItem()
                {
                    AttractionTicketId = item.Items,
                    AttractionOrderId = orderId,
                    Qty = item.Quantity,
                    UnitPrice = ticket.Price,
                };

                _dbTeam1Context.AttrationOrderItems.Add(orderItem);
                ticketTotalPrice += item.Quantity * ticket.Price;

            }
            await _dbTeam1Context.SaveChangesAsync();

            var updateOrder = await _dbTeam1Context.AttractionOrders.FindAsync(orderId);

            if (updateOrder != null)
            {
                updateOrder.TicketTotalPrice = ticketTotalPrice;
                await _dbTeam1Context.SaveChangesAsync();
            }
            var delCartItems = await _dbTeam1Context.AttractionCarts.Where(x => x.MemberId == userId)
                                                                    .Include(x => x.AttractionCartItems)
                                                                    .SelectMany(x => x.AttractionCartItems)
                                                                    .ToListAsync();
            if (delCartItems.Any())
            {
                _dbTeam1Context.AttractionCartItems.RemoveRange(delCartItems);
                var cart = await _dbTeam1Context.AttractionCarts.FirstOrDefaultAsync();
                cart.Total = 0;
                await _dbTeam1Context.SaveChangesAsync();
            }
            return "訂單建立成功";


        }
    }
}
