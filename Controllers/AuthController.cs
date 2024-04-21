using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Poslasticarnica.Configuration;
using Poslasticarnica.Core;
using Poslasticarnica.Model;
using Poslasticarnica.Model.dto;
using Poslasticarnica.Service;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace Poslasticarnica.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : BaseController<Korisnik>
    {
        public AuthController(ProjectConfiguration configuration, IKorisnikService korisnikService) : base(configuration, korisnikService)
        {

        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginDTO login)
        {

            if (login == null || login.Email == null || login.Lozinka == null)
            {
                return BadRequest("Pogresan korisnicki zahtev");
            }

            Korisnik korisnik = _userService.GetCurrentUser(login.Email);

            if (korisnik == null || !BCrypt.Net.BCrypt.Verify(login.Lozinka, korisnik.Lozinka))
            {
                return BadRequest("Pogresni kredencijali");
            }

            Claim[] claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, _configuration.Jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("Id", korisnik.Id.ToString()),
                new Claim("Email", korisnik.Email),
                new Claim(ClaimTypes.Role, korisnik.Uloga)
            };
            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(_configuration.Jwt.Key));
            SigningCredentials signIn = new(key, SecurityAlgorithms.HmacSha256);
            JwtSecurityToken token = new(_configuration.Jwt.Issuer, _configuration.Jwt.Audience, 
                claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });


        }

    }
            
}
