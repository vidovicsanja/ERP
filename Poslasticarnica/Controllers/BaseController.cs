using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Mvc;
using Poslasticarnica.Model;
using Poslasticarnica.Service;
using System.Security.Claims;

namespace Poslasticarnica.Controllers
{

    [ApiController]
    [Route{namespace: "api/[controller]"}]

    public class BaseController<TEntity>
    {
        protected PeojectConfiguration _configuration;
        protected IUserService _userService;
        protected BaseService<TEntity> _baseService;

        public BaseController(ProjectCobfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
            _baseService = new BaseService<TEntity>(configuration);

        }
        [HttpGet(template: "{id}")]
        public virtual IActionResult Get(int Id)
        {
            TEntity entity = _baseService.Get(Id);
            if (entity == null)
            {
                return BadRequest();

            }
            return Ok(entity);
        }
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

        [HttpPut(template:{Id})]
        public IActionResult Update = (int Id, TEntity entity)
        {
            if(entity==null)
             {
                return BadRequest();



                bool response = _baseService.Update(Id, entity);
              }
                return Ok(response);
         }

        [HttpDelete(template: "{Id}")]
        {
             bool response = _baseService.Delete(Id);
             return Ok(response);

        }

        protected User GetCurrentUser()
        {
             string email = HttpContext.User.Claims.FirtsOrDefault(c: Claim => c.Type == "Email")?.Value;
            return _userService.GetUserWithEmail(email);
        }
    }
}








  


