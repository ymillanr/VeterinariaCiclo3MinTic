using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioPropietario :IRepositorioPropietario {

        private readonly AppContext appContext;

        public RepositorioPropietario(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Propietario AgregarPropietario (Propietario propietario){
           var propietarioAdicionado = this.appContext.Propietarios.Add(propietario);
            this.appContext.SaveChanges();
            return propietarioAdicionado.Entity;
       }
       
       
       
       public Propietario EditarPropietario (Propietario propietario){
            var propietarioEncontrado = this.appContext.Propietarios.FirstOrDefault(v => v.Id == propietario.Id);
            if (propietarioEncontrado!=null)
            {
                propietarioEncontrado.Nombre=propietario.Nombre;
                propietarioEncontrado.Edad=propietario.Edad;
                propietarioEncontrado.GeneroPersona=propietario.GeneroPersona;
                propietarioEncontrado.Correo=propietario.Correo;
                propietarioEncontrado.Telefono=propietario.Telefono;
                propietarioEncontrado.Contraseña=propietario.Contraseña;
                propietarioEncontrado.FechaRegistro=propietario.FechaRegistro;
                propietarioEncontrado.Direccion=propietario.Direccion;
                propietarioEncontrado.Profesion=propietario.Profesion;

                this.appContext.SaveChanges();
            }
            return propietarioEncontrado;
       }
       
       
       
       public void EliminarPropietario (int idPropietario){

           var propietarioEncontrado = this.appContext.Propietarios.FirstOrDefault(v => v.Id ==idPropietario);
           if(propietarioEncontrado == null){
               return ;
               }
               else {
               this.appContext.Propietarios.Remove(propietarioEncontrado);
               this.appContext.SaveChanges();
           }
       }

       public Propietario GetPropietario (int idPropietario){
           return this.appContext.Propietarios.FirstOrDefault(v => v.Id ==idPropietario);
       }
       public IEnumerable<Propietario> GetAllPropietarios(){
           return this.appContext.Propietarios;
       }
    }
}
