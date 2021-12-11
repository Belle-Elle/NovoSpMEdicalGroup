using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class PacienteRepository
    {

        
        public void Atualizar(Paciente pacienteAtualizado);
        public Paciente BuscarPorId(int idPaciente);
        public void Cadastrar(Paciente novoPaciente);
        public void Deletar(int idUsuario);
        public List<Paciente> ListarTodos();


    }
}
