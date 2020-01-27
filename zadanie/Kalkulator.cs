using System;
using System.Collections.Generic;

namespace zadanie
{
    public class Kalkulator
    {
        public double Oblicz(string wyrazenie)
        {
            List<string> TabelaWyrazen = new List<string>();
            TylkoPrawilneDzialania sprawdz = new TylkoPrawilneDzialania();
            sprawdz.SprawdzPoprawnosc(wyrazenie);
            Szatkownica podziel = new Szatkownica();
             TabelaWyrazen = podziel.PodzielWyrazenie(wyrazenie);
            return 1;
        }
    }
}