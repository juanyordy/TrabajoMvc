using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TrabajoMvc.Models;

namespace TrabajoMvc.Query
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext():base("conexionBase")
        {

        }
        public DbSet<PersonaNatural> PersonasNatural { get; set; }
        public DbSet<PersonaJuridica> PersonasJuridica { get; set; }
    }
}