using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoMvc.Models;

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
        public ActionResult Insertar4(PersonaNatural personaNatural)
        {

            return View();
        }
    }
}