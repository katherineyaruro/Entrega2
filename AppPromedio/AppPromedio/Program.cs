using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPromedio
{
    class Program
    {
        /* Escribir un programa que solicite la carga de números por teclado, obtener su promedio. 
         * Finalizar la carga de valores cuando se cargue el valor 0.*/

        static void Main(string[] args)
        {
            int numero, contador=0;
            do
            {
                Console.WriteLine("Digite un Numero");
                numero = int.Parse(Console.ReadLine());
                contador = contador + numero;
            }
            while (numero != 0);
            Console.WriteLine("La suma es:" + contador);
            Console.ReadKey();
        }
    }
}
