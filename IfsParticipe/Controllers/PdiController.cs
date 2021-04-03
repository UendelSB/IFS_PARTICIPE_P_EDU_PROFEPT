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
using IfsParticipe.Libraries.Filtro;
using IfsParticipe.Libraries;

namespace IfsParticipe.Controllers
{
    public class PdiController : Controller
    {
        private IPdiRepository _repository;
        private LoginUsuario _loginUsuario;

        public PdiController(IPdiRepository repository,LoginUsuario loginUsuario)
        {
            _repository = repository;
            _loginUsuario = loginUsuario;
        }


        [HttpGet]
        [UsuarioAutorizacao("D,C")]
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
        [UsuarioAutorizacao("C")]
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
        [UsuarioAutorizacao("C")]
        public IActionResult CadastrarPDI([FromForm]PDI pdi)
        {
            try {

                pdi.SituacaoList = BindSituacaoList();
                pdi.DataCadastro = DateTime.Now;
                pdi.DataAtualizacao = DateTime.Now;
                pdi.IdUsuario = _loginUsuario.GetUsuario().Id; 

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
        [UsuarioAutorizacao("C")]
        public IActionResult AlterarPDI([FromForm]PDI pdi)
        {

            try
            {

                pdi.SituacaoList = BindSituacaoList();
                pdi.DataAtualizacao = DateTime.Now;
                pdi.IdUsuario = _loginUsuario.GetUsuario().Id; ;

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
        [UsuarioAutorizacao("C")]
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
        [UsuarioAutorizacao("C")]
        public IActionResult RemoverPDI(int Id)
        {
            //TODO permitir a exclusao logica para que as demandas nao sejam excluidas

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