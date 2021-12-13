using SpmedicalGroupWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        public void Atualizar(Usuario usuarioAtualizado);
        public Usuario BuscarPorId(int idUsuario);
        public void Cadastrar(Usuario novoUsuario);
        public string ConsultarPerfilDir(int idUsuario);
        public void Deletar(int idUsuario);
        public List<Usuario> ListarTodos();
        public Usuario Login(string email, string senha);
        public void SalvarPerfilDir(IFormFile foto, int idUsuario);

    }
}
