
using System.Collections.Generic;
using TrabajoMvc.Models;

namespace TrabajoMvc.Vmodel
{
    public class VmPersonaJuridica
    {
        public PersonaJuridica personaJuridica { get; set; }
        public List<PersonaJuridica> listaPersonaJuridica { get; set; } 
    }
}