using DigitalThinkers.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DigitalThinkers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private ILogger _logger;

        public StockController(ILogger<StockController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            return Ok();
        }

        [HttpPost]
        public virtual ActionResult Index([FromBody] StockRequestDto request)
        {
            return Ok();
        }
    }
}
