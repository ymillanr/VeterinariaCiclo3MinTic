using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioMascota{

       public Mascota AgregarMascota (Mascota mascota);
       public Mascota EditarMascota (Mascota mascota);
       public void EliminarMascota (int idMascota);
       public Mascota GetMascota (int idMascota);
       public IEnumerable<Mascota> GetAllMascotas();
    }
}