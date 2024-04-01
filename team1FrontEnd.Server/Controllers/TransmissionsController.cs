using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public TransmissionsController(dbTeam1Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarTransmission>>> GetCarBrands()
        {
            if (_context.CarTransmissions == null)
            {
                return NotFound();
            }
            return await _context.CarTransmissions.ToListAsync();
        }
    }
}
