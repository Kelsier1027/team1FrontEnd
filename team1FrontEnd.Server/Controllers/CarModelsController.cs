using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using team1FrontEnd.Server.Models;

namespace team1FrontEnd.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelsController : ControllerBase
    {
        private readonly dbTeam1Context _context;

        public CarModelsController(dbTeam1Context context)
        {
            _context = context;
        }

        // GET: api/CarModels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarModel>>> GetCarModels()
        {
            if (_context.CarModels == null)
            {
                return NotFound();
            }
            return await _context.CarModels.Select(x => new CarModel
            {
                Id = x.Id,
                Name = x.Name,
                FeePerDay = x.FeePerDay,
                MainImage = x.MainImage,
                Seats = x.Seats,
                CarBrand = x.CarBrand,
                CarEnergyType = x.CarEnergyType,
                CarTransmission = x.CarTransmission,
            }).ToListAsync();
        }

        // GET: api/CarModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarModel>> GetCarModel(int id)
        {
            if (_context.CarModels == null)
            {
                return NotFound();
            }
            var carModel = await _context.CarModels.FindAsync(id);

            if (carModel == null)
            {
                return NotFound();
            }

            return carModel;
        }

        // PUT: api/CarModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarModel(int id, CarModel carModel)
        {
            if (id != carModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(carModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CarModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarModel>> PostCarModel(CarModel carModel)
        {
            if (_context.CarModels == null)
            {
                return Problem("Entity set 'dbTeam1Context.CarModels'  is null.");
            }
            _context.CarModels.Add(carModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarModel", new { id = carModel.Id }, carModel);
        }

        // DELETE: api/CarModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarModel(int id)
        {
            if (_context.CarModels == null)
            {
                return NotFound();
            }
            var carModel = await _context.CarModels.FindAsync(id);
            if (carModel == null)
            {
                return NotFound();
            }

            _context.CarModels.Remove(carModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarModelExists(int id)
        {
            return (_context.CarModels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
