using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KilomeTravelAPI.WebAPI.Context;
using KilomeTravelAPI.WebAPI.Models;

namespace KilomeTravelAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentOrdersController : ControllerBase
    {
        private readonly RentContext _context;

        public RentOrdersController()
        {
            _context = new RentContext();
        }

        // GET: api/RentOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RentOrder>>> GetRentOrders()
        {
          if (_context.RentOrders == null)
          {
              return NotFound();
          }
            return await _context.RentOrders.ToListAsync();
        }

        // GET: api/RentOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentOrder>> GetRentOrder(int id)
        {
          if (_context.RentOrders == null)
          {
              return NotFound();
          }
            var rentOrder = await _context.RentOrders.FindAsync(id);

            if (rentOrder == null)
            {
                return NotFound();
            }

            return rentOrder;
        }

        // PUT: api/RentOrders/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRentOrder(int id, RentOrder rentOrder)
        {
            if (id != rentOrder.Id)
            {
                return BadRequest();
            }

            _context.Entry(rentOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RentOrderExists(id))
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

        // POST: api/RentOrders
        [HttpPost]
        public async Task<ActionResult<RentOrder>> PostRentOrder(RentOrder rentOrder)
        {
          if (_context.RentOrders == null)
          {
              return Problem("Entity set 'RentContext.RentOrders'  is null.");
          }
            _context.RentOrders.Add(rentOrder);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRentOrder", new { id = rentOrder.Id }, rentOrder);
        }

        private bool RentOrderExists(int id)
        {
            return (_context.RentOrders?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
