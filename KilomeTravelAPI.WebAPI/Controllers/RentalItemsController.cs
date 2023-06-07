using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KilomeTravelAPI.WebAPI.Context;
using KilomeTravelAPI.WebAPI.Models;

namespace KilomeTravelAPI.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalItemsController : ControllerBase
    {
        private readonly RentContext _context;

        public RentalItemsController()
        {
            _context = new RentContext();
        }

        // GET: api/RentalItems/Types
        [HttpGet("Types")]
        public async Task<ActionResult<IEnumerable<RentalItemType>>> GetRentalItemTypes()
        {
            if (_context.RentalItemTypes == null)
            {
                return NotFound();
            }
            return await _context.RentalItemTypes.Where(type => type.Enabled).ToListAsync();
        }

        // GET: api/RentalItems/type/5
        [HttpGet("type/{itemTypeId}")]
        public async Task<ActionResult<IEnumerable<RentalItem>>> GetRentalItems(int itemTypeId)
        {
          if (_context.RentalItems == null)
          {
              return NotFound();
          }
            return await _context.RentalItems.Where(item => item.RentalItemTypeId == itemTypeId).ToListAsync();
        }

        // GET: api/RentalItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RentalItem>> GetRentalItem(int id)
        {
          if (_context.RentalItems == null)
          {
              return NotFound();
          }
            var rentalItem = await _context.RentalItems.FindAsync(id);

            if (rentalItem == null)
            {
                return NotFound();
            }

            return rentalItem;
        }

        private bool RentalItemExists(int id)
        {
            return (_context.RentalItems?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
