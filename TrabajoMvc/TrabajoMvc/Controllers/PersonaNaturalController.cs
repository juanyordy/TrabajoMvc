using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoMvc.Models;
using TrabajoMvc.Query;

namespace TrabajoMvc.Controllers
{
    public class PersonaNaturalController : Controller
    {
        // GET: PersonaNatural
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
        public ActionResult Insertar(PersonaNatural personaNatural)
        {
            QPersonaNatural qPersonaNatural = new QPersonaNatural();
            qPersonaNatural.insertar(personaNatural); 
            return Redirect(Url.Action("PersonaNatural","Insertar"));
        }
    }
}