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
    public class PorudzbinaController : BaseController<Model.KorisnikController>
    {
        public PorudzbinaController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }


        [Authorize(Roles = "Prodavac")]
        [HttpGet("all")]
        public override IActionResult GetAll([FromQuery] int page, [FromQuery] int perPage, [FromQuery] string sort, [FromQuery] string direction)
        {
            return Ok(_baseService.GetAll(page, perPage, sort, direction));
        }

        [Authorize(Roles = "Kupac")]
        [HttpPost]
        public override IActionResult Add(Model.KorisnikController entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            Model.KorisnikController response = _baseService.Add(entity);

            return Ok(response);
        }

        [Authorize(Roles = "Kupac")]
        [HttpPut("{Id}")]
        public override IActionResult Update(int Id, Model.KorisnikController entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            bool response = _baseService.Update(Id, entity);

            return Ok(response);
        }

        [Authorize(Roles = "Kupac")]
        [HttpDelete("{Id}")]
        public override IActionResult Delete(int Id)
        {
            bool response = _baseService.Delete(Id);

            return Ok(response);
        }

        [Authorize(Roles ="Kupac")]
        [HttpGet("byKorisnik/{id}")]
        public override IActionResult Get(int id)
        
        {
            Model.KorisnikController entity = _baseService.Get(id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }

    }
}
