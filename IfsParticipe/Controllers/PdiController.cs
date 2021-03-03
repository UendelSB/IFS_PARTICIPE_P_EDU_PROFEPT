using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IfsParticipe.Controllers
{
    public class PdiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroPDI()
        {
            return View();
        }
    }
}