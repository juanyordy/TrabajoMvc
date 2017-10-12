using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Interface
{
    public interface IGeneric<T>
    {
        bool insertar(T t);
        T PrimaryKey(string dni);
        bool Editar(T t, string primarykey);
        bool Eliminar(T t);
        List<T> Listar();  
    }
}