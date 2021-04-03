using IfsParticipe.Database;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private IfsParticipeContext _banco;

        public UsuarioRepository(IfsParticipeContext banco)
        {
            _banco = banco;
        }

        public Usuario Login(string login, string senha)
        {
            Usuario usuario = _banco.Usuario.Where(m => m.Login == login && m.Senha == senha).FirstOrDefault();
            return usuario;
        }

        public Usuario ObterUsuario(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
