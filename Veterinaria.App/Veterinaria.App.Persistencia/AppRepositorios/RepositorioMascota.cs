using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioMascota :IRepositorioMascota {

        private readonly AppContext appContext;

        public RepositorioMascota(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Mascota AgregarMascota (Mascota mascota){
           var MascotaAdicionada = this.appContext.Mascotas.Add(mascota);
            this.appContext.SaveChanges();
            return MascotaAdicionada.Entity;
       }
       
       
       
       public Mascota EditarMascota (Mascota mascota){
            var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(v => v.Id == mascota.Id);
            if (mascotaEncontrada!=null)
            {
                mascotaEncontrada.Nombre=mascota.Nombre;
                mascotaEncontrada.Especie=mascota.Especie;
                mascotaEncontrada.Raza=mascota.Raza;
                mascotaEncontrada.Color=mascota.Color;
                mascotaEncontrada.Edad=mascota.Edad;
               

                this.appContext.SaveChanges();
            }
            return mascotaEncontrada;
       }
       
       
       
       public void EliminarMascota (int idMascota){

           var mascotaEncontrada = this.appContext.Mascotas.FirstOrDefault(v => v.Id ==idMascota);
           if(mascotaEncontrada == null){
               return ;
               }
               else {
               this.appContext.Mascotas.Remove(mascotaEncontrada);
               this.appContext.SaveChanges();
           }
       }

       public Mascota GetMascota (int idMascota){
           return this.appContext.Mascotas.FirstOrDefault(v => v.Id ==idMascota);
       }
       public IEnumerable<Mascota> GetAllMascotas(){
           return this.appContext.Mascotas;
       }
    }
}