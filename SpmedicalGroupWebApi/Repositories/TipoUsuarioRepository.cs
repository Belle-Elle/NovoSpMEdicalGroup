using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class TipoUsuarioRepository
    {

        
        public void Atualizar(TIpoUsuario tipoAtualizado);
        public TIpoUsuario BuscarPorId(int idTipo);
        public void Cadastrar(TIpoUsuario novoTipo);
        public void Deletar(int idTipo);
        public List<TIpoUsuario> ListarTodos();


    }
}
