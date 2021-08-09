using System;

namespace tipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Implicit Conversion(Bilinçsiz Donusum)
            Düşük kapasiteli bir değişkenin kendinden daha büyük bir değişkene dönüştürülmesi
            Bunun için herhangi bir dönüşüm kodu yazmaya gerek yok.Bunun yerine makina bizim yerimize bu kodu yazıyor */


            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h: " + h);

            float i = h;
            Console.WriteLine("i: " + i);

            string e = "Yucel";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g: "+g);


            //Explicit Conversion (Bilinçli Donusum)
            //Burda biz csharp'a parse veya convert kodlarını yazıyoruz

            Console.WriteLine("***** Explicit Conversion *****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: "+y);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);

            // *** To String Methodu ***
            Console.WriteLine("***** To String Methodu *****");
            
            int xx = 4;
            string yy = xx.ToString();
            Console.WriteLine("yy: " + yy);

            //System.Convert
            Console.WriteLine("***** System.Convert sınıfı *****");

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+Toplam);

            //Parse
            //Parse String ifadeleri dönüştürmek için kullanılıyor ve her zaman string bir ifade alır

            Console.WriteLine("***** Parse *****");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1=Int32.Parse(metin1);
            Console.WriteLine("rakam1: " + rakam1);
            double1=Double.Parse(metin2);
            Console.WriteLine("double1: " + double1);
        }
    }
}
