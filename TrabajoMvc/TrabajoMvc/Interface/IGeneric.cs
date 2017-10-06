using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoMvc.Interface
{
    public interface IGeneric<T>
    {
        bool insertar(T t);
        T Editar(string dni);
        bool Eliminar(T t);
        List<T> Listar();  
    }
}