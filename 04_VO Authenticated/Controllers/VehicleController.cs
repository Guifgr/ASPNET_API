using APIRest_ASPNET5.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using APIRest_ASPNET5.Data.VO;
using APIRest_ASPNET5.Hypermedia.Filters;
using Microsoft.AspNetCore.Authorization;

namespace APIRest_ASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
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
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_vehicleBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var vehicle = _vehicleBusiness.FindById(id);
            if (vehicle == null) return NotFound();
            return Ok(vehicle);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] VehicleVO vehicle)
        {
            if (vehicle == null) return BadRequest();
            return Ok(_vehicleBusiness.Create(vehicle));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
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
