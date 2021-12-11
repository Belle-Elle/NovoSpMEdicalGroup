using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class EspecialidadeRepository
    {

         public void Atualizar(Especialidades especialidadeAtt);
        public Especialidades BuscarPorId(int idEspecialidade);
        public void Cadastrar(Especialidades novaEspecialidade);
        public void Deletar(int idEspecialidade);
        public List<Especialidades> ListarTodas();

    }
}
