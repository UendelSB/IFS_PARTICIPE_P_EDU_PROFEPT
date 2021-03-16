using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories.Interfaces
{
    public interface IDemandaRepository
    {

        void Cadastrar(Demanda demanda);
        void Atualizar(Demanda demanda);
        void Excluir  (int Id);
        Demanda ObterDemanda(int Id);
        IEnumerable<Demanda> ObterTodasDemandas();

    }
}
