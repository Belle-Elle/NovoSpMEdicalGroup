using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class ClinicaRepository
    {

        
       
        public void Atualizar(Clinica clinicaAtualizada);

        public Clinica BuscarPorId(int idClinica);

        public void Cadastrar(Clinica novaClinica);

        public void Deletar(int idClinica);

        public List<Clinica> ListarTodas();
    

    }
}
