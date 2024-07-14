using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameController : ControllerBase
    {
        private static readonly string name = "Niteesh Rawal" ;

        private readonly ILogger<NameController> _logger;

        public NameController(ILogger<NameController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetName")]
        public IActionResult Get()
        {
            var programmerName = new Name { ProgrammerName = name };
            return Ok(programmerName);
        }
    }
}