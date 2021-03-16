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
            _banco.Remove(ObterDemanda(Id));
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
