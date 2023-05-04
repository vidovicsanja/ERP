using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Model.dto;
using System.Data;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StavkaPorudzbineController : BaseController<Model.StavkaPorudzbineController>
    {
        public StavkaPorudzbineController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }

        [Authorize(Roles = "Prodavac")]
        [HttpPost]
        public override IActionResult Add(Model.StavkaPorudzbineController entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            Model.StavkaPorudzbineController response = _baseService.Add(entity);

            return Ok(response);
        }

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpPut("{Id}")]
        public override IActionResult Update(int Id, Model.StavkaPorudzbineController entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            bool response = _baseService.Update(Id, entity);

            return Ok(response);
        }

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpDelete("{Id}")]
        public override IActionResult Delete(int Id)
        {
            bool response = _baseService.Delete(Id);

            return Ok(response);
        }


        [HttpGet("byKorisnik/{korisnikId}")]
        public override IActionResult Get(int Id)

        {
            Model.StavkaPorudzbineController entity = _baseService.Get(Id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }

        /*
        [Authorize(Roles="Kupac")]
        [HttpPost("Proizvod")]
        public IActionResult AddProduct(ProizvodDto id)
        {
            return

        }
        */
        
    }
}
