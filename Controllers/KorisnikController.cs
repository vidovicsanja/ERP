using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;

using Poslasticarnica.Model;
using Poslasticarnica.Model.dto;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class KorisnikController : BaseController<Korisnik>
    {
        public KorisnikController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }

        [Authorize(Roles = "Prodavac")]
        [HttpGet("all")]
        public override IActionResult GetAll([FromQuery] int page, [FromQuery] int perPage, [FromQuery] string sort, [FromQuery] string direction)
        {
            return Ok(_baseService.GetAll(page, perPage, sort, direction));
        }


        [HttpGet("current")]
        public  IActionResult GetCurrentAction() 
        {
            Korisnik korisnik = GetCurrentUser();

            return Ok(korisnik);
        }


        [Authorize(Roles ="Kupac")]
        [HttpGet("{id}")]
        public override IActionResult Get(int id)
        {

            Korisnik korisnik = GetCurrentUser();

            if (korisnik is not null && korisnik.Id != id) 
            {
                return BadRequest();
            }


            Korisnik entity = _baseService.Get(id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }



        [HttpPost("register")]
        public IActionResult Register(RegistrationDTO korisnik)
        {
            Korisnik k = _userService.Register(korisnik);


            return Ok(k);
        }

        [HttpPost("addSeller")]
        public IActionResult AddSeller(RegistrationDTO korisnik)
        {
            Korisnik k = _userService.AddSeller(korisnik);


            return Ok(k);
        }

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpPut("{Id}")]
        public override IActionResult Update(int Id, Korisnik entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            bool response = _baseService.Update(Id, entity);

            return Ok(response);
        }


        //brisanje samo svojih podataka
        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpDelete("{Id}")]
        public virtual IActionResult Delete(int Id)
        {
            /*
            Korisnik korisnik = GetCurrentUser();

            if (korisnik is not null && korisnik.Id != Id)
            {
                return BadRequest();
            }
            */

            bool response = _baseService.Delete(Id);

            return Ok(response);
        }



    }
}
