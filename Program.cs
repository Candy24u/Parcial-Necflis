using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args){
          //CLIENTES
          Clientes[] nuevocliente = new Clientes[15];
          Clientes cliente =  new Clientes(null,0,null);

          //PELICULAS
          Peliculas pelicula = new Peliculas(null,null,null,null);
          Peliculas[] crearpelicula = new Peliculas[15];

          //LISTAS
          lista Lista = new lista(null,null,0);
          lista[] listado = new lista[30];
          

          string[] listaprueba = new string[10];
          //VARIABLES
          int contador1 = 0;
          int numero1 = 1 ;

          
          //int valor = 0;
          int contar = 0;
          int num = 1;
          int sumatoria = 0;

            int i1 = 0;
            do
            {
              Console.Clear();
              Console.WriteLine("¡¡¡BIENVENIDO A Necflis!!!\n");
             Console.WriteLine("Elige una opción: \n" +
             "\n1. - Clientes" +
             "\n2. - Películas" +
             "\n3. - Salir \n");

             i1 = Convert.ToInt16(Console.ReadLine());

             switch(i1)
             {
                case 1:
                 Console.WriteLine("---------------CLIENTES---------------\n");
                 int opcion = 0;
                 do
                 {
                   Console.Clear();
                   Console.WriteLine("¡¡¡BIENVENIDO A CLIENTES!!!\n");
                   Console.WriteLine("Elige una opción: \n" +
                   "\n1. - Ver Listado Clientes" +
                   "\n2. - crear Nuevo Cliente" +
                   "\n3. - Seleccionar Cliente" +
                   "\n4. - Atrás \n");

                   opcion = Convert.ToInt16(Console.ReadLine());

                   switch(opcion)
                   {
                     case 1:
                       Console.WriteLine("---------------VER LISTADO CLIENTES---------------\n");

                       for (int i = 0; i < contador1; i++)
                       {
                         cliente = nuevocliente[i];
                         System.Console.WriteLine(numero1 + " " + "Nombre cliente " + cliente.nombre1 + " Dirección " + cliente.direccion + " edad " + cliente.edad + "\n");
                         numero1++;
                        }
                       numero1 = 1;
                        Console.WriteLine("\nPrecione enter para elegir otra opción");
                        Console.ReadKey();
                
                     break;
                  
                     case 2:
                        Console.WriteLine("---------------CREAR NUEVO CLIENTE---------------\n");
                        cliente = new Clientes();
                        nuevocliente[contador1] = cliente;
                        contador1++;
                        
                        //for
                        for (int i = 0; i < contador1; i++)
                       {
                         cliente = nuevocliente[i];
                         System.Console.WriteLine("\n" + numero1 + " " + cliente.nombre1);
                         numero1++;
                        }
                       numero1 = 1;

                        Console.WriteLine("\nPrecione enter para elegir otra opción");
                        Console.ReadKey();

                     break;

                     case 3:
                     //FOR
                        for (int i = 0; i < contador1; i++)
                       {
                         cliente = nuevocliente[i];
                         System.Console.WriteLine(numero1 + " " + cliente.nombre1);
                         numero1++;
                        }
                       numero1 = 1;

                       //INGRESO
                        System.Console.WriteLine("\nElige un cliente");
                        int numcliente = Int32.Parse(Console.ReadLine());

                        Clientes cliente1 = nuevocliente[numcliente -1];
                        System.Console.WriteLine("Nombre cliente " + cliente1.nombre1 + " Dirección " + cliente1.direccion + " edad " + cliente1.edad + "\n");

                        while(true){
                        System.Console.WriteLine("\nElige una opción");
                        System.Console.WriteLine("1. - Playlist");
                        System.Console.WriteLine("2. - Agregar pelicula");
                        System.Console.WriteLine("3. - Atras");
                        int datos = Int32.Parse(Console.ReadLine());


                        Console.WriteLine("\nPrecione enter para elegir otra opción");
                        Console.ReadKey();


                        //INGRESAR LOS DATOS A EL CLIENTES
                       if (datos ==1)
                       
                       {
                          for (int i = 0; i < sumatoria; i++)
                          {
                            string valor1 = Lista.listas[i];
                            System.Console.WriteLine( num + " " + valor1);
                            num++;
                          }
                          num = 1;
                                    
                        }
                        if (datos ==2)
                        {
                          while(true)
                          {
                            System.Console.WriteLine("----------Lista de Peliculas---------");
                            for (int i = 0; i < contar; i++)
                          {
                             pelicula = crearpelicula[i];
                             System.Console.WriteLine( num + " " + pelicula.nombre);
                             num++;
                          }
                          num = 1;
    
                          System.Console.WriteLine("\nElige la pelicula que desea agregar");
                          int elegir = Int32.Parse(Console.ReadLine());
                          System.Console.WriteLine("\nSi desea salir, precione 0");

                          if(elegir==0)
                          {

                            Lista = new lista(cliente1.nombre1,listaprueba);
                            break;
                                        
                          }
                                    
                          else{
                           pelicula = crearpelicula[elegir-1];
                           string peli1 = pelicula.nombre; 
                           Lista =new lista(cliente1.nombre1,peli1,sumatoria);
                           listado[sumatoria] = Lista;
                           sumatoria++;

                          }

                          for (int i = 0; i < sumatoria; i++)
                          {
                            Lista=listado[i];
                            listaprueba[i] = Lista.peliculaUsuario;
                          }

                          }

                        }
                        if (datos ==3){
                          break;
                        }
                        else{
                          System.Console.WriteLine("Escoja uno de los valores");
                        }
                        }

                     break;
                     case 4:
                       System.Console.WriteLine("Gracias por utilizar el programa");
                     break;                   
                     default:
                        System.Console.WriteLine("Elige una de las opciones");
                     break;
                    }
        
                  
                  }while (opcion != 4);
                break;
               //PARTE DE PELICULAS
                case 2:
                   int opcion3 = 0;
                   do
                   {
                     Console.Clear();
                     Console.WriteLine("¡¡¡BIENVENIDO A PELICULAS!!!\n");
                     Console.WriteLine("Elige una opción: \n" +
                     "\n1. - Ver Listado de películas" +
                     "\n2. - Crear Película" +
                     "\n3. - Atrás \n");

                     opcion3 = Convert.ToInt16(Console.ReadLine());

                     switch(opcion3){
                       case 1:
                         Console.WriteLine("---------------VER LISTADO DE PELICULAS---------------\n");
                         for (int i = 0; i < contar; i++)
                         {
                           pelicula = crearpelicula[i];
                           System.Console.WriteLine( num + " " + " Nombre pelicula " + pelicula.nombre + " Tipo " + pelicula.tipo + " Género " + pelicula.genero + " Sinopsis " + pelicula.sinopsis +"\n");
                           num++;
                          }
                         num = 1;

                         Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                         Console.ReadKey();
                       break;
                  
                       case 2:
                         Console.WriteLine("---------------CREAR PELICULA---------------\n");
                         pelicula = new Peliculas();
                         crearpelicula[contar] = pelicula;
                         contar++; 

                         //FOR
                          for (int i = 0; i < contar; i++)
                         {
                           pelicula = crearpelicula[i];
                           System.Console.WriteLine("\n" +  num + " " + " Nombre pelicula " + pelicula.nombre + " Tipo " + pelicula.tipo + " Género " + pelicula.genero + " Sinopsis " + pelicula.sinopsis +"\n");
                           num++;
                          }
                         num = 1;

                         Console.WriteLine("\nPrecione enter si desea elegir otra opción");
                         Console.ReadKey();
                       break;

                       case 3:
                         System.Console.WriteLine("Gracias por utilizar el programa");
                         break;
                       default:
                          System.Console.WriteLine("Elige una de las opciones");
                       break;

                     
                      }

                    }while (opcion3 != 3);

                  break;
                
                
                  case 3:
                    Console.WriteLine("¡¡¡HASTA LA PROXIMA!!!");
                  break;

                  default:
                    System.Console.WriteLine("Elige uno de los valores");

                  break;
                  
              }

            }while (i1 != 3);

        }
    }
    

  //LISTA DE OBJETOS
  class lista
  {
    public string nombreUsuario;

    public string peliculaUsuario;

    public int cantidad;

    public string[] listas;
    public lista(string nombreUsuario, string peliculasUsuario, int cantidad)
    {
      this.nombreUsuario = nombreUsuario;
      //this.peliculaUsuario =  peliculaUsuario;       
      this.cantidad = cantidad;     
    }

    public lista(string nombreUsuario,string[] listas)
    {
      this.nombreUsuario = nombreUsuario;
      this.listas = listas;
    }
  }
}

