using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StavkaPorudzbineController : BaseController<StavkaPorudzbine>
    {
        public StavkaPorudzbineController(ProjectConfiguration configuration, IKorisnikService userService) : base(configuration, userService)
        {

        }
    }
}
