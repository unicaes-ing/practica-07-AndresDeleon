using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    class Práctica7_5
    {
        //Andrés Lemus 17/09/2019
        static void Main(string[] args)
        {
            Console.WriteLine("SUMA DE DOS ARREGLOS 3x3");
            Console.WriteLine();
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            for (int a = 0; a < 2; a++)
            {
                Console.WriteLine("ARREGLO #" + (a + 1));
                Console.WriteLine();
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write("Valor de la posición ({0},{1}): ", f + 1, c + 1);
                        if (a == 0)
                        {
                            array1[f, c] = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            array2[f, c] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                Console.Clear();
            }
            sumar(array1, array2);
            Console.ReadKey();
        }

        static void sumar(int[,] array1, int[,] array2)
        {
            int[,] arrSum = new int[3, 3];
            Console.WriteLine("ARREGLO RESULTANTE DE LA SUMA DE LOS DOS ARREGLOS");
            Console.WriteLine();
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    arrSum[f, c] = array1[f, c] + array2[f, c];
                    Console.Write(arrSum[f, c] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
