using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denune_Muhammad_Kaisar_K_20210140050_Exe2
{
    class Program
    {
        //Deklarasi
        private int[] den = new int[25];
        private int n;

        public void read()
        {
            while (true)
            {

                Console.WriteLine("Masukkan banyaknya element: ");
                string s = Console.ReadLine();
                //Mengubah string ke int
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 25))
                    break;
                else
                    Console.WriteLine("\nMaksimal element adalah 25.\n");
            }
            Console.WriteLine("------------------");
            Console.WriteLine(" Masukkan element ");
            Console.WriteLine("------------------");

            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                den[i] = Int32.Parse(s1);
            }
        }
       

        static void Main(string[] args)
        {
        }
    }
}
