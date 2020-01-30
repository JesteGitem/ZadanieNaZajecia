using System;
using System.Collections.Generic;
using zadanie;

namespace KalkulejtorUI
{
    public static class Kalkulator
    {
        public static double Oblicz(string wyrazenie)
        {
            SprawdzanieDanych sprawdzaniedanych = new SprawdzanieDanych();
            DzielenieWyrazow dzielenieWyrazow = new DzielenieWyrazow();
            WykonanieDzialan wykonianieDzialan = new WykonanieDzialan();
            List<string> TabelaWyrazen = new List<string>();
            sprawdzaniedanych.WprowadzDane(wyrazenie);
            sprawdzaniedanych.SprawdzPoprawnosc();
            dzielenieWyrazow.WprowadzWyrazDoPodzielenia(wyrazenie);
            TabelaWyrazen = dzielenieWyrazow.ZwrocPodzielonyWyraz();
            wykonianieDzialan.PodajPodzielonyWyraz(TabelaWyrazen);
            double wynik = wykonianieDzialan.ZwrocWynik();
            return wynik;
        }
    }
}