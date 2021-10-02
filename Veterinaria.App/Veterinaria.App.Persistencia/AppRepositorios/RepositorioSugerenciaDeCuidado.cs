using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Veterinaria.App.Persistencia{

    public class RepositorioSugerenciaDeCuidado :IRepositorioSugerenciaDeCuidado {

        private readonly AppContext appContext;

        public RepositorioSugerenciaDeCuidado(AppContext appContextParam){

            this.appContext = appContextParam;
        }
       
       
       public SugerenciaDeCuidado AgregarSugerenciaDeCuidado (SugerenciaDeCuidado sugerenciaDeCuidado){
           var sugerenciaDeCuidadoAdicionada = this.appContext.SugerenciasDeCuidado.Add(sugerenciaDeCuidado);
            this.appContext.SaveChanges();
            return sugerenciaDeCuidadoAdicionada.Entity;
       }
       
       
       
       public SugerenciaDeCuidado EditarSugerenciaDeCuidado (SugerenciaDeCuidado sugerenciaDeCuidado){
            var sugerenciaDeCuidadoEncontrada = this.appContext.SugerenciasDeCuidado.FirstOrDefault(v => v.Id == sugerenciaDeCuidado.Id);
            if (sugerenciaDeCuidadoEncontrada!=null)
            {
                sugerenciaDeCuidadoEncontrada.Fecha=sugerenciaDeCuidado.Fecha;
                sugerenciaDeCuidado.Medicamentos=sugerenciaDeCuidado.Medicamentos;
                sugerenciaDeCuidado.Descripcion=sugerenciaDeCuidado.Descripcion;            

                this.appContext.SaveChanges();
            }
            return sugerenciaDeCuidadoEncontrada;
       }
       
       
       
       public void EliminarSugerenciaDeCuidado (int idSugerenciaDeCuidado){

           var sugerenciaDeCuidadoEncontrada = this.appContext.SugerenciasDeCuidado.FirstOrDefault(v => v.Id ==idSugerenciaDeCuidado);
           if(sugerenciaDeCuidadoEncontrada == null){
               return ;
               }
               else {
               this.appContext.SugerenciasDeCuidado.Remove(sugerenciaDeCuidadoEncontrada);
               this.appContext.SaveChanges();
           }
       }

       public SugerenciaDeCuidado GetSugerenciaDeCuidado (int idSugerenciaDeCuidado){
           return this.appContext.SugerenciasDeCuidado.FirstOrDefault(v => v.Id ==idSugerenciaDeCuidado);
       }
       public IEnumerable<SugerenciaDeCuidado> GetAllSugerenciasDeCuidado(){
           return this.appContext.SugerenciasDeCuidado;
       }
    }
}