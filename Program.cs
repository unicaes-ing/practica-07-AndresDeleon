using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    class Program
    {
        //Andrés Lemus 11/09/2019
        static void Main(string[] args)
        {
            int men = 0, may = 0;
            Console.WriteLine("Ingrese la cantidad de personas que desea agregar edad");
            int cant = Convert.ToInt32(Console.ReadLine());
            int[] edades = new int[cant];
            for (int i = 0; i < cant; i++)
            {
                Console.Clear();
                Console.Write("Edad de la persona #" + (i + 1) + ": ");
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades[i] >= 18)
                {
                    may++;
                }
                else
                {
                    men++;
                }
            }
            Console.Clear();
            Console.WriteLine("Cantidad de personas mayores de edad: " + may);
            Console.WriteLine("Cantidad de personas menores de edad: " + men);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
