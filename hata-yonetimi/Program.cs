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
        }
    }
}