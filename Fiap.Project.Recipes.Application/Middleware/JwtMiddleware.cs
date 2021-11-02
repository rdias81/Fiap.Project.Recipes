using Fiap.Project.Recipes.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Project.Recipes.Application.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly AppSettings _appSettings;
        private readonly IConfiguration _appSettings;

        public JwtMiddleware(RequestDelegate next, IConfiguration appSettings)
        {
            _next = next;
            _appSettings = appSettings;
        }


        public async Task Invoke(HttpContext context, IUsuarioService userService)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();

            if (token != null)
                attachUserToContext(context, userService, token);

            await _next(context);
        }

        private void attachUserToContext(HttpContext context, IUsuarioService userService, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var secret = _appSettings["AppSettings:Secret"];
                //var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                var key = Encoding.ASCII.GetBytes(secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);

                // attach user to context on successful jwt validation
                context.Items["Usuario"] = userService.Obter(userId);
            }
            catch
            {
                // do nothing if jwt validation fails
                // user is not attached to context so request won't have access to secure routes
            }
        }


    }
}
