using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConvertor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Zadaj cislo v desiatkovej sustave do 1000> ");
            int desiatkova = Convert.ToInt32( Console.ReadLine()); //7
            int bin_9 = desiatkova/512;
            int bin_9z = desiatkova % 512;//512
            int bin_8 = bin_9z/256; //256
            int bin_8z = bin_9z % 256;
            int bin_7 = bin_8z / 128; //128
            int bin_7z = bin_8z % 128;
            int bin_6 = bin_7z / 64; //64
            int bin_6z = bin_7z % 64;
            int bin_5 = bin_6z / 32; //32
            int bin_5z = bin_6z % 32;
            int bin_4 = bin_5z / 16; //16
            int bin_4z = bin_5z % 16;
            int bin_3 = bin_4z / 8; //8
            int bin_3z = bin_4z % 8;
            int bin_2 = bin_3z / 4; //4
            int bin_2z = bin_3z % 4;
            int bin_1 = bin_2z / 2; //2
            int bin_1z = bin_2z % 2;
            int bin_0 = bin_1z; //1

            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", bin_9, bin_8, bin_7, bin_6, bin_5, bin_4, bin_3, bin_2, bin_1, bin_0);
            Console.ReadLine();

            
            // prevodnik z 10kovej sustavy na 2kovu do 1000 v desiatkovej - 1011110101, 8kovu 16kovu
            // menu s 3 moznostami 2,8,16
            //zadaj cislo v 10kovej sustave do 1000 =>  863
            // v 16kovej sustave je 863 rovne cislu 1de

            ////so zvyskom
            //int a = 7;
            //int b = 2;


            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);
            ////0000000111

        }
    }
}
