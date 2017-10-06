using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Query
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext():base("pruebaConexion")
        {

        }
        
    }
}