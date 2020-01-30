using System;
using System.Collections.Generic;

namespace zadanie
{
    public class WykonanieDzialan
    {
        List<string> listaLiczbiZnakow = new List<string>();
        int nrIndeksuZnakuNaLiscie;
        double pierwszaLiczba;
        double drugaLiczba;
        double wynikArytmetycznejOperacji;
        string znakDzialania;
        public double ZwrocWynik()
        {
            nrIndeksuZnakuNaLiscie = UstawIntNaIndeksieZnaku();
            while (nrIndeksuZnakuNaLiscie != 0)
            {
                PobierzDaneDoDzialania();
                WykonajDzialanie();
                ZapiszDaneDoListy();
                UsunzListyNiepotrzebneIndeksy();
                nrIndeksuZnakuNaLiscie = UstawIntNaIndeksieZnaku();
            }
            return double.Parse(listaLiczbiZnakow[0]);
        }
        public void PodajPodzielonyWyraz(List<string> tabelaWyrazen)
        {
            this.listaLiczbiZnakow = tabelaWyrazen;
        }
        private int UstawIntNaIndeksieZnaku()
        {
            int indeksDlugosciWyrazenia = 0;
            int plusLubMinus = 0;
            foreach (var item in listaLiczbiZnakow)
            {
                if (item == "+" || item == "-")
                {
                    plusLubMinus = indeksDlugosciWyrazenia;
                }
                if(item=="*" || item == "/")
                {
                    return indeksDlugosciWyrazenia;
                }
                indeksDlugosciWyrazenia++;
            }
            if (plusLubMinus!=0)
            {
                return plusLubMinus;
            }
            return 0;
        }
        private void PobierzDaneDoDzialania()
        {
            double pierwszaLiczba = double.Parse(listaLiczbiZnakow[nrIndeksuZnakuNaLiscie - 1]);
            double drugaLiczba = double.Parse(listaLiczbiZnakow[nrIndeksuZnakuNaLiscie + 1]);
            string znak = listaLiczbiZnakow[nrIndeksuZnakuNaLiscie];
            this.pierwszaLiczba = pierwszaLiczba;
            this.drugaLiczba = drugaLiczba;
            this.znakDzialania = znak;
        }
        private void WykonajDzialanie()
        {
            switch (znakDzialania)
            {
                case "*":
                    wynikArytmetycznejOperacji = pierwszaLiczba * drugaLiczba;
                    break;
                case "+":
                    wynikArytmetycznejOperacji = pierwszaLiczba + drugaLiczba;
                    break;
                case "-":
                    wynikArytmetycznejOperacji = pierwszaLiczba - drugaLiczba;
                    break;
                case "/":
                    wynikArytmetycznejOperacji = pierwszaLiczba / drugaLiczba;
                    break;
            }
        }
        private void ZapiszDaneDoListy()
        {
            listaLiczbiZnakow[nrIndeksuZnakuNaLiscie - 1] = wynikArytmetycznejOperacji.ToString();
        }
        private void UsunzListyNiepotrzebneIndeksy()
        {
            listaLiczbiZnakow.RemoveAt(nrIndeksuZnakuNaLiscie);
            listaLiczbiZnakow.RemoveAt(nrIndeksuZnakuNaLiscie);
        }
    }
}