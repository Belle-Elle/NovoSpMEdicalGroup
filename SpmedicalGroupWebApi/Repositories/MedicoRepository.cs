using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class MedicoRepository
    {

        public void Atualizar(Medico medicoAtualizado);
        public Medico BuscarPorId(int idMedico);
        public void Cadastrar(Medico novoMedico);
        public void Deletar(int idMedico);
        public List<Medico> ListarTodos();

    }
}
