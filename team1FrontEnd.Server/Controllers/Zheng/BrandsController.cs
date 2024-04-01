using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers.Zheng
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public BrandsController(dbTeam1Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarBrand>>> GetCarBrands()
        {
            if (_context.CarBrands == null)
            {
                return NotFound();
            }
            return await _context.CarBrands.ToListAsync();
        }
    }
}
