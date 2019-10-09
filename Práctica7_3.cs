using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica7
{
    class Práctica7_3
    {
        //Andrés Lemus 11/09/2019
        static int jug = 0;
        static string[] nomJug = new string[jug];
        static void Main(string[] args)
        {
            Console.WriteLine("LISTA DE JUGADORES DE LA LIGA MORADA LATINOAMERICANA");
            Console.WriteLine();
            Console.WriteLine("Cantidad de Equipos a Participar en la Liga");
            int cantEq = Convert.ToInt32(Console.ReadLine());
            string[] nomEq = new string[cantEq];
            int[] cantJug = new int[cantEq];

            for (int i = 0; i < cantEq; i++)
            {
                Console.Clear();
                Console.WriteLine("Nombre del Equipo #" + (i + 1));
                nomEq[i] = Console.ReadLine();
                Console.WriteLine("Cantidad de Jugadores del Equipo \"" + nomEq[i] + "\":");
                jug = Convert.ToInt32(Console.ReadLine());
                nomJug = new string[jug];
                for (int p = 0; p < jug; p++)
                {
                    Console.Write("Nombre del Jugador #" + (p + 1) + ": ");
                    nomJug[p] = Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine("LIGA MORADA LATINOAMERICADA");
            Console.WriteLine();
            foreach (string nom in nomEq)
            {
                int j = 0;
                Console.WriteLine("Equipo \"" + nom + "\"");
                foreach (string n in nomJug)
                {
                    Console.WriteLine("Jugador #" + (j + 1) + ": " + n);
                    j++;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
