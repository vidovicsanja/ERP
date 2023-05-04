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

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpPost]
        public virtual IActionResult Add(Model.KorisnikController entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            Model.KorisnikController response = _baseService.Add(entity);

            return Ok(response);
        }

        [Authorize(Roles = "Kupac, Prodavac")]
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

        [Authorize(Roles = "Kupac,Prodavac")]
        [HttpDelete("{Id}")]
        public override IActionResult Delete(int Id)
        {
            bool response = _baseService.Delete(Id);

            return Ok(response);
        }

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
