using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Models
{
    public class PersonaJuridica : Persona
    {
        public string ruc { get; set; }
        public string urlPaginaWeb { get; set; }
    }
}