using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Libraries;
using IfsParticipe.Libraries.Email;
using IfsParticipe.Models;
using IfsParticipe.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IfsParticipe.Controllers
{
    public class HomeController : Controller
    {
        private IUsuarioRepository _repositoryUsuario;
        private LoginUsuario _loginUsuario;

        public HomeController(IUsuarioRepository repositoryUsuario, LoginUsuario loginUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
            _loginUsuario = loginUsuario;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AcessoNegado()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            _loginUsuario.Logout();
            return RedirectToAction(nameof(Login));
        }

        [HttpPost]
        public IActionResult Login([FromForm] Usuario usuario )
        {
            Usuario usuarioDb;
            if (ModelState.IsValid)
            {
                try
                {
                    usuarioDb = _repositoryUsuario.Login(usuario.Login, usuario.Senha);

                    if (usuarioDb != null)
                    {
                        _loginUsuario.Login(usuarioDb);
                        return new RedirectResult(Url.Action("Index", "Demanda"));
                    } else{
                    TempData["MSG_E"] = "Usuário não encontrado, verifique o Login e Senha digitado!";
                }
              
                } catch(Exception e)
                {

                    TempData["MSG_E"] = e.Message;
                        //"Ops! Tivemos um erro, tente novamente mais tarde!";
                }

            }
            return View(usuario);
        }



    }
}