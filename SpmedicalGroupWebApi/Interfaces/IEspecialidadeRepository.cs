using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IEspecialidadeRepository
    {

         
         

           void Cadastrar(Especialidades novaEspecialidade);
           List<Especialidades> ListarTodas();
           Especialidades BuscarPorId(int idEspecialidade);
           void Atualizar(Especialidades especialidadeAtt);
           void Deletar(int idEspecialidade);

         

    }
}
