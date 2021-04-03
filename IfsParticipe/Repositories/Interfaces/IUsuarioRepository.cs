using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario Login(string login, string senha);
        Usuario ObterUsuario(int Id);

    }
}
