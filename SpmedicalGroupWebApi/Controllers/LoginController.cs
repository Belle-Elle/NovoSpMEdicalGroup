using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SpmedicalGroupWebApi.Interfaces;
using SpmedicalGroupWebApi.Repositories;
using SpmedicalGroupWebApi.ViewModel;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace SpmedicalGroupWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);

                if (usuarioBuscado == null)
                {
                    return NotFound("E-mail ou senha inválidos!");
                }
                var minhasClaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),
                    new Claim(JwtRegisteredClaimNames.Name, usuarioBuscado.NomeUsuario),
                    new Claim(ClaimTypes.Role,usuarioBuscado.IdTipoUsuario.ToString()),
                    new Claim("role", usuarioBuscado.IdtipoUsuario.ToString())
                };

                var key = new SymmetricSecurityKey(System.Text.Enconding.UTF8.GetBytes("cjhsdcsjhsbdcshchchdj"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var meuToken = new JwtSecurityToken(
                   issuer: "senai.spmedgroup.webAPI",
                   audience: "senai.spmedgroup.webAPI",
                   claims: minhasClaims,
                   expires: DateTime.Now.AddMinutes(35),
                   signingCredentials: creds
                   );


                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(meuToken)
                });
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
