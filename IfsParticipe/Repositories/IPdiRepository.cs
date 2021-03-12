using IfsParticipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IfsParticipe.Repositories
{
    public interface IPdiRepository
    {

        void Cadastrar(PDI pdi);
        void Atualizar(PDI pdi);
        void Excluir(int Id);
        PDI  ObterPDI(int Id);
        List<PDI> ObterTodosPDIs();

    }
}
