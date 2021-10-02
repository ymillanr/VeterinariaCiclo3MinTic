using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioAdministrador{

       public Administrador AgregarAdministrador (Administrador administrador);
       public Administrador EditarAdministrador (Administrador administrador);
       public void EliminarAdministrador (int idAdministrador);
       public Administrador GetAdministrador (int idAdministrador);
       public IEnumerable<Administrador> GetAllAdministradores();
    }
}