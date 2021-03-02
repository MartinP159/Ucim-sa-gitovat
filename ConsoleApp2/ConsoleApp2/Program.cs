using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] pole = new int[8, 8];
            Random cislo = new Random();

            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    //pole[j, i] = Convert.ToInt32((8,8));
                    pole[j,i] = cislo.Next(0,9);

                }
            }
            for (int j = 0; j < pole.GetLength(1); j++)
            {
                for (int i = 0; i < pole.GetLength(0); i++)
                {
                    Console.Write(pole[j,i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
