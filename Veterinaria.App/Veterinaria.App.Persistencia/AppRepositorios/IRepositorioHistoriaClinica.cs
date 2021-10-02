using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioHistoriaClinica{

       public HistoriaClinica AgregarHistoriaClinica (HistoriaClinica historiaClinica);
       public HistoriaClinica EditarHistoriaClinica (HistoriaClinica historiaClinica);
       public void EliminarHistoriaClinica (int idHistoriaClinica);
       public HistoriaClinica GetHistoriaClinica (int idHistoriaClinica);
       public IEnumerable<HistoriaClinica> GetAllHistoriasClinicas();
    }
}