using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IfsParticipe.Controllers
{
    public class DemandaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult DetalharDemanda()
        {
            return View();
        }

        public ActionResult NovaDemanda()
        {
            return View();
        }


    }
}