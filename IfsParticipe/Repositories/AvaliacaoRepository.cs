using IfsParticipe.Database;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        private IfsParticipeContext _banco;

        public AvaliacaoRepository (IfsParticipeContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(Avaliacao avaliacao)
        {
            _banco.Avaliacao.Update(avaliacao);
            _banco.SaveChanges();
        }

        public void Cadastrar(Avaliacao avaliacao)
        {
            _banco.Avaliacao.Add(avaliacao);
            _banco.SaveChanges();
        }

        public Avaliacao ObterAvaliacao(int Id)
        {
            return _banco.Avaliacao.Find(Id);
        }

        public IEnumerable<Avaliacao> ObterTodasAvaliacoes()
        {
            return _banco.Avaliacao.ToList();
        }
    }
}
