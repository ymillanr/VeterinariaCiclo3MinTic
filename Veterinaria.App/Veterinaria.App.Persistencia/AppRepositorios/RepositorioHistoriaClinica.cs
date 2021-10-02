using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioHistoriaClinica :IRepositorioHistoriaClinica {

        private readonly AppContext appContext;

        public RepositorioHistoriaClinica(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public HistoriaClinica AgregarHistoriaClinica (HistoriaClinica historiaClinica){
           var historiaClinicaAdicionada = this.appContext.HistoriasClinicas.Add(historiaClinica);
            this.appContext.SaveChanges();
            return historiaClinicaAdicionada.Entity;
       }
       
       
       
       public HistoriaClinica EditarHistoriaClinica (HistoriaClinica historiaClinica){
            var historiaClinicaEncontrada = this.appContext.HistoriasClinicas.FirstOrDefault(v => v.Id == historiaClinica.Id);
            if (historiaClinicaEncontrada!=null)
            {
                historiaClinicaEncontrada.Fecha=historiaClinica.Fecha;
                historiaClinica.Evaluacion=historiaClinica.Evaluacion;
                historiaClinica.Diagnostico=historiaClinica.Diagnostico;            

                this.appContext.SaveChanges();
            }
            return historiaClinicaEncontrada;
       }
       
       
       
       public void EliminarHistoriaClinica (int idHistoriaClinica){

           var historiaClinicaEncontrada = this.appContext.HistoriasClinicas.FirstOrDefault(v => v.Id ==idHistoriaClinica);
           if(historiaClinicaEncontrada == null){
               return ;
               }
               else {
               this.appContext.HistoriasClinicas.Remove(historiaClinicaEncontrada);
               this.appContext.SaveChanges();
           }
       }

       public HistoriaClinica GetHistoriaClinica (int idHistoriaClinica){
           return this.appContext.HistoriasClinicas.FirstOrDefault(v => v.Id ==idHistoriaClinica);
       }
       public IEnumerable<HistoriaClinica> GetAllHistoriasClinicas(){
           return this.appContext.HistoriasClinicas;
       }
    }
}