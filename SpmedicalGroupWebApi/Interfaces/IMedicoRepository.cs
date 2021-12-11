using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IMedicoRepository
    {

        
           void Cadastrar(Medico novoMedico);
           List<Medico> ListarTodos();
           Medico BuscarPorId(int idMedico);
           void Atualizar(Medico medicoAtualizado);
           void Deletar(int idMedico);

         

    }
}
