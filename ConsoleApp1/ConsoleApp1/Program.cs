using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        //konvertovat male pismena abecedy na velke cez unicode
        Console.WriteLine("Zadajte znak pre konverziu>");
        int ascii = Console.Read();

        if (ascii > 64 && ascii < 91)
        {


            int pismeno = ascii + 32;

            char vysledok = Convert.ToChar(pismeno);
            Console.WriteLine(vysledok);



        }

        else if (ascii > 96 && ascii < 123)
        {


            int pismeno = ascii - 32;

            char vysledok = Convert.ToChar(pismeno);
            Console.WriteLine(vysledok);


        }
        else {
            Console.WriteLine("Zadali ste nespravny znak!");
        }


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

