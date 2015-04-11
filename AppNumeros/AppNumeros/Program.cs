using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeros
{
    class Program
    {
        /*Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.*/

        static void Main(string[] args)
        {
            int numeros, contador, contador2=0, contador3=0;
            float numer;
            Console.WriteLine("Digite los Numeros:");
            numeros = int.Parse(Console.ReadLine());
            for (contador = 1; contador <= numeros; contador++)
            {
                Console.WriteLine("Digite el Numero"+contador);
                numer = float.Parse(Console.ReadLine());
               
              
                if (numer >= 1000)
                {
                    contador2++;
                }
                else
                {
                    contador3++;
                }

            }
            Console.WriteLine("Las Numeros Mayores a 1000 son:" + contador2);
            Console.WriteLine("Las Numeros Menores a 1000 son:" + contador3);
            Console.ReadKey();
        }
    }
}
