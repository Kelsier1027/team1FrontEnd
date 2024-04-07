using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.個人.Chih._03_Infrastructure.DTOs;
using team1FrontEnd.Server.個人.Chih._03_Infrastructure.Utilities;

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

        [HttpPost]
        public async Task<string>CreateOrder(int userId)
        {
            //檢查購物車的商品是否為空
            var userCart = await _dbTeam1Context.AttractionCarts
                                    .Where(x=>x.MemberId== userId)
                                    .Include(x=>x.AttractionCartItems)
                                    .SelectMany(x=>x.AttractionCartItems)//壓平集合?
                                    .AnyAsync();
            if (!userCart) 
            {
                return "請新增商品";
            }

            var order =_dbTeam1Context.AttractionOrders.Add(new AttractionOrder
            {
                MemberId = userId,
                OrderDate = DateTime.Now,
                TicketTotalPrice = 0,
                AttractionOrderStatusId=1,
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
                var ticket = await _dbTeam1Context.AttractionTickets.Where(x => x.Id == item.Items).FirstOrDefaultAsync();

                for (int i = 0, Max = item.Quantity; i < Max; i++) {
                    var qrData = $"{orderId}-{item.Items}-{Guid.NewGuid()}";
                    var qrFileName = $"ispan{item.Items}_{Guid.NewGuid()}.png";
                    var qrFilePath = Path.Combine("MyStaticFiles", "images", "chih", "QrCode",qrFileName);

                    Qrcode.CreateQrcode(qrData, qrFilePath);
                    var qrDataHash=Qrcode.ComputeHash(qrData);
                    var orderItem = new AttrationOrderItem()
                    {
                        AttractionTicketId = item.Items,
                        AttractionOrderId = orderId,
                        Qty = 1,
                        UnitPrice = ticket.Price,
                        QrcodeFileName = qrFileName,
                        Qrdata=qrDataHash,
                        IsUse=false,
                        CreateTime= DateTime.Now,  
                    };

                    _dbTeam1Context.AttrationOrderItems.Add(orderItem);
                    ticketTotalPrice += item.Quantity * ticket.Price;
                }
            }
            await _dbTeam1Context.SaveChangesAsync();

            var updateOrder = await _dbTeam1Context.AttractionOrders.FindAsync(orderId);
            
            if(updateOrder != null)
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
                var cart = await _dbTeam1Context.AttractionCarts.FirstOrDefaultAsync(x=>x.MemberId==userId);
                cart.Total = 0;
                await _dbTeam1Context.SaveChangesAsync();
            }
            return "訂單建立成功";


        }
        [HttpPost("GetUserTicket")]
        public async Task<IEnumerable<UserTicketDTO>> GetUserTicket([FromBody]int userId)
        {
            var userTicket = await _dbTeam1Context.AttractionOrders.Where(x => x.MemberId == userId)
                                    .SelectMany(x => x.AttrationOrderItems)
                                    .Select(x => new UserTicketDTO
                                    {
                                        ItemId = x.Id,
                                        AttractionOrderId = x.AttractionOrderId,
                                        TicketName = x.AttractionTicket.TicketTitle,
                                        ImgOfQRCode = x.QrcodeFileName,
                                        TicketImg=x.AttractionTicket.Attraction.MainImage,
                                        CreateTime = x.CreateTime,
                                        IsUse=x.IsUse,
                                    }).ToListAsync();


            foreach (var item in userTicket)
            {
                item.ImgOfQRCode=$"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/QrCode/{item.ImgOfQRCode}";
            }
            foreach(var item in userTicket)
            {
                item.TicketImg= $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/AttractionMain/{item.TicketImg}";
            }

            return userTicket;
        }
        [HttpPost("ScanQRCode")]
        public async Task<string> ScanQRCode([FromBody] string qrData)
        {
            var qrDataHash = Qrcode.ComputeHash(qrData);

            var userTicket = await _dbTeam1Context.AttrationOrderItems.Where(x => x.Qrdata == qrDataHash)
                                                                        .FirstOrDefaultAsync();
            if(userTicket == null) 
            { 
                return "無此票券";
            }

            userTicket.IsUse=true;
            
            _dbTeam1Context.SaveChanges();
            return "票券使用成功";
        }
    }
}
