using Microsoft.AspNetCore.Mvc;
using SpmedicalGroupWebApi.Interfaces;
using SpmedicalGroupWebApi.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Controllers
{
    public class LoginController
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
