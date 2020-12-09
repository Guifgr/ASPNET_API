using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIRest_ASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ILogger<VehicleController> _logger;
        private IVehicleBusiness _vehicleBusiness;

        public VehicleController(ILogger<VehicleController> logger, IVehicleBusiness vehicleBusiness)
        {
            _logger = logger;
            _vehicleBusiness = vehicleBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_vehicleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var vehicle = _vehicleBusiness.FindById(id);
            if (vehicle == null) return NotFound();
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult Post([FromBody] VehicleVO vehicle)
        {
            if (vehicle == null) return BadRequest();
            return Ok(_vehicleBusiness.Create(vehicle));
        }

        [HttpPut]
        public IActionResult Put([FromBody] VehicleVO vehicle)
        {
            if (vehicle == null) return BadRequest();
            return Ok(_vehicleBusiness.Update(vehicle));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _vehicleBusiness.Delete(id);
            return NoContent();
        }
    }
}
