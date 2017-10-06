using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Interface
{
    public interface IGeneric<T>
    {
        bool insertar(T t);
        bool Editar(T t);
        bool Eliminar(T t);
        List<T> Listar();  
    }
}