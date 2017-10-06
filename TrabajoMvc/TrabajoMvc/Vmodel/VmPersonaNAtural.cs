using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoMvc.Models;

namespace TrabajoMvc.Vmodel
{
    public class VmPersonaNatural
    {
        public PersonaNatural personaJuridica { get; set; }
        public List<PersonaNatural> listaPersonaJuridica { get; set; }
    }
}