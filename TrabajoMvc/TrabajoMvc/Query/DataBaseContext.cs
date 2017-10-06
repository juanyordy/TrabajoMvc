using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Query
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext():base("conexionBase")
        {

        }
        DbSet<QPersonaNatural> PersonasNatural { get; set; }
        DbSet<QPersonaJuridica> PersonasJuridica { get; set; }
    }
}