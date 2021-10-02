using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioPropietario{

       public Propietario AgregarPropietario (Propietario propietario);
       public Propietario EditarPropietario (Propietario propietario);
       public void EliminarPropietario (int idpropietario);
       public Propietario GetPropietario (int idpropietario);
       public IEnumerable<Propietario> GetAllPropietarios();
    }
}