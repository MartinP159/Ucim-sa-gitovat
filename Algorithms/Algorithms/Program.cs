using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mena = { "Ivan", "Martin", "Jana","Jozo", "Anna" };

            int hladaneMeno = 13;

            BinarySearch(cisla, hladaneMeno);

        }

        private static void BinarySearch(int[] cisla, int hladaneCislo)
        {
            int start = 0;
            int konec = cisla.Length - 1;
            int stred = (start + konec) / 2;

            bool foundIt = false;

            while (!foundIt)
            {
                Console.WriteLine($"Zaciatocne cislo: {start}, Konecne cislo: {konec}, Stredne cislo: {stred}");
                if (cisla[stred] == hladaneCislo)
                {
                    foundIt = true;
                }
                if (cisla[stred] < hladaneCislo)
                {
                    start = stred + 1;
                }
                else if (cisla[stred] > hladaneCislo)
                {
                    konec = stred - 1;
                }
                stred = (konec + start) / 2;
            }
            Console.WriteLine($"Hladane cislo je: {hladaneCislo} a bolo najdene na pozicii: {stred}");
        }
    }
}
