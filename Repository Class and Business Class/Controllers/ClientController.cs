using APIRest_ASPNET5.Models;
using APIRest_ASPNET5.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIRest_ASPNET5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public IActionResult Get()
        {
            return Ok(_clientBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var client = _clientBusiness.FindById(id);
            if (client == null) return NotFound();
            return Ok(client);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            if (client == null) return BadRequest();
            return Ok(_clientBusiness.Create(client));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Client client)
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
