using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAcomulado
{
    class Program
    {
        /*Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 
         * (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e informar 
         * si dicho valor es cero, mayor a cero o menor a cero.*/

        static void Main(string[] args)
        {
            int numero = 0, suma = 0;
            do
            {
                Console.WriteLine("Digite Numero");
                numero = int.Parse(Console.ReadLine());
               if (numero==9999)
               {
                   break;
               }
                suma+=numero;
            }
            while (numero != 9999);
            Console.WriteLine("La Suma:" + suma);
            if (suma == 0)
            {
                Console.WriteLine("La suma es igual a cero");
            }
            else if (suma > 0)
            {
                Console.WriteLine("La suma es mayor a cero");
            }
            else
            {
                Console.WriteLine("La suma es menor a cero");
            }
            Console.ReadKey();
        }
    }
}
