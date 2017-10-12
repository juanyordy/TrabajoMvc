﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrabajoMvc.Interface;
using TrabajoMvc.Models;

namespace TrabajoMvc.Query
{
    public class QPersonaJuridica : IGeneric<PersonaJuridica>
    {
      

        public bool Eliminar(PersonaJuridica t)
        {
            using (DataBaseContext dbc = new DataBaseContext())
            {
                dbc.PersonasJuridica.First(p => p.ruc == t.ruc);
                return true;
            }
            
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
            using (DataBaseContext dbc = new DataBaseContext())
            {
                return dbc.PersonasJuridica.ToList();
            }
            
        }


        public bool Editar(PersonaJuridica t, string primarykey)
        {
            throw new NotImplementedException();
        }

        public PersonaJuridica PrimaryKey(string dni)
        {
            throw new NotImplementedException();
        }
    }
}