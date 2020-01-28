using System;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string wyrazenie = "55+51-10/2*2";
                Kalkulator kalkulator = new Kalkulator();
                double wynik = kalkulator.Oblicz(wyrazenie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
