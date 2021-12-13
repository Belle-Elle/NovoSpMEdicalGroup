using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpmedicalGroupWebApi.Interfaces;
using SpmedicalGroupWebApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class PacientesController : ControllerBase
    {

        private IPacienteRepository _pacienteRepository { get; set; }

        public PacientesController()
        {
            _pacienteRepository = new PacientesRepository();
        }

        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_pacienteRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet("{idPaciente}")]
        public IActionResult BuscarPorId(int idPaciente)
        {
            try
            {
                return Ok(_pacienteRepository.BuscarPorId(idPaciente));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(Paciente novoPaciente)
        {
            try
            {
                _pacienteRepository.Cadastrar(novoPaciente);

                return StatusCode(201);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(Paciente pacienteAtualizado)
        {
            try
            {
                _pacienteRepository.Atualizar(pacienteAtualizado);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }


        [HttpDelete("deletar/{idUsuario}")]
        public IActionResult Deletar(int idUsuario)
        {
            try
            {
                if (_pacienteRepository.BuscarPorId(idUsuario) == null)
                {
                    return BadRequest(new
                    {
                        mensagem = "Não foi encontrada nenhum paciente com o id informado."
                    });
                }

                if (idUsuario <= 0)
                {
                    return BadRequest(new
                    {
                        mensagem = "Por favor, insira um id válido."
                    });
                }

                _pacienteRepository.Deletar(idUsuario);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

    }
}
