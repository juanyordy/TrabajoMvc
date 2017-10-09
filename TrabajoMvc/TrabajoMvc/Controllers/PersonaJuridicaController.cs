using System.Web.Mvc;
using TrabajoMvc.Models;
using TrabajoMvc.Query;
using TrabajoMvc.Vmodel;

namespace TrabajoMvc.Controllers
{
    public class PersonaJuridicaController : Controller
    {
        // GET: PersonaJuridica
      
        public ActionResult Index()
        {
            QPersonaJuridica qpersonaJuridica = new QPersonaJuridica();
            VmPersonaJuridica vmPersonaNatural = new VmPersonaJuridica();
            vmPersonaNatural.listaPersonaJuridica = qpersonaJuridica.Listar();
            return View(vmPersonaNatural);
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

        [HttpGet]
        public ActionResult Editar(string dni)
        {
            QPersonaJuridica qpersonaJuridica = new QPersonaJuridica();

            VmPersonaNatural vmPersonaJuridica = new VmPersonaNatural();
            qpersonaJuridica.Editar(dni);

            return View(vmPersonaJuridica);
        }

        [HttpPost]
        public ActionResult Editar(PersonaJuridica personaJuridica)
        {
            QPersonaJuridica qPerosnaJuridica = new QPersonaJuridica();
            
            return Redirect(Url.Action("PersonaJuridica", "Editar"));
        }
    }
}