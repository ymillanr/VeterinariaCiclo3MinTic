using System;

namespace Veterinaria.App.Dominio {

    public class SugerenciaDeCuidado {
        
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public string Medicamentos {get; set;}
        public string Descripcion {get; set;}
    }
}