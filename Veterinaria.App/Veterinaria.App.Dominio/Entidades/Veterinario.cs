using System;

namespace Veterinaria.App.Dominio
{
    public class Veterinario  : Persona
    {
        public string Especializacion {get; set;}
        public int NumeroDeTarjetaProfesional {get; set;}
    }
}