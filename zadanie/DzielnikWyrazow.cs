using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace zadanie
{
    public class DzielnikWyrazow
    {
        public List<string> PodzielWyrazenie(string wyrazenie)
        {
         
            List<string> WynikDzielenia = new List<string>();
            string CoMamWrzucic = "";
            int ZliczanieDlugosci = 1;
            foreach (var item in wyrazenie)
            {
                int liczba;
                if (wyrazenie.Length == ZliczanieDlugosci)
                {
                    CoMamWrzucic += item.ToString();
                    WynikDzielenia.Add(CoMamWrzucic);
                }
                if (int.TryParse(item.ToString(), out liczba))
                {
                    CoMamWrzucic += item.ToString();
                }
                 else
                {
                    WynikDzielenia.Add(CoMamWrzucic);
                    WynikDzielenia.Add(item.ToString());
                    CoMamWrzucic = "";
                }
                ZliczanieDlugosci++;
            }
            return WynikDzielenia;
        }

       
    }
}