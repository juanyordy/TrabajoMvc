using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Models
{
    [Table("PersonaJuridica")]
    public class PersonaJuridica : Persona
    {
        [Key]
        public string ruc { get; set; }
        public string urlPaginaWeb { get; set; }
    }
}