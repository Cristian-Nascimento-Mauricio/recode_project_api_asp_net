using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using recode_work_api.Models;

namespace recode_work_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase{

        private readonly TripDbContext _context;

        public ValuesController(TripDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IEnumerable<Trip> GetTrips()
        {

            Console.WriteLine("Okay");
            return _context.trips;
        }


        [HttpGet("{id}")]
        public IActionResult GetTrip(int id)
        {

            Trip trip = _context.trips.SingleOrDefault(m  => m.Id == id);

            if (trip == null) return NotFound();

            return new ObjectResult(trip);
        }
            
    }
}
