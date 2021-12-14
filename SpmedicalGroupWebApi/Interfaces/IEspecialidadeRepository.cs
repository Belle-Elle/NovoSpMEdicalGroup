using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        void Cadastrar(Especialidade novaEspecialidade);
        List<Especialidade> ListarTodas();
        Especialidade BuscarPorId(int idEspecialidade);
        void Atualizar(Especialidade especialidadeAtt);
        void Deletar(int idEspecialidade);



    }
}