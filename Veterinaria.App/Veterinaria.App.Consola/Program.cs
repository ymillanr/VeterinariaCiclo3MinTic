using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        private static IRepositorioVeterinario repositorioVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioPropietario repositorioPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioAdministrador repositorioAdministrador = new RepositorioAdministrador(new Persistencia.AppContext());
        private static IRepositorioMascota repositorioMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioCita repositorioCita = new RepositorioCita(new Persistencia.AppContext());
        private static IRepositorioHistoriaClinica repositorioHistoriaClinica = new RepositorioHistoriaClinica(new Persistencia.AppContext());
        private static IRepositorioSugerenciaDeCuidado repositorioSugerenciaDeCuidado = new RepositorioSugerenciaDeCuidado(new Persistencia.AppContext());
        private static IRepositorioVacuna repositorioVacuna = new RepositorioVacuna(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entity Framework!");
            //AgregarVeterinario();
            //GetVeterinario(1);
            //EliminarVeterinario(2);
            //EditarVeterinario(1);
            //................................
            //AgregarPropietario();
            //GetPropietario(1);
            //EliminarPropietario(7);
            //EditarPropietario(1);
            //................................
            //AgregarAdministrador();
            //GetAdministrador(1);
            //EliminarAdministrador(2);
            //EditarAdministrador(8);
            //................................
            //AgregarMascota();
            //GetMascota(1);
            //EliminarMascota(2);
            //EditarMascota(1);
            //................................
            //AgregarCita();
            //GetCita(1);
            //EliminarCita(2);
            //EditarCita(1);
            //................................
            //AgregarHistoriaClinica();
            //GetHistoriaClinica(1);
            //EliminarHistoriaClinica(2);
            //EditarHistoriaClinica(1);
            //................................
            //AgregarSugerenciaDeCuidado();
            //GetSugerenciaDeCuidado(1);
            //EliminarSugerenciaDeCuidado(2);
            //EditarSugerenciaDeCuidado(1);
            //................................
            //AgregarVacuna();
            //GetVacuna(1);
            //EliminarVacuna(2);
            //EditarVacuna(1);
        }
        private static void AgregarVeterinario(){
            var veterinario = new Veterinario {
                Nombre = "Federico Mercurio",
                Telefono = "442345",
                Edad = 21,
                GeneroPersona= Genero.Masculino,
                Direccion = "Calle 122",
                Correo = "correo@correo.com",
                Contraseña = "asasas",
                FechaRegistro = new DateTime (2021, 09, 21),
                Especializacion = "Gatologo",
                NumeroDeTarjetaProfesional= 121334,
            };
            repositorioVeterinario.AgregarVeterinario(veterinario);
        }


        private static void GetVeterinario(int idVeterinario)
    {
        var veterinario = repositorioVeterinario.GetVeterinario(idVeterinario);
        Console.WriteLine(veterinario.Nombre);
    }
        
       
        private static void EditarVeterinario(int idVeterinario)
    {
        var veterinario = new Veterinario{
                Id = idVeterinario,
                Nombre = "Freddie Mercury",
                Telefono = "442345",
                Edad = 21,
                GeneroPersona= Genero.Masculino,
                Direccion = "Calle 45",
                Correo = "correofreddie@correo.com",
                Contraseña = "asassas",
                FechaRegistro = new DateTime (2021, 09, 21),
                Especializacion = "Gatologo",
                NumeroDeTarjetaProfesional= 121334,
        };
        repositorioVeterinario.EditarVeterinario(veterinario);
    }

         private static void EliminarVeterinario(int idVeterinario)
    {
        repositorioVeterinario.EliminarVeterinario(idVeterinario);
        Console.WriteLine("El registro ha sido eliminado");
    }

     //............................................Entidad Propietario.........................

            private static void AgregarPropietario()
    {
                var propietario = new Propietario {
                    Nombre = "Andres Ramos",
                    Telefono = "666",
                    Edad = 27,
                    GeneroPersona= Genero.Masculino,
                    Direccion = "Calle 52",
                    Correo = "correodecarlos@correo.com",
                    Contraseña = "asasas",
                    FechaRegistro = new DateTime (2021, 09, 21),
                    Profesion = "Químico",
                
                };
                repositorioPropietario.AgregarPropietario(propietario);
            }


            private static void GetPropietario(int idPropietario)
        {
            var propietario = repositorioPropietario.GetPropietario(idPropietario);
            Console.WriteLine(propietario.Nombre);
        }
            
            
            private static void EditarPropietario(int idPropietario)
        {
            var propietario = new Propietario{
                    Id = idPropietario,
                    Nombre = "Charles Ericson",
                    Telefono = "552345",
                    Edad = 19,
                    GeneroPersona= Genero.Masculino,
                    Direccion = "Calle Wallaby 42 - Sidney",
                    Correo = "correodegeorge@correo.com",
                    Contraseña = "aweqfds",
                    FechaRegistro = new DateTime (2021, 09, 23),
                    Profesion = "Químico",
            };
            repositorioPropietario.EditarPropietario(propietario);
        }  

            private static void EliminarPropietario(int idPropietario)
        {
            repositorioPropietario.EliminarPropietario(idPropietario);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //..................................Entidad Administrador........................
      
           private static void AgregarAdministrador()
    {
                var administrador = new Administrador {
                    Nombre = "Nicolas Cage",
                    Telefono = "566345",
                    Edad = 39,
                    GeneroPersona= Genero.Masculino,
                    Direccion = "Calle siempre viva 123",
                    Correo = "correodenicolas@correo.com",
                    Contraseña = "awewes",
                    FechaRegistro = new DateTime (2021, 09, 21),
                    Cargo = "Administrador Junior",
                
                };
                repositorioAdministrador.AgregarAdministrador(administrador);
            }


            private static void GetAdministrador(int idAdministrador)
        {
            var administrador = repositorioAdministrador.GetAdministrador(idAdministrador);
            Console.WriteLine(administrador.Nombre);
        }
            
            
            private static void EditarAdministrador(int idAdministrador)
        {
            var administrador = new Administrador{
                    Id = idAdministrador,
                    Nombre = "Nicolacito",
                    Telefono = "5456345",
                    Edad = 39,
                    GeneroPersona= Genero.Masculino,
                    Direccion = "Calle siempre viva 123",
                    Correo = "n@correo.com",
                    Contraseña = "assdcs",
                    FechaRegistro = new DateTime (2021, 09, 23),
                    Cargo = "Administrador Senior",
            };
            repositorioAdministrador.EditarAdministrador(administrador);
        }  

            private static void EliminarAdministrador(int idAdministrador)
        {
            repositorioAdministrador.EliminarAdministrador(idAdministrador);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //...................................entidad.... Mascota...........................
    private static void AgregarMascota()
    {
                var mascota = new Mascota {
                    Nombre = "Firulais",
                    Especie = "Perro",
                    Raza = "Golden Retriever",
                    Color = "Dorado",
                    Edad = 7,
                
                };
                repositorioMascota.AgregarMascota(mascota);
            }


            private static void GetMascota(int idMascota)
        {
            var mascota = repositorioMascota.GetMascota(idMascota);
            Console.WriteLine(mascota.Nombre);
        }
            
            
            private static void EditarMascota(int idMascota)
        {
            var mascota = new Mascota {
                    Id = idMascota,
                    Nombre = "Firulais el Destripador 2",
                    Especie = "Perro",
                    Raza = "Golden Retriever",
                    Color = "Dorado",
                    Edad = 8,
            };
            repositorioMascota.EditarMascota(mascota);
        }  

            private static void EliminarMascota(int idMascota)
        {
            repositorioMascota.EliminarMascota(idMascota);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //..............................entidad..........Cita..........................
    private static void AgregarCita()
    {
                var cita = new Cita {
                    Fecha = new DateTime (2021, 10, 01),
                    Hora = "02:00 pm",
                    Duracion = "30 minutos",
                
                };
                repositorioCita.AgregarCita(cita);
            }


            private static void GetCita(int idCita)
        {
            var cita = repositorioCita.GetCita(idCita);
            Console.WriteLine(cita.Fecha+" "+cita.Duracion);
        }
            
            
            private static void EditarCita(int idCita)
        {
            var cita = new Cita{
                    Id = idCita,
                    Fecha = new DateTime (2021, 10, 10),
                    Hora = "04:00 pm",
                    Duracion = "30 minutos",
                    
            };
            repositorioCita.EditarCita(cita);
        }  

            private static void EliminarCita(int idCita)
        {
            repositorioCita.EliminarCita(idCita);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //......................entidad.......historia...clinica..........
    private static void AgregarHistoriaClinica()
    {
                var historiaClinica = new HistoriaClinica {
                    Fecha = new DateTime (2021, 10, 01),
                    Evaluacion = "paciente asiste a consulta porque esta cansado",
                    Diagnostico = "Se encuentra deficit de DogChow",
                
                };
                repositorioHistoriaClinica.AgregarHistoriaClinica(historiaClinica);
            }


            private static void GetHistoriaClinica(int idHistoriaClinica)
        {
            var historiaClinica = repositorioHistoriaClinica.GetHistoriaClinica(idHistoriaClinica);
            Console.WriteLine(historiaClinica.Fecha+" "+historiaClinica.Diagnostico);
        }
            
            
            private static void EditarHistoriaClinica(int idHistoriaClinica)
        {
            var historiaClinica = new HistoriaClinica{
                    Id = idHistoriaClinica,
                    Fecha = new DateTime (2021, 10, 01),
                    Evaluacion = "paciente asiste a consulta porque estaba cansado",
                    Diagnostico = "Se encuentra deficit de Purina DogChow",
                    
            };
            repositorioHistoriaClinica.EditarHistoriaClinica(historiaClinica);
        }  

            private static void EliminarHistoriaClinica(int idHistoriaClinica)
        {
            repositorioHistoriaClinica.EliminarHistoriaClinica(idHistoriaClinica);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //....................................entidad....SugerenciaDeCuidado.....
    private static void AgregarSugerenciaDeCuidado()
    {
                var sugerenciaDeCuidado = new SugerenciaDeCuidado {
                    Fecha = new DateTime (2021, 10, 01),
                    Medicamentos = "ParecetDogMol 100 gr",
                    Descripcion = "Tomar 1 pastilla cada 8 horas",
                
                };
                repositorioSugerenciaDeCuidado.AgregarSugerenciaDeCuidado(sugerenciaDeCuidado);
            }


            private static void GetSugerenciaDeCuidado(int idSugerenciaDeCuidado)
        {
            var sugerenciaDeCuidado = repositorioSugerenciaDeCuidado.GetSugerenciaDeCuidado(idSugerenciaDeCuidado);
            Console.WriteLine(sugerenciaDeCuidado.Fecha+" "+sugerenciaDeCuidado.Medicamentos+" "+sugerenciaDeCuidado.Descripcion);
        }
            
            
            private static void EditarSugerenciaDeCuidado(int idSugerenciaDeCuidado)
        {
            var sugerenciaDeCuidado = new SugerenciaDeCuidado{
                    Id = idSugerenciaDeCuidado,
                    Fecha = new DateTime (2021, 10, 01),
                    Medicamentos = "ParecetDogMol 200 gr",
                    Descripcion = "Tomar 1 pastilla cada 10 horas",
                    
            };
            repositorioSugerenciaDeCuidado.EditarSugerenciaDeCuidado(sugerenciaDeCuidado);
        }  

            private static void EliminarSugerenciaDeCuidado(int idSugerenciaDeCuidado)
        {
            repositorioSugerenciaDeCuidado.EliminarSugerenciaDeCuidado(idSugerenciaDeCuidado);
            Console.WriteLine("El registro ha sido eliminado");
    }
    //..........................entidad.....Vacuna.....................
    private static void AgregarVacuna()
    {
                var vacuna = new Vacuna {
                    Nombre = "Vacuna contra la rabia",
                    Marca = "ZooTec",
                    RegistroInvima = "IRC120000",
                    NumeroDosis = 2,
                
                };
                repositorioVacuna.AgregarVacuna(vacuna);
            }


            private static void GetVacuna(int idVacuna)
        {
            var vacuna = repositorioVacuna.GetVacuna(idVacuna);
            Console.WriteLine(vacuna.Nombre+" "+vacuna.NumeroDosis);
        }
            
            
            private static void EditarVacuna(int idVacuna)
        {
            var vacuna = new Vacuna{
                    Id= idVacuna,
                    Nombre = "Vacuna contra la rabia",
                    Marca = "BioTecAnimal",
                    RegistroInvima = "IRC520000",
                    NumeroDosis = 1,
                    
            };
            repositorioVacuna.EditarVacuna(vacuna);
        }  

            private static void EliminarVacuna(int idVacuna)
        {
            repositorioVacuna.EliminarVacuna(idVacuna);
            Console.WriteLine("El registro ha sido eliminado");
    }
    }
}   

    