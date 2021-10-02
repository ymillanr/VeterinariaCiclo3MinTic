using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVacuna{

       public Vacuna AgregarVacuna (Vacuna vacuna);
       public Vacuna EditarVacuna (Vacuna vacuna);
       public void EliminarVacuna (int idVacuna);
       public Vacuna GetVacuna (int idVacuna);
       public IEnumerable<Vacuna> GetAllVacunas();
    }
}