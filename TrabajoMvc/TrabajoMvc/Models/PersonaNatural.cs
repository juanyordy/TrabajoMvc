using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Models
{
    [Table("PersonaNatural")]
    public class PersonaNatural : Persona
    {
        [Key]
        public string dni { get; set; }
        public string apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public bool sexo { get; set; }
    }
}