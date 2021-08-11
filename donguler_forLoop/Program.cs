using System;

namespace donguler_forLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır
            Console.WriteLine("Bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam += i;
                }
                else
                {
                    ciftToplam += i;
                }
            }

            Console.WriteLine("Tek Toplam: " + tekToplam);
            Console.WriteLine("Çift Toplam: " + ciftToplam);

            //break, continue
            Console.WriteLine("***Break***");
            for (int j = 1; j < 10; j++)
            {
                if (j == 4)
                    break;
                Console.WriteLine(j);

            }

            Console.WriteLine("***Continue***");
            for (int k = 1; k < 10; k++)
            {
                if (k == 4)
                    continue;
                Console.WriteLine(k);

            }
        }
    }

    /* Örnek:
     *         #
     *        ##
     *       ###
     *      ####
     * Şeklinde bir görüntü elde etmek için aşağıdaki algoritma yazılmıştır
     */
    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }

    class Result
    {

        /*
         * Complete the 'staircase' function below.
         *
         * The function accepts INTEGER n as parameter.
         */

        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
        }

    }
}
