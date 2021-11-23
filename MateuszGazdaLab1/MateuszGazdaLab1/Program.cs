using System;

namespace MateuszGazdaLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Wprowadź tekst: ");
            string tekst = Console.ReadLine();

            Console.Write("Wprowadź pierwszą liczbę: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Wprowadź drugą liczbę: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Twój tekst to: " + tekst);
            Console.WriteLine("Twoja pierwsza liczba to " + a);
            Console.WriteLine("Twoja druga liczba to " + b);

            Console.WriteLine($"{a} + {b} = {a+b}");
            Console.WriteLine($"{a} - {b} = {a-b}");
            Console.WriteLine($"{a} * {b} = {a*b}");
            Console.WriteLine($"{a} / {b} = {a/b}");
        }
    }
}
