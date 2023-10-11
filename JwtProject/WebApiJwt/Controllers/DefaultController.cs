using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiJwt.Models;

namespace WebApiJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult Get()
        {
            return Ok(new CreateToken().Create());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Get2()
        {
            return Ok("Hoşgeldiniz");
        }
    }
}
