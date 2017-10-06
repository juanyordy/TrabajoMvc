using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Models
{
    public class PersonaNatural : Persona
    {
        public string apellido { get; set; }
        public string dni { get; set; }
        public string fechaNacimiento { get; set; }
        public bool sexo { get; set; }
    }
}