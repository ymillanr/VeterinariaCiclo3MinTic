using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{

    public interface IRepositorioCita{

       public Cita AgregarCita (Cita cita);
       public Cita EditarCita (Cita cita);
       public void EliminarCita (int idCita);
       public Cita GetCita (int idCita);
       public IEnumerable<Cita> GetAllCitas();
    }
}