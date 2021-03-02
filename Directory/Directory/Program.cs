using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDir =  Directory.GetCurrentDirectory();
            string diresctoryOne = @"\textfiles";

            Console.WriteLine(currentDir);
            Console.WriteLine(Directory.GetCurrentDirectory());

            Directory.CreateDirectory(currentDir + diresctoryOne);
        }
    }
}
