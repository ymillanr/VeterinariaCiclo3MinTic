using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioVeterinario{

       public Veterinario AgregarVeterinario (Veterinario veterinario);
       public Veterinario EditarVeterinario (Veterinario veterinario);
       public void EliminarVeterinario (int idveterinario);
       public Veterinario GetVeterinario (int idveterinario);
       public IEnumerable<Veterinario> GetAllVeterinarios();
    }
}