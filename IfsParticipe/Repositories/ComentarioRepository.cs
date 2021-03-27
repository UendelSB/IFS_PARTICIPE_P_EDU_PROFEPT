using IfsParticipe.Database;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        private IfsParticipeContext _banco;

        public ComentarioRepository(IfsParticipeContext banco)
        {
            _banco = banco;
        }

        public void Cadastrar(Comentario comentario)
        {
            _banco.Comentario.Add(comentario);
            _banco.SaveChanges();
        }

        public void Atualizar(Comentario comentario)
        {
            _banco.Comentario.Update(comentario);
            _banco.SaveChanges();
        }

        public int Excluir(int Id)
        {
            Comentario comentario = ObterComentario(Id);
            List<Avaliacao> avaliacoes = _banco.Avaliacao.Where(a => a.IdComentario == Id).ToList();

            int idDemanda = comentario.IdDemanda;

            _banco.RemoveRange(avaliacoes);
            _banco.Remove(comentario);
            _banco.SaveChanges();
            return idDemanda;
        }

        public Comentario ObterComentario(int Id)
        {
            return _banco.Comentario.Find(Id);
        }

        public IEnumerable<Comentario> ObterTodosComentarios()
        {
            return _banco.Comentario.ToList();
        }
    }
}
