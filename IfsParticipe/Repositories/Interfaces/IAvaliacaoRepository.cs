using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories.Interfaces
{
   public interface IAvaliacaoRepository
    {

        void Cadastrar(Avaliacao avaliacao);

        void Atualizar(Avaliacao avaliacao);

        IEnumerable<Avaliacao> ObterTodasAvaliacoes();
        Avaliacao ObterAvaliacao(int Id);
    }
}
