using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Service;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProizvodController : BaseController<Proizvod>
    {
        public ProizvodController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName(string name) 
        {
            ProizvodService proizvodService = new ProizvodService();

            return Ok(proizvodService.GetByName(name));
        }
    }
}
