using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace zadanie
{
    public class DzielenieWyrazow
    {
        List<string> podzielonyWyraz = new List<string>();
        string wyrazDoPodzielenia;
        public List<string> ZwrocPodzielonyWyraz()
        {
            PodzielWyrazenie();
            return podzielonyWyraz;
        }
        public void WprowadzWyrazDoPodzielenia(string wyraz)
        {
            wyrazDoPodzielenia = wyraz;
        }
        private void PodzielWyrazenie()
        {
            List<string> ListaLiczIZnakow = new List<string>();
            string CiagDoZapisania = "";
            int ZliczanieDlugosci = 1;
            foreach (var item in wyrazDoPodzielenia)
            {
                int liczba;
                if (wyrazDoPodzielenia.Length == ZliczanieDlugosci)
                {
                    CiagDoZapisania += item.ToString();
                    ListaLiczIZnakow.Add(CiagDoZapisania);
                }
                if (int.TryParse(item.ToString(), out liczba))
                {
                    CiagDoZapisania += item.ToString();
                }
                else
                {
                    ListaLiczIZnakow.Add(CiagDoZapisania);
                    ListaLiczIZnakow.Add(item.ToString());
                    CiagDoZapisania = "";
                }
                ZliczanieDlugosci++;
            }
            podzielonyWyraz = ListaLiczIZnakow;
        }
    }
}