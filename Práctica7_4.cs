using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    class Práctica7_4
    {
        //Andrés Lemus 17/09/2019
        static void Main(string[] args)
        {
            Console.WriteLine("MATRIZ DE 5x5");
            Console.WriteLine();
            int[,] matriz = new int[5, 5];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.WriteLine("Ingrese el valor de la posición ({0},{1}): ", f + 1, c + 1);
                    matriz[f, c] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            trans(matriz);
            Console.ReadKey();
        }

        static void trans(int[,] matriz)
        {
            Console.WriteLine("MATRIZ TRANSVERSA");
            Console.WriteLine();
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[c, f] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
