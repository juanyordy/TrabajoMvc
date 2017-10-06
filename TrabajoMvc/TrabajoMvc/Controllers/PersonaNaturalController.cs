using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrabajoMvc.Models;
using TrabajoMvc.Query;
using TrabajoMvc.Vmodel;

namespace TrabajoMvc.Controllers
{
    public class PersonaNaturalController : Controller
    {
        // GET: PersonaNatural
        [HttpGet]
        public ActionResult Index()
        {
            QPersonaNatural qpersonaNatural = new QPersonaNatural();
            VmPersonaNatural vmPersonaNatural = new VmPersonaNatural();
            vmPersonaNatural.listaPersonaNatural = qpersonaNatural.Listar(); 
            return View(vmPersonaNatural);
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

        [HttpGet]
        public ActionResult Editar(string dni)
        {
            QPersonaNatural qpersonaNatural = new QPersonaNatural();

            VmPersonaNatural vmPersonaNatural =new  VmPersonaNatural();
            qpersonaNatural.Editar(dni);

            return View(vmPersonaNatural);
        }
        [HttpPost]
        public ActionResult Editar(PersonaNatural personaNatural)
        {
            QPersonaNatural qPerosnaNatural = new QPersonaNatural();
            //qPerosnaNatural.Editar(personaNatural);
            return Redirect(Url.Action("PersonaNatural", "Editar"));
        }

    }
}