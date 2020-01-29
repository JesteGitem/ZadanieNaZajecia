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
            do
            {
                nrIndeksuZnakuNaLiscie = UstawIntNaIndeksieZnaku();
                PobierzDaneDoDzialania();
                WykonajDzialanie();
                ZapiszDaneDoListy();
                UsunzListyNiepotrzebneIndeksy();
            } while (nrIndeksuZnakuNaLiscie != 0);
            return double.Parse(listaLiczbiZnakow[0]);
        }
        public void PodajPodzielonyWyraz(List<string> tabelaWyrazen)
        {
            this.listaLiczbiZnakow = tabelaWyrazen;
        }
        private int UstawIntNaIndeksieZnaku()
        {
            int IndeksDlugosciWyrazenia = 0;
            foreach (var item in listaLiczbiZnakow)
            {
                if (item == "/" || item == "*" || item == "+" || item == "-")
                {
                    return IndeksDlugosciWyrazenia;
                }
                IndeksDlugosciWyrazenia++;
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
            listaLiczbiZnakow.RemoveAt(nrIndeksuZnakuNaLiscie + 1);
        }
    }
}