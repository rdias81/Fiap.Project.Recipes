using Fiap.Project.Recipes.Api.Helpers;
using Fiap.Project.Recipes.Api.Model;
using Fiap.Project.Recipes.Application.Interfaces;
using Fiap.Project.Recipes.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Fiap.Project.Recipes.Api.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly AppSettings _appSettings;
        public UsuariosController(IOptions<AppSettings> appSettings, IUsuarioService usuarioService)
        {
            _appSettings = appSettings.Value;
            _usuarioService = usuarioService;
        }


        [HttpPost("authenticate")]
        public AuthenticateResponse Authenticate([FromBody] AuthenticateRequest model)
        {

            var user = _usuarioService.Login(model.Login, model.Senha);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        [Authorize]
        [HttpGet("BuscarPorId")]
        public IActionResult GetbyId(int id)
        {
            var users = _usuarioService.Obter(id);
            return Ok(users);
        }

        [NonAction]
        private string generateJwtToken(Usuario user)
        {
            try
            {
                // generate token that is valid for 7 days
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()),
                                                 new Claim(ClaimTypes.Name, user.Nome.ToString()),
                                                 new Claim(ClaimTypes.Role, user.Role.ToString())}),
                    Expires = DateTime.UtcNow.AddMinutes(20),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);
            }
            catch (Exception ex)
            {

                throw;
            }
        }



    }
}
