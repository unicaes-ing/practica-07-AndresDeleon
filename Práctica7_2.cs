using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    class Práctica7_2
    {
        //Andrés Lemus 11/09/2019
        static void Main(string[] args)
        {
            int par = 0, impar = 0;
            Console.Write("Cantidad de números enteros que desea agregar: ");
            int cant = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cant];
            Console.Clear();
            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Número #" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if ((numeros[i] % 2) == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Cantidad de números pares: " + par);
            Console.WriteLine("Cantidad de números impares: " + impar);
            Console.ReadKey();
        }
    }
}
