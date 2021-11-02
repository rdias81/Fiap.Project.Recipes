using Fiap.Project.Recipes.Api.Helpers;
using Fiap.Project.Recipes.Api.Model;
using Fiap.Project.Recipes.Api.Validator;
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

        public UsuariosController(IUsuarioService usuarioService)
        {

            _usuarioService = usuarioService;
        }


        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] AuthenticateRequest model)
        {
            var validator = new AuthenticateRequestValidator();
            var result = validator.Validate(model);
            if (!result.IsValid)
                return new BadRequestObjectResult(result.Errors);

            var user = _usuarioService.Login(model.Login, model.Senha);
            // return null if user not found
            if (user == null) return null;
            var token = _usuarioService.GenerateJwtToken(user);
            return Ok(new AuthenticateResponse(user, token));
        }

        [Authorize]
        [HttpGet("BuscarPorId")]
        public IActionResult GetbyId(int id)
        {
            var users = _usuarioService.Obter(id);
            return Ok(users);
        }

        [Authorize]
        [HttpPost("Criar")]
        public IActionResult Criar(Usuario usuario) 
        {
            var validator = new UsuarioValidator();
            var result = validator.Validate(usuario);
            if (!result.IsValid)
                return new BadRequestObjectResult(result.Errors);

            var userId = _usuarioService.SalvarUsuario(usuario);
            return Ok($"Usuarioid {userId} criado com sucesso.");
        }


        //[NonAction]
        //private string generateJwtToken(Usuario user)
        //{

        //}



    }
}
