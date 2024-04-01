using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers.Zheng
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyTypesController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public EnergyTypesController(dbTeam1Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarEnergyType>>> GetCarBrands()
        {
            if (_context.CarEnergyTypes == null)
            {
                return NotFound();
            }
            return await _context.CarEnergyTypes.ToListAsync();
        }
    }
}
