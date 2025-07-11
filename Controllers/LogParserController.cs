using Microsoft.AspNetCore.Mvc;

namespace GameLogParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogParserController : ControllerBase
    {
       
        public IActionResult Index()
        {
            return Ok("Ok");
        }
    }
}
