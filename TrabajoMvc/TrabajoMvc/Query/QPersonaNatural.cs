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
        public PersonaNatural Editar(string dni)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                return dbc.PersonasNatural.First(p => p.dni == dni);
            }
        }

        public bool Eliminar(PersonaNatural t)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                dbc.PersonasNatural.First(p => p.dni == t.dni);
                return true;
            }
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
            using (DataBaseContext dbc = new DataBaseContext())
            {
                return dbc.PersonasNatural.ToList();
            }
        }
    }
}