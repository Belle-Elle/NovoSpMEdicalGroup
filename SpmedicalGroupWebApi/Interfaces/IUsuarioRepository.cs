using Microsoft.AspNetCore.Http;
using SpmedicalGroupWebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpmedicalGroupWebApi.Interfaces
{
    interface IUsuarioRepository
    {
        Usuario Login(string email, string senha);
        void Cadastrar(Usuario novoUsuario);
        List<Usuario> ListarTodos();
        Usuario BuscarPorId(int idUsuario);
        void Atualizar(Usuario usuarioAtualizado);
        void Deletar(int idUsuario);

        void SalvarPerfilDir(IFormFile foto, int idUsuario);
        string ConsultarPerfilDir(int idUsuario);



    }
}