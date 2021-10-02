using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioAdministrador :IRepositorioAdministrador {

        private readonly AppContext appContext;

        public RepositorioAdministrador(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Administrador AgregarAdministrador (Administrador administrador){
           var administradorAdicionado = this.appContext.Administradores.Add(administrador);
            this.appContext.SaveChanges();
            return administradorAdicionado.Entity;
       }
       
       
       
       public Administrador EditarAdministrador (Administrador administrador){
            var administradorEncontrado = this.appContext.Administradores.FirstOrDefault(v => v.Id == administrador.Id);
            if (administradorEncontrado!=null)
            {
                administradorEncontrado.Nombre=administrador.Nombre;
                administradorEncontrado.Edad=administrador.Edad;
                administradorEncontrado.GeneroPersona=administrador.GeneroPersona;
                administradorEncontrado.Correo=administrador.Correo;
                administradorEncontrado.Telefono=administrador.Telefono;
                administradorEncontrado.Contraseña=administrador.Contraseña;
                administradorEncontrado.FechaRegistro=administrador.FechaRegistro;
                administradorEncontrado.Direccion=administrador.Direccion;
                administradorEncontrado.Cargo=administrador.Cargo;

                this.appContext.SaveChanges();
            }
            return administradorEncontrado;
       }
       
       
       
       public void EliminarAdministrador (int idAdministrador){

           var administradorEncontrado = this.appContext.Administradores.FirstOrDefault(v => v.Id ==idAdministrador);
           if(administradorEncontrado == null){
               return ;
               }
               else {
               this.appContext.Administradores.Remove(administradorEncontrado);
               this.appContext.SaveChanges();
           }
       }

       public Administrador GetAdministrador (int idAdministrador){
           return this.appContext.Administradores.FirstOrDefault(v => v.Id ==idAdministrador);
       }
       public IEnumerable<Administrador> GetAllAdministradores(){
           return this.appContext.Administradores;
       }
    }
}