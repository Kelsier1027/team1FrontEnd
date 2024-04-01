using Microsoft.AspNetCore.Components.Web;
using Npgsql.Replication.PgOutput.Messages;
using team1FrontEnd.Server.Dtos;

namespace team1FrontEnd.Server.Models
{
	public partial class AttractionTicket : ICartItem
	{
		public string Name => this.TicketTitle;
		public string FileName => $"{this.Attraction.AttractionImages}";

		public int Quantity {  get; set; }

		int ICartItem.Price => (int)this.Price;
		
		
	}
	public partial class HotelRoom : ICartItem
	{
		public int Price => CalcPrice(this.CheckInDate, this.CheckOutDate);

		public DateTime CheckInDate {get; set;}
		public DateTime CheckOutDate { get; set;}

		public int Quantity => this.Count;
		public string FileName => $"{this.FileName}";

		private int CalcPrice(DateTime start, DateTime end)
		{
			if(end < start)
			{
				var temp = start;
				start = end;
				end = temp;
			}

			var flag = start;
			var total = 0;
			while (flag < end)
			{
				if (flag.DayOfWeek == DayOfWeek.Sunday || flag.DayOfWeek == DayOfWeek.Saturday)
				{
					total += this.WeekendPrice;
				} else
				{
					total += this.WeekdayPrice;
				}

				flag.AddDays(1);
			}
			return total;
		}

	}
	public partial class Package : ICartItem
	{
		public string FileName => $"{Image}";
		public int Quantity => this.TotalNum;
	}
	
}
