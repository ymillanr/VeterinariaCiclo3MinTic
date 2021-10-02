using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioSugerenciaDeCuidado{

       public SugerenciaDeCuidado AgregarSugerenciaDeCuidado (SugerenciaDeCuidado sugerenciaDeCuidado);
       public SugerenciaDeCuidado EditarSugerenciaDeCuidado (SugerenciaDeCuidado sugerenciaDeCuidado);
       public void EliminarSugerenciaDeCuidado (int idSugerenciaDeCuidado);
       public SugerenciaDeCuidado GetSugerenciaDeCuidado (int idSugerenciaDeCuidado);
       public IEnumerable<SugerenciaDeCuidado> GetAllSugerenciasDeCuidado();
    }
}