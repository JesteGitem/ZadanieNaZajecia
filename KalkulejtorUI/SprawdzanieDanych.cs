using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace zadanie
{
    public class SprawdzanieDanych
    {
        string wyrazenie;
        public void WprowadzDane(string wyrazenie)
        {
            this.wyrazenie = wyrazenie;
        }
        public void SprawdzPoprawnosc()
        {
            PoczatekiKoniecToCyfra(wyrazenie);
            TylkoCyfryiZnaki(wyrazenie);
            DwaZnakiObokSiebie(wyrazenie);
            PrzynajmniejJednoDzialanie(wyrazenie);
        }
        private void PoczatekiKoniecToCyfra(string wyrazenie)
        {
            Regex reg = new Regex(@"^[0-9]+.+\d+$");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("Koniec/poczatek to nie cyfra");
        }
        private void TylkoCyfryiZnaki(string wyrazenie)
        {
            Regex reg = new Regex(@"^[0-9*/+-]+$");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("bledny znak");
        }
        private void DwaZnakiObokSiebie(string wyrazenie)
        {
            Regex reg = new Regex(@"[*/+-]{2,}");
            if (reg.IsMatch(wyrazenie))
                throw new Exception("za duza liczba znakow obok siebie");
        }
        private void PrzynajmniejJednoDzialanie(string wyrazenie)
        {
            Regex reg = new Regex(@".+[*/+-]+.+");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("za malo wyrazen");
        }
    }
}
