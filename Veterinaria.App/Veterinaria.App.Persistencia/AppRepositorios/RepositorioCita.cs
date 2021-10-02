using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioCita :IRepositorioCita {

        private readonly AppContext appContext;

        public RepositorioCita(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public Cita AgregarCita (Cita cita){
           var citaAdicionada = this.appContext.Citas.Add(cita);
            this.appContext.SaveChanges();
            return citaAdicionada.Entity;
       }
       
       
       
       public Cita EditarCita (Cita cita){
            var citaEncontrada = this.appContext.Citas.FirstOrDefault(v => v.Id == cita.Id);
            if (citaEncontrada!=null)
            {
                citaEncontrada.Fecha=cita.Fecha;
                citaEncontrada.Hora=cita.Hora;
                citaEncontrada.Duracion=cita.Duracion;            

                this.appContext.SaveChanges();
            }
            return citaEncontrada;
       }
       
       
       
       public void EliminarCita (int idCita){

           var citaEncontrada = this.appContext.Citas.FirstOrDefault(v => v.Id == idCita);
           if(citaEncontrada == null){
               return ;
               }
               else {
               this.appContext.Citas.Remove(citaEncontrada);
               this.appContext.SaveChanges();
           }
       }

       public Cita GetCita (int idCita){
           return this.appContext.Citas.FirstOrDefault(v => v.Id == idCita);
       }
       public IEnumerable<Cita> GetAllCitas(){
           return this.appContext.Citas;
       }
    }
}