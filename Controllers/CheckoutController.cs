using DigitalThinkers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalThinkers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckoutController : ControllerBase
    {
        private ILogger _logger;

        public CheckoutController(ILogger<CheckoutController> logger)
        {
            this._logger = logger;
        }

        [HttpPost]
        public virtual ActionResult Index(CheckoutRequestDto request)
        {
            var response = new CheckoutResponse();

            return Ok(response);
        }
    }
}
