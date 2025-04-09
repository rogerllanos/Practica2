using System;

namespace practica2
{

        public class autobus : vehiculo
        {
            public int capacidadPasajeros;
            public int numeroPuertas;
            public int numeroAsientos;
            public int numeroid;
            public void cargaPasajero()
            {
                Console.WriteLine("suben pasajero");
            }
            public void descargaPasajeros()
            {
                Console.WriteLine("bajan pasajeros");
            }            
        }

        public class motos : vehiculo
        {
            public int cilindrada;
            public string tipoDeMoto;
            public bool asientoAcompañante;
            public void ponerCasco()
            {
                Console.WriteLine("se coloca el casco");
            }            
        }

        public class camiones : vehiculo
        {
            public int cargaMax;
            public string tipoCamion;
            public string tipoDistancia;
            public void carga()
            {
                Console.WriteLine("se carga el camion");
            }    
            public void descarga()
            {
                Console.WriteLine("se descarga el camion");
            }                    
        }
        public class vehiculo
        {
            public string modelo;
            public string marca;
            public int año;
            public int numSerie;
            public void arrancar()
            {
                Console.WriteLine("arrancando");
            }
            public void detener()
            {
                Console.WriteLine("deteniendose");
            }
            public void acelerar()
            {
                Console.WriteLine("acelera");
            }
            public void frenar()
            {
                Console.WriteLine("frenando");
            }
        }

        public class animal
        {
            public string especie;
            public int edad;
            public string genero;
            public string nombre;
            public int peso;
            public void alimentarse()
            {
                Console.WriteLine("se alimenta");
            }
            public void reproducirse()
            {
                Console.WriteLine("se realiza el ciclo de la vida");
            }
        }
        public class reptiles :animal
        {
            public string cantPatas;
            public bool camuflaje;
            public void cazar()
            {
                Console.WriteLine("cazando");
            }

        }
        public class aves : animal
        {
            public bool vuela;
            public string tipoHabitad;
            public void picotear()
            {
                Console.WriteLine("picotea");
            }
            public void ponerHuevo()
            {
                Console.WriteLine("pone huevos en el nido");
            }
        }

        public class Libro
        {
            public string Titulo;
            public string Autor;
            public int añoPublicaion;
            public string genero;
            public void abrir()
            {
                Console.WriteLine("abre el libro");
            }
            public void cerrar()
            {
                Console.WriteLine("cierra el libro");
            }
            public void leer()
            {
                Console.WriteLine("lee el libro");
            }                        
        }
        public class Biblioteca
        {
            public string Nombre; 
            public string Ubicacion; 
            public int HorarioApertura; 

            public void AgregarLibro(string titulo, string autor)
            {
              
            }
            public void BuscarLibro(string tituloBuscado)
            {
               
            }
        }

}