using KilomeTravelAPI.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KilomeTravelAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RentController : ControllerBase
    {
        private readonly ILogger<RentController> _logger;

        public RentController(ILogger<RentController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "")]
        public IEnumerable<RentOrder> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new RentOrder
            {
                ReservationTime = DateTime.Now.AddDays(index),
                CustomerName = "Bobby",
                CustomerPhoneNumber = "123"
            })
            .ToArray();
        }
    }
}