using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.Obliczarka
{
    class ZnajdzZnak
    {
        zadanie.WykonanieDzialan test;
        private List<string> asd;

        [SetUp]
        public void Setup()
        {
            test = new zadanie.WykonanieDzialan();
            asd = new List<string>();
           
        }
        //[Test]
        //public void PoprawnieZczytujeIndeksZnaku()
        //{
        //    asd.Add("15");
        //    asd.Add("+");
        //    asd.Add("12");
        //    test.wyrazenie(asd);
        //    PrivateObject
        //    test.ZnajdzZnak();
        //}
    }
}
