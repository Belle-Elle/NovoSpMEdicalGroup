using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IPacienteRepository
    {



        void Cadastrar(Paciente novoPaciente);
        List<Paciente> ListarTodos();
        Paciente BuscarPorId(int idPaciente);
        void Atualizar(Paciente pacienteAtualizado);
        void Deletar(int idUsuario);



    }
}
