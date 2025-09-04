using System;
using System.Runtime.InteropServices;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // method - metot
            // erişim_belirleyici geri_dönüş_tipi metot_adı(parametreListesi/argüman)
            // {
            //    komutlar
            //    return;
            // }
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);

            int sonuc = Topla(a, b); //int sonuc = Topla(2, 3);
            Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar(); //örnek = instance
            ornek.EkranaYazdir(Convert.ToString(sonuc)); //.ToString() = int değeri stringe çevirir

            ornek.EkranaYazdir(Convert.ToString(a + b)); //a+b = 5
            int sonuc2 = ornek.ArttirveTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }
        static int Topla(int s1, int s2) //erişim belirleyici yok // geri dönüş tipi int
        {
            return s1 + s2; //return = geri dönüş 
        }
    }
    class Metotlar //sınıf dışında yap! // erişim belirleyici yok // geri dönüş tipi yok
    {
        public void EkranaYazdir(String veri) //void = geri dönüş yok. // public = erişim belirleyici
        {
            Console.WriteLine(veri); //parametre
        }
        public int ArttirveTopla(ref int s1, ref int s2) //parametre başına ref yazılırsa referans tip olur. //referans tip bellekteki adresi tutar.
        //int s1, int s2 = değer tip
        {
            s1 += 1;
            s2 += 1;
            return s1 + s2; //return = geri dönüş 
        }
    }
}