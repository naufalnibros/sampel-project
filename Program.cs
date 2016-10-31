using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        /* Pada program ini menjelaskan bahwa
                       Variabel yang dideklarasikan di dalam suatu blok tidak akan dikenali oleh
                       blok blok yang bersangkutan*/

        //kita mulai program nya 

        static void Program1()
        {

            int a = 10;

            Console.WriteLine("Dalam method Program1");
            Console.WriteLine("a = "+ a);
            Console.WriteLine("n = "+ n); //pada console ini tidak akan berjalan. karena, variabel "n" tidak ada dalam method Program1()
            Console.WriteLine("I = "+ i); //pada console ini tidak akan berjalan. karena, variabel "i" tidak ada dalam method Program1()
            Console.WriteLine();
            
        }

        static void Program2()
        {
            int n = 12;
            Console.WriteLine("Dalam method Program1");
            Console.WriteLine("a = " + a);//pada console ini tidak akan berjalan. karena, variabel "n" tidak ada dalam method Program2()
            Console.WriteLine("n = " + n); 
            Console.WriteLine("I = " + i);//pada console ini tidak akan berjalan. karena, variabel "i" tidak ada dalam method Program2()
            Console.WriteLine();


        }
    }
}
