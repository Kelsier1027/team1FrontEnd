using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using myapi._01_BLL.IBILL;
using myapi._03_Infrastructure.DTOs;
using myapi.Models;
using myapi.Models.DTO;
using team1FrontEnd.Server.Models;


namespace myapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionsController : ControllerBase
    {
        private readonly dbTeam1Context _context;
        private readonly IAttractionService _attractionService;
        public AttractionsController(dbTeam1Context context,IAttractionService attractionService)
        {
            _context = context;
            _attractionService = attractionService;
        }

        [HttpGet("/api/Attractions/AttractionsContent")]
        public async Task<IEnumerable<AttractionContentDTO>> GetAttractionContent([FromQuery]int id)
        {
            var attractionContent = await _attractionService.GetAttractionContent(id);
            foreach (var item in attractionContent)
            {
                foreach(var image in item.AttractionContentImageDTO)
                {
                    image.Image= $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/AttractionContent/{image.Image}";
                }
            }

            return attractionContent;
        }
        [HttpGet("/api/Attractions/Search")]
        public async Task<IEnumerable<AttractionDTO>> GetAllAttraction([FromQuery]AttractionSearchDTO search)
        {
            var attraction = await _attractionService.Search(search);
            (attraction.ToList()).ForEach(a =>
            {
                a.MainImage = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/AttractionMain/{a.MainImage}";
            });
            return attraction;
        }
        [HttpGet("/api/Attractions/GetCategories")]
        public async Task<IEnumerable<AttractionCategory>> GetCategories()
        {
            var categories = await _context.AttractionCategories.OrderByDescending(c => c.Id)
                                                                .ToListAsync();
            categories.ForEach(c =>
            {
                c.Icon = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/CategoryIcon/{c.Icon}";
            });
            return categories;
        }

      ////----------------------------------------------------------------------------------------//

      //  ////GET: api/Attractions/
      //  //[HttpGet("/api/Attractions/test")]
      //  //public async Task<IEnumerable<AttractionDTO>> GetAttractionTest()
      //  //{
      //  //    var attraction = await _context.Attractions.ToListAsync();
      //  //    var dto = attraction.Select(x => new AttractionDTO
      //  //    {
      //  //        Id = x.Id,
      //  //        Name = x.Name,
      //  //        Description = x.Description,
      //  //        MainImage= x.MainImage,

      //  //    }).ToList();

      //  //    dto.ForEach(x =>
      //  //    {
      //  //        x.MainImage = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}/StaticFiles/images/chih/AttractionMain/{Url.Content($"{x.MainImage}")}";
      //  //    });
         
            
      //  //    return dto;
      //  //}


      //  // GET: api/Attractions

      //  [HttpGet]
      //  public async Task<ActionResult<IEnumerable<Attraction>>> GetAttractions()
      //  {
      //      return await _context.Attractions.ToListAsync();
      //  }

      //  // GET: api/Attractions/5
      //  [HttpGet("{id}")]
      //  public async Task<ActionResult<Attraction>> GetAttraction(int id)
      //  {
      //      var attraction = await _context.Attractions.FindAsync(id);

      //      if (attraction == null)
      //      {
      //          return NotFound();
      //      }

      //      return attraction;
      //  }

      //  // PUT: api/Attractions/5
      //  // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      //  [HttpPut("{id}")]
      //  public async Task<IActionResult> PutAttraction(int id, Attraction attraction)
      //  {
      //      if (id != attraction.Id)
      //      {
      //          return BadRequest();
      //      }

      //      _context.Entry(attraction).State = EntityState.Modified;

      //      try
      //      {
      //          await _context.SaveChangesAsync();
      //      }
      //      catch (DbUpdateConcurrencyException)
      //      {
      //          if (!AttractionExists(id))
      //          {
      //              return NotFound();
      //          }
      //          else
      //          {
      //              throw;
      //          }
      //      }

      //      return NoContent();
      //  }

      //  // POST: api/Attractions
      //  // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
      //  [HttpPost]
      //  public async Task<ActionResult<Attraction>> PostAttraction(Attraction attraction)
      //  {
      //      _context.Attractions.Add(attraction);
      //      await _context.SaveChangesAsync();

      //      return CreatedAtAction("GetAttraction", new { id = attraction.Id }, attraction);
      //  }

      //  // DELETE: api/Attractions/5
      //  [HttpDelete("{id}")]
      //  public async Task<IActionResult> DeleteAttraction(int id)
      //  {
      //      var attraction = await _context.Attractions.FindAsync(id);
      //      if (attraction == null)
      //      {
      //          return NotFound();
      //      }

      //      _context.Attractions.Remove(attraction);
      //      await _context.SaveChangesAsync();

      //      return NoContent();
      //  }

      //  private bool AttractionExists(int id)
      //  {
      //      return _context.Attractions.Any(e => e.Id == id);
      //  }
    }
}
