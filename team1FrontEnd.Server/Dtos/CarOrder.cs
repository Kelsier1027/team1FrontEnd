using team1FrontEnd.Server.Dtos;

namespace team1FrontEnd.Server.Models
{
	public partial class CarOrder : ICommentItem
	{
		public string Name => Car.CarModel.Name;

	}
	public partial class Attraction : ICommentItem
	{
	}
	public partial class Hotel : ICommentItem
	{
	}	
}
