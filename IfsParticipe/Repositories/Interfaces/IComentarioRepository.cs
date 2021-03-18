using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories.Interfaces
{
    public interface IComentarioRepository
    {
        void Cadastrar(Comentario comentario);
        void Atualizar(Comentario comentario);
        int Excluir(int Id);
        IEnumerable<Comentario> ObterTodosComentarios();
        Comentario ObterComentario(int Id);
    }
}
