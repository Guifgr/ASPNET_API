using APIRest_ASPNET5.Business;
using APIRest_ASPNET5.Data.VO;
using Microsoft.AspNetCore.Mvc;

namespace APIRest_ASPNET5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/v{version:ApiVersion}/[controller]")]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult SignIn([FromBody] EmployeeVO employee)
        {
            if (employee == null) return BadRequest("Invalid Request");
            var token = _loginBusiness.ValidateCredentials(employee);
            if (token == null) return Unauthorized();
            return Ok(token);
        }
    }
}