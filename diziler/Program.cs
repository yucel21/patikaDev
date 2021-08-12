using System.Collections.Generic;
using System.Linq;


using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama

            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            //Klavyeden girilen n tane tam sayının ortalamasını hesaplayan program 

            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayısı giriniz: ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());

            }

            int toplam = 0;
            foreach (int sayi in sayiDizisi)
                toplam += sayi;
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);

        }
    }

    //hackerRank Ödevi
    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            float positiveCounter = 0, negativeCounter = 0, zeroCounter = 0;
            float arrayLength = arr.Count();

            foreach (int num in arr)
            {
                if (num > 0)
                    positiveCounter++;
                else if (num < 0)
                    negativeCounter++;
                else
                    zeroCounter++;
            }

            Console.WriteLine(positiveCounter / arrayLength);
            Console.WriteLine(negativeCounter / arrayLength);
            Console.WriteLine(zeroCounter / arrayLength);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
