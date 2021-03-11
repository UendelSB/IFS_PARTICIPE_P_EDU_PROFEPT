using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Database;
using IfsParticipe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IfsParticipe.Controllers
{
    public class DemandaController : Controller
    {

        private IfsParticipeContext banco;
        public DemandaController(IfsParticipeContext bancoContext)
        {
            banco = bancoContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DetalharDemanda()
        {
            return View();
        }

        [HttpGet]
        public ActionResult NovaDemanda()
        {
            Demanda model = new Demanda { CategoriaList = BindCategoriaList() };

            return View(model);
        }

        [HttpPost]
        public IActionResult CadastrarDemanda([FromForm]Demanda demanda)
        {
            try
            {

                demanda.CategoriaList = BindCategoriaList();

                if (ModelState.IsValid)
                {

                    banco.Demanda.Add(demanda);
                    banco.SaveChanges();
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


        public ActionResult AlterarDemanda()
        {
            return View();
        }

    }
}