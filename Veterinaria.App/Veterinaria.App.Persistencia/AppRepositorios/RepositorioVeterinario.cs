using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioVeterinario :IRepositorioVeterinario {

        private readonly AppContext appContext;

        public RepositorioVeterinario(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Veterinario AgregarVeterinario (Veterinario veterinario){
           var veterinarioAdicionado = this.appContext.Veterinarios.Add(veterinario);
            this.appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
       }
       
       
       
       public Veterinario EditarVeterinario (Veterinario veterinarioNuevo){
            var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == veterinarioNuevo.Id);
            if (veterinarioEncontrado!=null)
            {
                veterinarioEncontrado.Nombre=veterinarioNuevo.Nombre;
                veterinarioEncontrado.Edad=veterinarioNuevo.Edad;
                veterinarioEncontrado.GeneroPersona=veterinarioNuevo.GeneroPersona;
                veterinarioEncontrado.Correo=veterinarioNuevo.Correo;
                veterinarioEncontrado.Telefono=veterinarioNuevo.Telefono;
                veterinarioEncontrado.Contraseña=veterinarioNuevo.Contraseña;
                veterinarioEncontrado.FechaRegistro=veterinarioNuevo.FechaRegistro;
                veterinarioEncontrado.Direccion=veterinarioNuevo.Direccion;
                veterinarioEncontrado.Especializacion=veterinarioNuevo.Especializacion;
                veterinarioEncontrado.NumeroDeTarjetaProfesional=veterinarioNuevo.NumeroDeTarjetaProfesional;

                this.appContext.SaveChanges();
            }
            return veterinarioEncontrado;
       }
       
       
       
       public void EliminarVeterinario (int idVeterinario){

           var veterinarioEncontrado = this.appContext.Veterinarios.FirstOrDefault(v => v.Id == idVeterinario);
           if(veterinarioEncontrado == null){
               return;
               }
               else {
               this.appContext.Veterinarios.Remove(veterinarioEncontrado);
               this.appContext.SaveChanges();
           }
       }

       public Veterinario GetVeterinario (int idVeterinario){
           return this.appContext.Veterinarios.FirstOrDefault(v => v.Id ==idVeterinario);
       }
       public IEnumerable<Veterinario> GetAllVeterinarios(){
           return this.appContext.Veterinarios;
       }
    }
}
