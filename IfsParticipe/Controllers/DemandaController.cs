using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using IfsParticipe.Libraries;
using IfsParticipe.Libraries.Filtro;
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
        private IComentarioRepository _repositoryComentario;
        private IAvaliacaoRepository _repositoryAvaliacao;
        private LoginUsuario _loginUsuario;



        public DemandaController(IDemandaRepository repositoryDemanda, IPdiRepository repositoryPdi, IComentarioRepository repositoryComentario, IAvaliacaoRepository repositoryAvaliacao, LoginUsuario loginUsuario)
        {
            _repositoryDemanda = repositoryDemanda;
            _repositoryPdi = repositoryPdi;
            _repositoryComentario = repositoryComentario;
            _repositoryAvaliacao = repositoryAvaliacao;
            _loginUsuario = loginUsuario;

        }

        //D=DISCENTE C= COLABORADOR
        [HttpGet]
        [UsuarioAutorizacao("D,C")]
        public IActionResult Index()
        {
            try
            {
                PDI pdiVigente = _repositoryPdi.ObterTodosPDIs().Where(m => (DateTime.Now >= m.DataIniVig && DateTime.Now <= m.DataFimVig) && m.Situacao == 1).FirstOrDefault();
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
                            dem.CountComent = _repositoryComentario.ObterTodosComentarios().Where(c => c.IdDemanda == dem.Id).Count();
                            dem.CountAva = _repositoryAvaliacao.ObterTodasAvaliacoes().Where(a => a.Tipo == 'D' && a.IdDemanda == dem.Id).Sum(i => i.Nota);
                        }

                        Usuario usu = _loginUsuario.GetUsuario();
                        if(usu.Tipo == 'C')
                        {//new { d.CountAva, d.CountComent }
                            demandas = demandas.OrderByDescending(d => d.CountAva).ThenByDescending(d => d.CountComent).ToList();
                        }
                        else
                        {
                            demandas = demandas.OrderByDescending(d => d.DataAtualizacao).ThenByDescending(d => d.DataAtualizacao.TimeOfDay).ToList();
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
                    var msgValidPeri = TempData["MSG_E"];
                    if (msgValidPeri != null)
                        TempData["MSG_E"] = msgValidPeri;
                    else
                    TempData["MSG_E"] = "Nenhum PDI vigente foi encontrado!";
                }
            }catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return View();

        }

        [HttpGet]
        [UsuarioAutorizacao("D,C")]
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
                else
                {
                    //avaliacoes da demanda
                    var avalDemanda = _repositoryAvaliacao.ObterTodasAvaliacoes().Where(a => a.Tipo == 'D' && a.IdDemanda == demandaModel.Id).ToList();
                    demandaModel.Avaliacoes = avalDemanda;
                    demandaModel.CountAva = avalDemanda.Sum(i => i.Nota);

                    //avaliacoes dos comentarios
                    detalheVM.ComentarioList = _repositoryComentario.ObterTodosComentarios().Where(m => m.IdDemanda == Id).ToList();

                    foreach (var c in detalheVM.ComentarioList)
                    {
                        var avalComent = _repositoryAvaliacao.ObterTodasAvaliacoes().Where(a => a.Tipo == 'C' && a.IdComentario == c.Id).ToList();
                        c.Avaliacoes = avalComent;
                        c.CountAva = avalComent.Sum(i => i.Nota);
                    }

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
        [UsuarioAutorizacao("D")]
        public ActionResult NovaDemanda()
        {

            PDI pdiVigente = _repositoryPdi.ObterTodosPDIs().Where(m => (DateTime.Now >= m.DataIniVig && DateTime.Now <= m.DataFimVig) &&
                                                                        (DateTime.Now >= m.DataIniRecDem && DateTime.Now <= m.DataFimVig) &&
                                                                         m.Situacao == 1).FirstOrDefault();

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
        [UsuarioAutorizacao("D")]
        public IActionResult CadastrarDemanda([FromForm]Demanda demanda)
        {
            try
            {

                demanda.CategoriaList = BindCategoriaList();

                if (ModelState.IsValid)
                {
                    demanda.DataCadastro = DateTime.Now;
                    demanda.DataAtualizacao = DateTime.Now;
                    demanda.IdUsuario = _loginUsuario.GetUsuario().Id;
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
        [UsuarioAutorizacao("D,C")]
        public IActionResult AlterarDemanda([FromForm]Demanda demanda)
        {

            try
            {
                demanda.CategoriaList = BindCategoriaList();
                demanda.SituacaoList = BindSituacaoList();
                demanda.DataAtualizacao = DateTime.Now;
                demanda.IdUsuario = _loginUsuario.GetUsuario().Id; 

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
        [UsuarioAutorizacao("D,C")]
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
        [UsuarioAutorizacao("D")]
        public IActionResult CadastrarComentario([FromForm] DetalheDemandaViewModel demandaCom)
        {

            try
            {
                demandaCom.Comentario.DataAtualizacao = DateTime.Now;
                demandaCom.Comentario.DataCadastro = DateTime.Now;
                demandaCom.Comentario.IdUsuario = _loginUsuario.GetUsuario().Id; ;
             
                if (ModelState.IsValid)
                {
                    _repositoryComentario.Cadastrar(demandaCom.Comentario);
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

        
        [HttpGet]
        [UsuarioAutorizacao("D,C")]
        public IActionResult RemoverComentario(int Id)
        {
            //TODO permitir a exclusao logica para que as demandas nao sejam excluidas
            Comentario model = new Comentario();
            try
            {
                 model.IdDemanda =  _repositoryComentario.Excluir(Id);

                TempData["MSG_S"] = "Comentario removido com sucesso!";
            }
            catch (Exception e)
            {

                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return RedirectToAction("DetalharDemanda", "Demanda", new { id = model.IdDemanda });

        }


        [HttpGet]
        [UsuarioAutorizacao("D,C")]
        public IActionResult RemoverDemanda(int Id)
        {

            try
            {
                _repositoryDemanda.Excluir(Id);
                TempData["MSG_S"] = "Demanda excluida com sucesso!";
            }
            catch (Exception e)
            {

                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        [UsuarioAutorizacao("D")]
        public JsonResult AvaliarDemandaComentario(Avaliacao avaliacao)
        {
            //TODO implementar usuario
            avaliacao.DataAtualizacao = DateTime.Now;
            avaliacao.IdUsuario = _loginUsuario.GetUsuario().Id; 
            
            try
            {
                _repositoryAvaliacao.Cadastrar(avaliacao);

                if (avaliacao.Tipo == 'C')
                    avaliacao.SomaNotas = _repositoryAvaliacao.ObterTodasAvaliacoes().Where(a => a.Tipo =='C' && a.IdComentario == avaliacao.IdComentario).Sum(i => i.Nota);
                else
                    avaliacao.SomaNotas = _repositoryAvaliacao.ObterTodasAvaliacoes().Where(a => a.Tipo == 'D' && a.IdDemanda == avaliacao.IdDemanda).Sum(i => i.Nota);
            }
            catch (Exception e)
            {
                TempData["MSG_E"] = "Ops! Tivemos um erro, tente novamente mais tarde!";
            }

            return Json(avaliacao);

        }



    }
}