using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {



        void Cadastrar(TipoUsuario novoTipo);
        List<TipoUsuario> ListarTodos();
        TipoUsuario BuscarPorId(int idTipo);
        void Atualizar(TipoUsuario tipoAtualizado);
        void Deletar(int idTipo);




    }
}
