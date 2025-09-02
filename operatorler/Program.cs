using System;

namespace Operatorler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Atama ve işlemli atama operatörleri
            int x = 3;
            int y = 3;
            y = y + 2;
            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

        //     // Aritmetik Operatörler
        //     int a = 10;
        //     int b = 5;

        //     Console.WriteLine("Aritmetik Operatörler:");
        //     Console.WriteLine($"Toplama: {a} + {b} = {a + b}");
        //     Console.WriteLine($"Çıkarma: {a} - {b} = {a - b}");
        //     Console.WriteLine($"Çarpma: {a} * {b} = {a * b}");
        //     Console.WriteLine($"Bölme: {a} / {b} = {a / b}");
        //     Console.WriteLine($"Modül: {a} % {b} = {a % b}");

        //     // Karşılaştırma Operatörleri
        //     Console.WriteLine("\nKarşılaştırma Operatörleri:");
        //     Console.WriteLine($"{a} == {b}: {a == b}");
        //     Console.WriteLine($"{a} != {b}: {a != b}");
        //     Console.WriteLine($"{a} > {b}: {a > b}");
        //     Console.WriteLine($"{a} < {b}: {a < b}");
        //     Console.WriteLine($"{a} >= {b}: {a >= b}");
        //     Console.WriteLine($"{a} <= {b}: {a <= b}");

        //     // Mantıksal Operatörler
        //     bool x = true;
        //     bool y = false;

        //     Console.WriteLine("\nMantıksal Operatörler:");
        //     Console.WriteLine($"{x} && {y}: {x && y}");
        //     Console.WriteLine($"{x} || {y}: {x || y}");
        //     Console.WriteLine($"!{x}: {!x}");
         }
    }
}