using System;

namespace Veterinaria.App.Dominio {
    
    public class HistoriaClinica{
        
        public int Id {get; set;}
        public DateTime Fecha {get; set;}
        public string Evaluacion {get; set;}
        public string Diagnostico {get; set;}
    } 
}