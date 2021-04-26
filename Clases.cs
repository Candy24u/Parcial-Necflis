using System;

namespace Clases
{
    //Clase de los clientes
  class Clientes
  {

    public string nombre1;
    public int edad;
    public string direccion;

    public Clientes(
      string nombre1, 
      int edad,
      string direccion
      )
      {
        this.nombre1 = nombre1;
        this.edad = edad;
        this.direccion = direccion;
      }
      
      //INGRESO DEL CLIENTE
      public Clientes(){
        System.Console.WriteLine("Ingrese nombre");
        nombre1 = Console.ReadLine();

        System.Console.WriteLine("Ingrese dirección");
        direccion = Console.ReadLine();

        System.Console.WriteLine("Ingrese edad");
        edad = int.Parse(Console.ReadLine());

      }
   }

  }

    //Clase de las peliculas
  public class Peliculas
  {
     public string nombre;
     public string tipo;
     public string genero;
     public string sinopsis;


    public Peliculas(
      string nombre, 
      string tipo,
      string genero,
      string sinopsis
      )
      {
        this.nombre = nombre;
        this.tipo = tipo;
        this.genero = genero;
        this.sinopsis = sinopsis;
      }

      //INGRESO DE LAS PELICULAS
      public Peliculas(){
        System.Console.WriteLine("Ingrese el nombre");
        nombre = Console.ReadLine();

        System.Console.WriteLine("\nElija el tipo");
        System.Console.WriteLine("1. - Serie");
        System.Console.WriteLine("2. - Pelicula");
        tipo = Console.ReadLine();

        System.Console.WriteLine("\nElija el género");
        System.Console.WriteLine("1. - drama");
        System.Console.WriteLine("2. - comedia");
        System.Console.WriteLine("3. - terror");
        System.Console.WriteLine("4. - suspenso");
        genero =Console.ReadLine();

        System.Console.WriteLine("\nescriba la sinopsis de la pelicula");
        sinopsis = Console.ReadLine();

        }



}