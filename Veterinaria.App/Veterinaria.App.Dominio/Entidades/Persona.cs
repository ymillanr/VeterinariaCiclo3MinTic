using System;
namespace Veterinaria.App.Dominio
{
    public class Persona {

        public int Id {get; set;}
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public Genero GeneroPersona {get; set;}
        public string Correo {get; set;}
        public string Telefono {get; set;}
        public string Contraseña {get; set;}
        public DateTime FechaRegistro {get; set;}
        public string Direccion {get; set;}
    }
}