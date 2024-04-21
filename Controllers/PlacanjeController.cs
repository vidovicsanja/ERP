using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using System.Data;

namespace Poslasticarnica.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PlacanjeController : BaseController<Placanje>
    {
        public PlacanjeController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }


        [Authorize(Roles = "Prodavac")]
        [HttpGet("all")]
        public override IActionResult GetAll([FromQuery] int page, [FromQuery] int perPage, [FromQuery] string sort, [FromQuery] string direction)
        {
            return Ok(_baseService.GetAll(page, perPage, sort, direction));
        }

        [Authorize(Roles = "Prodavac")]
        [HttpGet("{Id}")]
        public virtual IActionResult Get(int Id)
        {
            Placanje entity = _baseService.Get(Id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }
    }
}
