using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramCharracter
{
    class Program
    {
        static void Main()
        {

            char c;
            string input;

            Console.Write("Masukkan sebuah karakter ");
            input = Console.ReadLine();

            if (char.TryParse(input, out c)) {
                 if (c == 'a' || c == 'A' ||
                     c == 'i' || c == 'I' ||
                     c == 'u' || c == 'U' ||
                     c == 'e' || c == 'E' ||
                     c == 'o' || c == 'O')
                {
                    Console.WriteLine("Anda Memasukkan Huruf Fokal");
                }else{
                    Console.WriteLine("Karakter yang Anda Masukkan Bukan Huruf Fokal");
                     }

            }else{

                Console.WriteLine("Karakter yang Anda Masukkan tidak dapat di konversi ke tipe Char"); // ditanyakan?? fungsinya console ini utk apa ya?
            }

            Console.ReadLine();
        }
    }
}
