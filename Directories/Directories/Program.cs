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
            string[] textToWrite =
            {
                "dsad sa   fdsfsd",
                "fsdds sdf sd  sdfdfg",
            };
            
            string fileName = "test.txt";

            FileInfo file = new FileInfo(fileName);

            if (file.Exists)
            {
                file.Delete();
                file.Create().Close();
            }
            else
            {
                file.Create().Close();
            }

            using (StreamWriter sw = file.AppendText())
            {
                foreach (var item in textToWrite)
                {
                    sw.WriteLine(item);
                }
            }

            using (StreamReader sr = file.OpenText())
            {
                string line = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    System.Console.WriteLine(sr.ReadLine());
                }

            }
        }   


    }
}
