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
        public override IActionResult GetAll()
        {
            return Ok(_baseService.GetAll());
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







    }
}
