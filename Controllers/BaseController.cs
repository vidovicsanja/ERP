using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Service;
using System.Security.Claims;

namespace Poslasticarnica.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class BaseController<TEntity> : ControllerBase where TEntity : class
    {
        protected ProjectConfiguration _configuration;
        protected IKorisnikService _userService;
        protected BaseService<TEntity> _baseService;

        public BaseController(ProjectConfiguration configuration, IKorisnikService userService)
        {
            _configuration = configuration;
            _userService = userService;
            _baseService = new BaseService<TEntity>(configuration);

        }

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpGet("{Id}")]
        public virtual IActionResult Get(int Id)
        {
            TEntity entity = _baseService.Get(Id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }

        [Authorize(Roles = "Kupac, Prodavac")]
        [HttpGet("all")]
        public virtual IActionResult GetAll([FromQuery] int page, [FromQuery] int perPage, [FromQuery] string? sort, [FromQuery] string? direction)
        {
            return Ok(_baseService.GetAll(page, perPage, sort, direction));
        }

        [Authorize(Roles = "Prodavac, Kupac")]
        [HttpPost]
        public virtual IActionResult Add(TEntity entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }

            TEntity response = _baseService.Add(entity);

            return Ok(response);
        }

        [Authorize(Roles = "Prodavac")]
        [HttpPut("{Id}")]
        public virtual IActionResult Update(int Id, TEntity entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            bool response = _baseService.Update(Id, entity);

            return Ok(response);
        }



        [Authorize(Roles ="Prodavac")]
        [HttpDelete("{Id}")]
        public virtual IActionResult Delete(int Id)
        {
            bool response = _baseService.Delete(Id);

            return Ok(response);
        }

        protected Korisnik GetCurrentUser()
        {
            string email = HttpContext.User.Claims.FirstOrDefault(c => c.Type == "Email")?.Value;

            return _userService.GetCurrentUser(email);
        }



    }
}










  


