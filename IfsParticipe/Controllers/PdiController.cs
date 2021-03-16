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
using IfsParticipe.Repositories.Interfaces;

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

           List<PDI> pdis =  _repository.ObterTodosPDIs().ToList();
            foreach (var pdi in pdis)
            {
                pdi.SituacaoList = BindSituacaoList();
            }

            return View(pdis);
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


        [HttpPost]
        public IActionResult AlterarPDI([FromForm]PDI pdi)
        {

            try
            {

                pdi.SituacaoList = BindSituacaoList();
                pdi.DataAtualizacao = DateTime.Now;
                pdi.IdUsuario = 123;

                if (ModelState.IsValid)
                {
                    _repository.Atualizar(pdi);
                    TempData["MSG_S"] = "PDI alterado com sucesso!";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View(nameof(AlterarPDI), pdi);

        }

        [HttpGet]
        public IActionResult AlterarPDI(int Id)
        {
            PDI model = new PDI();
            try
            {
                 model = _repository.ObterPDI(Id);
                if (model is null)
                {
                    TempData["MSG_E"] = "Ops! Não Localizamos a informação solicitada";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            model.SituacaoList = BindSituacaoList();
            return View(model);

        }

        [HttpGet]
        public IActionResult RemoverPDI(int Id)
        {
            //TODO permitir a exclusao logica para que as demandas nao sejam excluidas
            PDI model = new PDI();
            try
            {
               _repository.Excluir(Id);
               TempData["MSG_S"] = "PDI removido com sucesso!";
             }catch (Exception e){

                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return RedirectToAction(nameof(Index));

        }


    }
}