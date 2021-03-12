using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using IfsParticipe.Models;

namespace IfsParticipe.Repositories
{
    public class PdiRepository : IPdiRepository
    {
        private IfsParticipeContext _banco;

        public PdiRepository(IfsParticipeContext banco)
        {
            _banco = banco;
        }

        public void Atualizar(PDI pdi)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(PDI pdi)
        {
            _banco.PDI.Add(pdi);
            _banco.SaveChanges();
        }

        public void Excluir(int Id)
        {
            _banco.Remove(ObterPDI(Id));
            _banco.SaveChanges();
        }

        public PDI ObterPDI(int Id)
        {
          return _banco.PDI.Find(Id);
        }

        public List<PDI> ObterTodosPDIs()
        {
           return _banco.PDI.ToList();
        }

        //Para fazer semelhante a um select
        //  _banco.PDI.Where(m => m.DataIniVig >= DateTime.Now && DateTime.Now <= m.DataFimVig).First();



    }
}
