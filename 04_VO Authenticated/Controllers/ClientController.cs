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
    public class ClientController : ControllerBase
    {
        private readonly ILogger<ClientController> _logger;
        private IClientBusiness _clientBusiness;

        public ClientController(ILogger<ClientController> logger, IClientBusiness clientBusiness)
        {
            _logger = logger;
            _clientBusiness = clientBusiness;
        }

        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_clientBusiness.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var client = _clientBusiness.FindById(id);
            if (client == null) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] ClientVO client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientBusiness.Create(client));
        }
        
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] ClientVO client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientBusiness.Update(client));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _clientBusiness.Delete(id);
            return NoContent();
        }

    }
}
