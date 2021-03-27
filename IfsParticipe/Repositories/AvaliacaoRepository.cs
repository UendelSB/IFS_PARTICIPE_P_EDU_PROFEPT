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
            //verificar se ja existe para fazer apenas a atualizacao da noda do comentatio ou da demanda

            Avaliacao avDem;
            Avaliacao avCom;

            if(avaliacao.Tipo == 'C')
            {
                avCom = ObterTodasAvaliacoes().Where(m => m.IdComentario == avaliacao.IdComentario && m.Tipo == 'C' && m.IdUsuario == avaliacao.IdUsuario).FirstOrDefault();
               if (avCom != null){
                    avCom.DataAtualizacao = avaliacao.DataAtualizacao;
                    avCom.Nota = avaliacao.Nota;
                    Atualizar(avCom);
                    return;
                }

            }
            else {
                avDem = ObterTodasAvaliacoes().Where(m => m.IdDemanda == avaliacao.IdDemanda && m.Tipo =='D' && m.IdUsuario == avaliacao.IdUsuario).FirstOrDefault();
                if (avDem != null)
                {
                    avDem.DataAtualizacao = avaliacao.DataAtualizacao;
                    avDem.Nota = avaliacao.Nota;
                    Atualizar(avDem);
                    return;
                }
           }

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
