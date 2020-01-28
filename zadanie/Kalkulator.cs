using System;
using System.Collections.Generic;

namespace zadanie
{
    public class Kalkulator
    {
        public double Oblicz(string wyrazenie)
        {
            List<string> TabelaWyrazen = new List<string>();
            SprawdzaczPoprawnosciDanych tylkoPrawilneDzialania = new SprawdzaczPoprawnosciDanych();
            tylkoPrawilneDzialania.SprawdzPoprawnosc(wyrazenie);
            DzielnikWyrazow szatkownica = new DzielnikWyrazow();
            TabelaWyrazen = szatkownica.PodzielWyrazenie(wyrazenie);
            WykonywaczDzialan obliczarka = new WykonywaczDzialan();
            double wynik = obliczarka.ZwrocWynik(TabelaWyrazen);
            return wynik;
        }
    }
}