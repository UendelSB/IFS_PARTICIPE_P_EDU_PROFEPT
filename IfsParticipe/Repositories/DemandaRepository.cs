using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;

namespace IfsParticipe.Repositories
{
    public class DemandaRepository : IDemandaRepository
    {

        private IfsParticipeContext _banco;

        public DemandaRepository(IfsParticipeContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Demanda demanda)
        {
            _banco.Demanda.Update(demanda);
            _banco.SaveChanges();
        }

        public void Cadastrar(Demanda demanda)
        {
            _banco.Demanda.Add(demanda);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            Demanda demanda = ObterDemanda(Id);
            List<Avaliacao> avaliacoes = _banco.Avaliacao.Where(a => a.IdDemanda == Id).ToList();
            List<Comentario> comentarios = _banco.Comentario.Where(a => a.IdDemanda == Id).ToList();

            _banco.RemoveRange(avaliacoes);
            _banco.RemoveRange(comentarios);
            _banco.Remove(demanda);
            _banco.SaveChanges();
        }

        public Demanda ObterDemanda(int Id)
        {
            return _banco.Demanda.Find(Id);
        }

       public IEnumerable<Demanda> ObterTodasDemandas()
        {
            return _banco.Demanda.ToList();
        }
    }
}
