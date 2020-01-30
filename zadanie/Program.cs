using System;

namespace zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string wyrazenie = "34+34*54/11*3+4+3";
                Kalkulator kalkulator = new Kalkulator();
                double wynik = kalkulator.Oblicz(wyrazenie);
                Console.WriteLine(wynik);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
