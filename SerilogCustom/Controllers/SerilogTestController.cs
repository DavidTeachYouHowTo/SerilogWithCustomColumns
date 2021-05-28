using Microsoft.AspNetCore.Mvc;
using Serilog.Services.Service.Abstract;

namespace SerilogCustom.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SerilogTestController : ControllerBase
    {
        public readonly IUserServices _userServices;

        public SerilogTestController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _userServices.GetUserMessage();
            return Ok(result);
        }
    }
}
