using GameLogParser.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameLogParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LogParserController : ControllerBase
    {
        private readonly LogParserService _parser;

        public LogParserController()
        {
            _parser = new LogParserService();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _parser.Parse();
            return Ok(result);
        }
    }
}
