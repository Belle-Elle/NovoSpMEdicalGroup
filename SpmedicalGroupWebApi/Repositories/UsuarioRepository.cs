using Microsoft.AspNetCore.Http;
using SpmedicalGroupWebApi.Domains;
using SpmedicalGroupWebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public string ConsultarPerfilDir(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void SalvarPerfilDir(IFormFile foto, int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
