using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    //Andrés Lemus 17/09/2019
    class Práctica7_6
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool rep = false;
            Console.WriteLine("ALMACENAR DE NÚMEROS ALEATORIOS EN UN ARREGLO 6x6");
            Console.WriteLine();
            int[,] arreglo = new int[6, 6];
            for (int f = 0; f < 6; f++)
            {
                for (int c = 0; c < 6; c++)
                {
                    do
                    {
                        int num = rnd.Next(10, 100);
                        for (int x = 0; x < 6; x++)
                        {
                            for (int y = 0; y < 6; y++)
                            {
                                if (num == arreglo[x, y])
                                {
                                    rep = true;
                                }
                                else
                                {
                                    arreglo[f, c] = num;
                                    rep = false;
                                }
                            }
                        }
                    } while (rep == true);
                }
            }

            for (int a = 0; a < 6; a++)
            {
                for (int b = 0; b < 6; b++)
                {
                    Console.Write(arreglo[a, b] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
