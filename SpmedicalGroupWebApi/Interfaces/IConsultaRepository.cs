using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IConsultaRepository
    {
        void Cadastrar(Consultum novaConsulta);
        List<Consultum> ListarTodas();
        Consultum BuscarPorId(int idConsulta);
        void Atualizar(Consultum consultaAtt);
        void Deletar(int idConsulta);
        List<Consultum> ListarMinhasPaciente(int idPaciente);
        List<Consultum> ListarMinhasMedico(int idMedico);
        void AddDescricao(int idConsulta, string descricao, int id);
        void MudarSituacao(int idConsulta, string status);



    }
}