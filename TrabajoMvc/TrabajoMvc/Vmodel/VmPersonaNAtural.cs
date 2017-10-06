using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoMvc.Models;

namespace TrabajoMvc.Vmodel
{
    public class VmPersonaNatural
    {
        public PersonaNatural personaNatural { get; set; }
        public List<PersonaNatural> listaPersonaNatural { get; set; }
    }
}