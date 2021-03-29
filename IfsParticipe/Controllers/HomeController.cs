using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IfsParticipe.Libraries.Email;
using IfsParticipe.Models;
using Microsoft.AspNetCore.Mvc;

namespace IfsParticipe.Controllers
{
    public class HomeController : Controller
    {
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

        [HttpPost]
        public IActionResult Login([FromForm] Usuario usuario )
        {

            if (ModelState.IsValid)
            {

                if (usuario.Login == "teste")
                {
                    HttpContext.Session
                }
                else
                {
                    TempData["MSG_E"] = "Usuário os senha informados incorretos!";
                }
            }
            return View();
        }



    }
}