using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoMvc.Models;
using TrabajoMvc.Query;

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
        public ActionResult Insertar(PersonaJuridica personaJuridica)
        {
            QPersonaJuridica qPersonaJuridica = new QPersonaJuridica();
            qPersonaJuridica.insertar(personaJuridica);
            return Redirect(Url.Action("PersonaJuridica", "Insertar"));
        }
    }
}
