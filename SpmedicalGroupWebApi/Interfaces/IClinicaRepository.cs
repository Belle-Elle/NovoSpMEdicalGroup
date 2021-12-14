using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroup_webApi_Proj_Senai.Interfaces
{
    interface IClinicaRepository
    {

        void Cadastrar(Clinica novaClinica);
        List<Clinica> ListarTodas();
        Clinica BuscarPorId(int idClinica);
        void Atualizar(Clinica clinicaAtualizada);
        void Deletar(int idClinica);

    }
}
