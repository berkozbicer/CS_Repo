using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz:");
            int girilenSayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= girilenSayi; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("İşlem tamamlandı.");

            // 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
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
            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

            // break, continue
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1; i <= 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
            Console.WriteLine("İşlem tamamlandı."); 
        }
    }
}