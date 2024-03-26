using NuGet.Protocol;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Dtos
{
	public class CommentDto
	{
		public int Id { get; set; }
		public int MemberId { get; set; }
		public string MemberName { get; set; }
		public int Rating { get; set; }
		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime CommentDateTime { get; set; }
		public int ServiceCategoryId { get; set; }
		public string ServiceCategoryName { get; set;}
		public int ItemId { get; set; }
		public ICommentItem Item { get; set; }

		public List<CommentImage> Images { get; set; }
	}
}
