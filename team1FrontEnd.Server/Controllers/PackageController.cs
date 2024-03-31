using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly dbTeam1Context _context;


        public PackageController(dbTeam1Context context)
        {
            _context = context;
        }
        // GET: api/Package
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Package>>> GetPackages(int id =0)
        {
            if (_context.Packages == null)
            {
                return NotFound();
            }
            return await _context.Packages.Where(x=>id==0 || x.Id == id).ToListAsync();
        }
    }
}
