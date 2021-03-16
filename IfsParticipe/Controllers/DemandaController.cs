using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IfsParticipe.Controllers
{
    public class DemandaController : Controller
    {


        private IDemandaRepository _repositoryDemanda;
        private IPdiRepository _repositoryPdi;
     

        public DemandaController(IDemandaRepository repositoryDemanda, IPdiRepository repositoryPdi)
        {
            _repositoryDemanda = repositoryDemanda;
            _repositoryPdi = repositoryPdi;

        }


        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                PDI pdiVigente = _repositoryPdi.ObterTodosPDIs().Where(m => DateTime.Now >= m.DataIniVig && DateTime.Now <= m.DataFimVig).FirstOrDefault();
                IEnumerable<Demanda> demandas;

                if (pdiVigente != null)
                {

                    demandas = _repositoryDemanda.ObterTodasDemandas().Where(m => m.IdPDI == pdiVigente.Id);

                    if (demandas.Count() >0)
                    {
                        foreach (var dem in demandas)
                        {
                            dem.SituacaoList = BindSituacaoList();
                            dem.CategoriaList = BindCategoriaList();
                        }

                        return View(demandas);
                    }
                    else
                    {
                        TempData["MSG_E"] = "Nenhuma demanda encontrada para o PDI vigente!";
                    }

                }
                else
                {
                    TempData["MSG_E"] = "Nenhum PDI vigente foi encontrado!";
                }
            }catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View();

        }

        [HttpGet]
        public ActionResult DetalharDemanda(int Id)
        {
            DetalheDemandaViewModel detalheVM = new DetalheDemandaViewModel();
            Demanda demandaModel = new Demanda();
            try
            {
                demandaModel = _repositoryDemanda.ObterDemanda(Id);
                
                if (demandaModel is null)
                {
                    TempData["MSG_E"] = "Ops! Não Localizamos a informação solicitada";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            demandaModel.CategoriaList = BindCategoriaList();
            demandaModel.SituacaoList = BindSituacaoList();

            detalheVM.Demanda = demandaModel;
            var com = TempData["COMENTARIO"];
            if (com != null)
            detalheVM.Comentario = new Comentario() {IdDemanda =(int)com };
            return View(detalheVM);
        }

        [HttpGet]
        public ActionResult NovaDemanda()
        {

            PDI pdiVigente = _repositoryPdi.ObterTodosPDIs().Where(m => (DateTime.Now >= m.DataIniVig && DateTime.Now <= m.DataFimVig) &&
                                                                        (DateTime.Now >= m.DataIniRecDem && DateTime.Now <= m.DataFimVig)).FirstOrDefault();

            if (pdiVigente != null)
            {

                Demanda model = new Demanda { CategoriaList = BindCategoriaList() };
                model.IdPDI = pdiVigente.Id;
                //situacao demanda
                //1 - Enviada
                //2 - Incluida no PDI
                //3 - Em Execução
                //4 - Desconsiderada
                //5 - Finalizada
                model.Situacao = 1;

                return View(model);
            }
            else
            {
                TempData["MSG_E"] = "Nenhum PDI vigente, aberto para recebimento de novas demandas, foi encontrado!";
                return RedirectToAction(nameof(Index));
            }

        }


        [HttpPost]
        public IActionResult CadastrarDemanda([FromForm]Demanda demanda)
        {
            try
            {

                demanda.CategoriaList = BindCategoriaList();

                if (ModelState.IsValid)
                {
                    demanda.DataCadastro = DateTime.Now;
                    demanda.DataAtualizacao = DateTime.Now;
                    _repositoryDemanda.Cadastrar(demanda);
                    TempData["MSG_S"] = "Demanda enviada com sucesso!";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View("NovaDemanda", demanda);
        }


        private List<SelectListItem> BindCategoriaList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "1", Text = "Infraestrutura e Instalações Escolar" });
            list.Add(new SelectListItem() { Value = "2", Text = "Pedagógico (cursos, atividades e curriculo)" });
            list.Add(new SelectListItem() { Value = "3", Text = "Atendimento Escolar" });

            return list;
        }


        private List<SelectListItem> BindSituacaoList()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            list.Add(new SelectListItem() { Value = "1", Text = "Enviada" });
            list.Add(new SelectListItem() { Value = "2", Text = "Incluida no PDI" });
            list.Add(new SelectListItem() { Value = "3", Text = "Em Execução" });
            list.Add(new SelectListItem() { Value = "4", Text = "Desconsiderada" });
            list.Add(new SelectListItem() { Value = "5", Text = "Finalizada" });

            return list;
        }


        [HttpPost]
        public IActionResult AlterarDemanda([FromForm]Demanda demanda)
        {

            try
            {
                demanda.CategoriaList = BindCategoriaList();
                demanda.SituacaoList = BindSituacaoList();
                demanda.DataAtualizacao = DateTime.Now;
                //TODO implementar registro usuario
                demanda.IdUsuario = 123;

                if (ModelState.IsValid)
                {
                    _repositoryDemanda.Atualizar(demanda);
                    TempData["MSG_S"] = "Demanda alterada com sucesso!";
                    return RedirectToAction("DetalharDemanda","Demanda", new { id = demanda.Id },"#"+ demanda.Id);
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View(nameof(AlterarDemanda), demanda);

        }

        [HttpGet]
        public IActionResult AlterarDemanda(int Id)
        {

            Demanda demandaModel = new Demanda();
            try
            {
                demandaModel = _repositoryDemanda.ObterDemanda(Id);
                if (demandaModel is null)
                {
                    TempData["MSG_E"] = "Ops! Não Localizamos a informação solicitada";
                    return RedirectToAction(nameof(Index));
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            demandaModel.CategoriaList = BindCategoriaList();
            demandaModel.SituacaoList = BindSituacaoList();
            return View(demandaModel);

        }


        [HttpPost]
        public IActionResult CadastrarComentario([FromForm] DetalheDemandaViewModel demandaCom)
        {

            try
            {
                //demanda.CategoriaList = BindCategoriaList();
                //demanda.SituacaoList = BindSituacaoList();
                //demanda.DataAtualizacao = DateTime.Now;
                ////TODO implementar registro usuario
                //demanda.IdUsuario = 123;

                if (ModelState.IsValid)
                {
                   // _repositoryDemanda.Atualizar(demanda);
                    TempData["MSG_S"] = "Comentario enviado com sucesso!";
                }
                else
                {
                    TempData["COMENTARIO"] = demandaCom.Comentario.IdDemanda;
                }

            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return RedirectToAction("DetalharDemanda", "Demanda", new { id = demandaCom.Comentario.IdDemanda });

        }



    }
}