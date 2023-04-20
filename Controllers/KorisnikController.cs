using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;

using Poslasticarnica.Model;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class KorisnikController : BaseController<Korisnik>
    {
        public KorisnikController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }

        [HttpPost("register")]
        public IActionResult Register(Korisnik korisnik) 
        {
            Korisnik k = _userService.Register(korisnik);


            return Ok(k);
        }

    }
}
