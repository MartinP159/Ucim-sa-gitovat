using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis svoje meno:");
            PrintName(Console.ReadLine());
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Hello,{0}", name);
        }
    }
}
