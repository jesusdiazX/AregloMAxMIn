using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AregloMAxMIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo;
            int[,] ArregloOrderby;
           
            int valorEscrito = 0;
            Console.WriteLine("Cuantos numeros Contendr el  arreglo ?");
            valorEscrito = int.Parse(Console.ReadLine());
            Arreglo = new  int[valorEscrito];
            ArregloOrderby = new  int[2,valorEscrito] ;
          

            for (int i = 0; i < valorEscrito; i++)
            {
                Console.Write("Escribe el valor  para elemento {0}: ", i);

                 Arreglo[i] = int.Parse(Console.ReadLine());
                Arreglo.OrderBy(x => x).ToList();

            }

            int v, max = Arreglo[0], min = Arreglo[0];

            for (int i = 0; i < Arreglo.Length; i++)
            {
                if (Arreglo[i] > max)

                    max = Arreglo[i];


                else if (Arreglo[i] < min)

                    min = Arreglo[i];
            }

             int[] Array = Arreglo.OrderBy(x => x).ToArray();



            for (int i = 0; i < 1; i++)
            {
                for (int c = 0; c < Array.Length ; c++)
                {

                    ArregloOrderby[i,c]= Array[c];

                    Console.Write("  " + ArregloOrderby[i,c]);
                  


                }

            }



            Console.Write("\n\n Valor  Maximo del  arreglo es: " + max);
            Console.Write("\n\n Valor menor del  arreglo es: " + min);

           

            Console.ReadKey();


            //for (int i = 0; i < Arreglo.Length; i++)
            //{
            //    Console.Write("Escribe el valor  para elemento {0}: {1} ", Arreglo[i]);

            //}
            //// Console.WriteLine("Elemento {0}: {1}", i, nombres[i]);
            // string a = Console.ReadLine();

        }
    }
}
