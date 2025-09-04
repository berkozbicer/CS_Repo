using System;

namespace hata_yonetimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girdiğiniz sayı: " + sayi);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hata: Geçersiz format. Lütfen bir sayı giriniz.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Hata: Sayı çok büyük veya çok küçük.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Beklenmeyen bir hata oluştu.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program sonlandı.");
            }
            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("abc");
                int a = int.Parse("-2000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Hata: Boş değer girdiniz.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Hata: Geçersiz format.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Hata: Sayı çok büyük veya çok küçük.");
                Console.WriteLine("Detaylar: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("İkinci işlem sonlandı.");
            }
        }
    }
}