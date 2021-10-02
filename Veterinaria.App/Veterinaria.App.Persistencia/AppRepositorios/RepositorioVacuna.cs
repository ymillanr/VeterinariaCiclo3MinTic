using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioVacuna :IRepositorioVacuna {

        private readonly AppContext appContext;

        public RepositorioVacuna(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Vacuna AgregarVacuna (Vacuna vacuna){
           var vacunaAdicionada = this.appContext.Vacunas.Add(vacuna);
            this.appContext.SaveChanges();
            return vacunaAdicionada.Entity;
       }
       
       
       
       public Vacuna EditarVacuna (Vacuna vacuna){
            var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault(v => v.Id == vacuna.Id);
            if (vacunaEncontrada!=null)
            {
                vacunaEncontrada.Nombre=vacuna.Nombre;
                vacunaEncontrada.Marca=vacuna.Marca;
                vacunaEncontrada.RegistroInvima=vacuna.RegistroInvima;
                vacunaEncontrada.NumeroDosis=vacuna.NumeroDosis;       

                this.appContext.SaveChanges();
            }
            return vacunaEncontrada;
       }
       
       
       
       public void EliminarVacuna (int idVacuna){

           var vacunaEncontrada = this.appContext.Vacunas.FirstOrDefault(v => v.Id == idVacuna);
           if(vacunaEncontrada == null){
               return ;
               }
               else {
               this.appContext.Vacunas.Remove(vacunaEncontrada);
               this.appContext.SaveChanges();
           }
       }

       public Vacuna GetVacuna (int idVacuna){
           return this.appContext.Vacunas.FirstOrDefault(v => v.Id ==idVacuna);
       }
       public IEnumerable<Vacuna> GetAllVacunas(){
           return this.appContext.Vacunas;
       }
    }
}