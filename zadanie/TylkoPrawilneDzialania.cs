using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace zadanie
{
    public class TylkoPrawilneDzialania
    {
        string wyrazenie;
        public void SprawdzPoprawnosc(string wyrazenie)
        {
            PoczatekiKoniecToCyfra(wyrazenie);
            TylkoCyfryiZnaki(wyrazenie);
            DwaZnakiObokSiebie(wyrazenie);
        }
        public void PoczatekiKoniecToCyfra(string wyrazenie)
        {
            Regex reg = new Regex(@"^[0-9]+.+\d+$");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("Koniec/poczatek to nie cyfra");
        }
        public void TylkoCyfryiZnaki(string wyrazenie)
        {
            Regex reg = new Regex(@"^[0-9*/+-]+$");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("bledny znak");
        }
        public void DwaZnakiObokSiebie(string wyrazenie)
        {
            Regex reg = new Regex(@"[*/+-]{2,}");
            if (reg.IsMatch(wyrazenie))
                throw new Exception("za duza liczba znakow obok siebie");
        }
        public void PrzynajmniejJednoDzialanie(string wyrazenie)
        {
            Regex reg = new Regex(@".+[*/+-]+.+");
            if (!reg.IsMatch(wyrazenie))
                throw new Exception("za malo wyrazen");
        }

    }
}
