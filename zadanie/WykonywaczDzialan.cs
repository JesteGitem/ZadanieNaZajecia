using System;
using System.Collections.Generic;

namespace zadanie
{
    public class WykonywaczDzialan
    {
        List<string> wyrazenie = new List<string>();
        public int indeksZeZnakiem;
        double pierwszaLiczba;
        double drugaLiczba;
        double wynikDzialania;
        string znak;
        public double ZwrocWynik(List<string> wyrazenie)
        {
            this.wyrazenie = wyrazenie;
            do
            {
                indeksZeZnakiem = ZnajdzZnak();
                PobierzDaneDoDzialania();
                WykonajDzialanie();
                ZapiszDaneDoListy();
            } while (indeksZeZnakiem != 0);
            return double.Parse(wyrazenie[0]);
        }
        public int ZnajdzZnak()
        {
            int IndeksDlugosciWyrazenia = 0;
            foreach (var item in wyrazenie)
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
            double pierwszaLiczba = double.Parse(wyrazenie[indeksZeZnakiem - 1]);
            double drugaLiczba = double.Parse(wyrazenie[indeksZeZnakiem + 1]);
            string znak = wyrazenie[indeksZeZnakiem];
            this.pierwszaLiczba = pierwszaLiczba;
            this.drugaLiczba = drugaLiczba;
            this.znak = znak;
        }
        private void WykonajDzialanie()
        {
            switch (znak)
            {
                case "*":
                    wynikDzialania = pierwszaLiczba * drugaLiczba;
                    break;
                case "+":
                    wynikDzialania = pierwszaLiczba + drugaLiczba;
                    break;
                case "-":
                    wynikDzialania = pierwszaLiczba - drugaLiczba;
                    break;
                case "/":
                    wynikDzialania = pierwszaLiczba / drugaLiczba;
                    break;
            }
        }
        private void ZapiszDaneDoListy()
        {
            wyrazenie[indeksZeZnakiem - 1] = wynikDzialania.ToString();
            wyrazenie.RemoveAt(indeksZeZnakiem);
            wyrazenie.RemoveAt(indeksZeZnakiem + 1);
        }



    }
}