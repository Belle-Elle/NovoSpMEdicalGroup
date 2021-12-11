using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class ConsultaRepository
    {

        
        public void AddDescricao(int idConsulta, string descricao, int id);
        public void Atualizar(Consultas consultaAtt);
        public Consultum BuscarPorId(int idConsulta);
        public void Cadastrar(Consultum novaConsulta);
        public void Deletar(int idConsulta);
        public List<Consultas> ListarMinhasPaciente(int idPaciente);
        public List<Consultas> ListarTodas();
        public void MudarSituacao(int idConsulta, string status);

    }
}
