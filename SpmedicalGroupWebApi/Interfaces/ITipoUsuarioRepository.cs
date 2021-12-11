using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface ITipoUsuarioRepository
    {

        

            void Cadastrar(TIpoUsuario novoTipo);
            List<TIpoUsuario> ListarTodos();
            TIpoUsuario BuscarPorId(int idTipo);
            void Atualizar(TIpoUsuario tipoAtualizado);
            void Deletar(int idTipo);


          

    }
}
