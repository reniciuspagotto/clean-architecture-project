using ArquiteturaPadrao.Domain.Command.User;
using ArquiteturaPadrao.Domain.Repositories;
using ArquiteturaPadrao.Shared.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ArquiteturaPadrao.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/login")]
    public class LoginController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _config;

        public LoginController(IConfiguration config, IUserRepository userRepository)
        {
            _config = config;
            _userRepository = userRepository;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login([FromBody] AuthenticateUserCommand command)
        {
            var result = _userRepository.UserLogin(command.Username, HashHelper.EncryptPassword(command.Password));

            if (result != null)
            {
                var claims = new[]
                    {
                new Claim("NameId", result.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Authentication:SecretKey"]));
                var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken
                (
                    claims: claims,
                    signingCredentials: credential,
                    expires: DateTime.Now.AddMinutes(300),
                    issuer: _config["Authentication:Issuer"],
                    audience: _config["Authentication:Audience"]
                );

                var jwtToken = new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                };

                return Ok(jwtToken);
            }
            else
                return Ok("Usuário ou senha inválidos");
        }
    }
}