using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForeach
{
    class Program
    {
        /*Crear un vector de n elementos de tipo entero (n se ingresa por teclado) 
            * Mostrar cuantos elementos son superiores a 100 (emplear el foreach para recorrer el vector).*/

        static void Main(string[] args)
        {
            int numero=0, contador=0;
            int[] vector;
            Console.WriteLine("Digite Numero de elementos del Vector");
            numero = int.Parse(Console.ReadLine());
            vector = new int[numero];
            for(int contador1=0; contador1<numero; contador1++)   
            {      
                Console.WriteLine("Digite elemento del vector");
                vector[contador1]=int.Parse(Console.ReadLine());
            }
            foreach (int recorrido in vector) 
            {
                if (recorrido > 100) 
                {
                    contador++;
                }
            }

            Console.WriteLine("Los Numero superiores a 100 son:" + contador);
            Console.ReadKey();

        }
    }
}
