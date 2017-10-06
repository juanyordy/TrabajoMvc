using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoMvc.Models;

namespace TrabajoMvc.Controllers
{
    public class PersonaJuridicaController : Controller
    {
        // GET: PersonaJuridica
      
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insertar4(PersonaJuridica personaJuridica)
        {

            return View();
        }
    }
}
