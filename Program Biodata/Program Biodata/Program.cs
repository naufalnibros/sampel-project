using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_Biodata
{
    class Program
    {
        static void Main()
        {

            string nama, NamaPanggilan, alamat, umur, number;

            nama = "";
            NamaPanggilan = "";
            alamat = "";
            umur = "";
            number = "";
            while (nama == "") {

                Console.Write("Nama\t:");
                nama = Console.ReadLine();

                Console.Write("Nama Panggilan\t: ");
                NamaPanggilan = Console.ReadLine();

                Console.Write("Alamat\t:");
                alamat = Console.ReadLine();

                Console.Write("Umur\t:");
                umur = Console.ReadLine();

                Console.Write("Nomer Telp\t:");
                number = Console.ReadLine();


                if (nama == "")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Silahkan Lengkapi Biodata Terlebih Dahulu");
                }

            }

            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("===============");
            Console.WriteLine("PROGRAM BIODATA");
            Console.WriteLine("===============");
            Console.WriteLine("Assalamu’alaikum.Let me introduce my self. My name is" + nama + ", but you can call me " + NamaPanggilan + "\nI was born in " + alamat + " and I am" + umur + " years old. I am very glad if you want to invite my house in So don’t forget to call me before with the (" + number + ") Thank you");
        }
    }

  
}
