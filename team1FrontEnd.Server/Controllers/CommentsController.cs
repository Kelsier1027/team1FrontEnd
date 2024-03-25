using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Dtos;
using team1FrontEnd.Server.Models;
using team1FrontEnd.Server.Services;

namespace team1FrontEnd.Server.Controllers
{
	[EnableCors("AllowAny")]
	[Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly dbTeam1Context _context;
        private readonly CommentService _service;
		public CommentsController(dbTeam1Context context)
        {
            _context = context;
			_service = new CommentService(_context);
		}
		
		// GET: api/Comments
		[HttpGet]
        public async Task<IEnumerable<CommentDto>> GetComments(int serviceCategoryId)
        {
            //return _context.Comments;
            return _service.GetAll(serviceCategoryId);
        }

        // GET: api/Comments/5
        [HttpGet("{id}")]
        public async Task<Comment> GetComment(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            
            return comment;
        }

        // PUT: api/Comments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<string> PutComment(int id, [FromForm] CommentDto comment)
        {
            if (id != comment.Id)
            {
                return "修改商品種類失敗";
            }

            _context.Entry(comment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommentExists(id))
                {
                    return "修改商品種類失敗";
                }
                else
                {
                    throw;
                }
            }

            return "修改商品種類成功!";
        }

        // POST: api/Comments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Comment>> PostComment(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetComment", new { id = comment.Id }, comment);
        }

        // DELETE: api/Comments/5
        [HttpDelete("{id}")]
        public async Task<string> DeleteComment(int id)
        {
            if(_context.Comments == null) return "刪除失敗";

			var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return "刪除失敗";

			}
            try { 
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
			}catch(DbUpdateException)
            {
                return "刪除失敗";
            }
			await _context.SaveChangesAsync();

			return "刪除成功!";
			
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
