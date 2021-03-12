using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using IfsParticipe.Models;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using IfsParticipe.Database;
using IfsParticipe.Repositories;

namespace IfsParticipe.Controllers
{
    public class PdiController : Controller
    {
        private IPdiRepository _repository;

        public PdiController(IPdiRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult CadastroPDI()
        {
            PDI model = new PDI{SituacaoList = BindSituacaoList() };

            return View(model); 

        }

        private List<SelectListItem> BindSituacaoList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "1", Text = "Aberto para novas demandas" });
            list.Add(new SelectListItem() { Value = "2", Text = "Fechado para novas demandas" });
            return list;
        }

        [HttpPost]
        public IActionResult CadastrarPDI([FromForm]PDI pdi)
        {
            try {

                pdi.SituacaoList = BindSituacaoList();
                pdi.DataCadastro = DateTime.Now;
                pdi.DataAtualizacao = DateTime.Now;
                pdi.IdUsuario = 123; 

               if(ModelState.IsValid){

                    _repository.Cadastrar(pdi);
                    TempData["MSG_S"] = "PDI cadastrado com sucesso!";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch(Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View(nameof(CadastroPDI), pdi);
        }


        public IActionResult AlterarPDI()
        {
            return View();
        }


        
    }
}