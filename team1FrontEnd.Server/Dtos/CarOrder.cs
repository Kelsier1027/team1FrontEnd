using team1FrontEnd.Server.Dtos;

namespace team1FrontEnd.Server.Models
{
    public partial class AttractionTicket : ICartItem
    {
        public string Name => this.TicketTitle;
        public string FileName => $"{this.Attraction.AttractionImages}";
        int ICartItem.Price => (int)this.Price;

    }
    public partial class HotelRoom : ICartItem
    {
        public int Price => this.WeekdayPrice;

        //public string FileName => $"{this.FileName}";
        public string FileName
        {
            get
            {
                // 假设你想返回第一个HotelRoomImage的FileName
                return this.HotelRoomImages.FirstOrDefault()?.FileName;
            }
        }

        private bool WutDay()
        {
            DateTime now = DateTime.Now;
            DayOfWeek dayOfWeek = now.DayOfWeek;
            if (dayOfWeek == DayOfWeek.Sunday || dayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
            {
                return false;
            };
        }

    }
    public partial class Package : ICartItem
    {
        public string FileName => $"{Image}";
    }

}
