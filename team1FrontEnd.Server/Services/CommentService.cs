﻿using System;
using team1FrontEnd.Server.Dtos;
using team1FrontEnd.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace team1FrontEnd.Server.Services
{
	public class CommentService
	{
		private readonly dbTeam1Context _dbTeam1Context;
		public CommentService (dbTeam1Context dbTeam1Context)
		{
			_dbTeam1Context = dbTeam1Context;
		}
		private ICommentItem GetItem(int categoryId, int itemId) 
		{
			if (categoryId == 2) _dbTeam1Context.CarOrders.Find(itemId);

			if (categoryId == 3) _dbTeam1Context.Attractions.Find(itemId);

			if (categoryId == 4) _dbTeam1Context.Hotels.Find(itemId);
			
			if (categoryId == 5) _dbTeam1Context.Hotels.Find(itemId);
			throw new Exception();
		}
		public List<CommentDto> GetAll(int serviceCategoryId)
		{			
			var allComment = _dbTeam1Context.Comments.AsNoTracking().
				Include(x => x.Member).
				Include(x=>x.CommentImages).
				Include(x => x.ServiceCategory).
				Select(x => new CommentDto
				{	
					Id= x.Id,
					ServiceCategoryId = x.ServiceCategoryId,
					ServiceCategoryName = x.ServiceCategory.Name,
					MemberId = x.MemberId,
					MemberName = x.Member.Account,
					Rating = x.Rating,
					Title = x.Title,
					Text = x.Text,
					CommentDateTime = x.CommentDateTime,
					Item = GetItem(serviceCategoryId, x.ItemId),
					Images = _dbTeam1Context.CommentImages.AsNoTracking().
							 Where(x => x.CommentId==x.Id).ToList(),
				}).ToList();
			return allComment;
			//Dictionary<Comment, CarOrder> CarOrderComments = new Dictionary<Comment, CarOrder>();
			//if (serviceCategoryId == 1)
			//{
			//	foreach (var comment in allComment)
			//	{
			//		CarOrderComments.Add(comment, _dbTeam1Context.CarOrders.Find(comment.Id));
			//	} 

			//}
			//Dictionary<Comment, Hotel> hotelComments = new Dictionary<Comment, Hotel>();
			//if (serviceCategoryId == 2)
			//{
			//	foreach (var comment in allComment)
			//	{
			//		hotelComments.Add(comment, _dbTeam1Context.Hotels.Find(comment.Id));
			//	}

			//}
		}
		//public CommentDto Get(int id)
		//{

		//}
	}
}