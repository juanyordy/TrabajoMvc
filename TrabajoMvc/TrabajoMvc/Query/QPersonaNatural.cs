using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoMvc.Interface;
using TrabajoMvc.Models;

namespace TrabajoMvc.Query
{
    public class QPersonaNatural : IGeneric<PersonaNatural>
    {
        public bool Editar(PersonaNatural t)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(PersonaNatural t)
        {
            throw new NotImplementedException();
        }

        public bool insertar(PersonaNatural t)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                
                 dbc.PersonasNatural.Add(t);
                dbc.SaveChanges();
                return true;
            }
        }

        public List<PersonaNatural> Listar()
        {
            throw new NotImplementedException();
        }
    }
}