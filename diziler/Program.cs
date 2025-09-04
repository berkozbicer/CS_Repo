using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array declaration and initialization
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };
            int[] dizi;
            dizi = new int[5];

            // Assigning values to the array
            renkler[0] = "Mavi";
            dizi[3] = 10;

            // Getting the length of the array
            Console.WriteLine(hayvanlar.Length);

            // Iterating through the array using for loop
            for (int i = 0; i < hayvanlar.Length; i++)
            {
                Console.WriteLine(hayvanlar[i]);
            }

            // Iterating through the array using foreach loop
            foreach (var hayvan in hayvanlar)
            {
                Console.WriteLine(hayvan);
            }
            Console.WriteLine("Lütfen dizinin uzunluğunu giriniz:");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz:", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama: " + toplam / diziUzunlugu);
            Console.ReadKey();
        }
    }
}