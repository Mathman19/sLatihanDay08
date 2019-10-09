using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string huruf1 = "selamat pagi";
                string huruf2 = "selamat siang";
                string huruf3 = "selamat malam";
                string huruf4 = "selamat datang";

                int angka1 = 1;
                int angka2 = 6;

                int[] angka3 = { 1, 2, 3, 4, 5, 6 };

                int call = hitung(angka1, angka2);
                cetak(angka3, angka2);

                Console.WriteLine(huruf1);
                Console.WriteLine(huruf2);
                Console.WriteLine(huruf3);
                Console.WriteLine(huruf4);
                Console.WriteLine(call);
            }
            catch (Exception)
            {

                throw;
            }

            

            Console.ReadKey();
        }
        public static int hitung(int a, int b)
        {
            int result = a + b;
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine("baris ke " + i);
            }

            return result;
        }
        public static void cetak(int[] a, int ang)
        {
            for (int i = 0; i < ang; i++)
            {
                Console.WriteLine("value array "+ i + "is" + a[i]);
            }
        }
    }
}
