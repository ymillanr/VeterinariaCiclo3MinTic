using System;

namespace Veterinaria.App.Dominio {

    public class Vacuna {
        
        public int Id {get; set;}  
        public string Nombre {get; set;}
        public string Marca {get; set;}
        public string RegistroInvima {get; set;}
        public int NumeroDosis {get; set;}
    }
}