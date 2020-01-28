using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.Obliczarka
{
    class ZnajdzZnak
    {
        zadanie.WykonywaczDzialan test;
        private List<string> asd;

        [SetUp]
        public void Setup()
        {
            test = new zadanie.WykonywaczDzialan();
            asd = new List<string>();
            asd.Add("15");
            asd.Add("+");
            asd.Add("12");
            test.ZwrocWynik(asd);
            test.ZnajdzZnak();
        }
        [Test]
        public void PoprawnieZczytujeIndeksZnaku()
        {
          
        }
    }
}
