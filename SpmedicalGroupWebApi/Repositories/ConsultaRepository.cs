using SpmedicalGroupWebApi.Domains;
using SpmedicalGroupWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void AddDescricao(int idConsulta, string descricao, int id)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Consultum consultaAtt)
        {
            throw new NotImplementedException();
        }

        public Consultum BuscarPorId(int idConsulta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consultum novaConsulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idConsulta)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarMinhasMedico(int idMedico)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarMinhasPaciente(int idPaciente)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarTodas()
        {
            throw new NotImplementedException();
        }

        public void MudarSituacao(int idConsulta, string status)
        {
            throw new NotImplementedException();
        }
    }
}
