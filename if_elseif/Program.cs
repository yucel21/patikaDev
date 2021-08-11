using System;

namespace if_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time>=6 && time<12)
            {
                Console.WriteLine("Günaydın");
            }
            else if(time >= 12 && time < 18)
            {
                Console.WriteLine("İyi Günler");
            }
            else
            {
                Console.WriteLine("İyi Geceler");
            }

            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler!";

            sonuc = time >= 6 && time < 12 ? "Günaydın!" : time >= 12 && time < 18 ? "İyi Günler!!" : "İyi Geceler";

            Console.WriteLine(sonuc);
        }
    }
}
