using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfsParticipe.Controllers
{
    public class ProdutoController : Controller
    {
        public ActionResult Visualizar ()
        {
          Produto produto =  GetProduto();

            return View(produto);
        }

        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome = "xbox one X",
                Descricao = "Jogue em 4k",
                Valor = 2000.00M
            };
        }

    }
}