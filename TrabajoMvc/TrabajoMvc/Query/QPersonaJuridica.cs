using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoMvc.Interface;
using TrabajoMvc.Models;

namespace TrabajoMvc.Query
{
    public class QPersonaJuridica : IGeneric<PersonaJuridica>
    {
        public bool Editar(PersonaJuridica t)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(PersonaJuridica t)
        {
            throw new NotImplementedException();
        }

        public bool insertar(PersonaJuridica t)
        {

            using (DataBaseContext dbc = new DataBaseContext())
            {

                dbc.PersonasJuridica.Add(t);
                dbc.SaveChanges();
                return true;
            }
        }

        public List<PersonaJuridica> Listar()
        {
            throw new NotImplementedException();
        }

    }
}