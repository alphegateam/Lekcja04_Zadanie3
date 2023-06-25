using System;
using System.Text;

namespace Zadanie_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lekcja 4, zadanie dowowe 3.
            // Przekątna prostokąta = √(a² + b²)
            string a, b;
            int boka, bokb;
            double wynik;

            Console.WriteLine("Podaj długość kobu a: ");
            a = Console.ReadLine();
            Console.WriteLine("\n Podaj długość boku b: ");
            b = Console.ReadLine();
            Int32.TryParse(a, out boka);
            Int32.TryParse(b, out bokb);
            wynik = Math.Sqrt(Math.Pow(boka, 2) + Math.Pow(bokb, 2));

            Console.WriteLine($"\n Oto długość przekątnej podanego prostokąta: {wynik}");
 
        }
    }
}


