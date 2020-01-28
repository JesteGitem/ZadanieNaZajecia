﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadanie;

namespace TestyKalkulatora
{
    class TestySzatkownicy
    {
        zadanie.DzielnikWyrazow szatkownica;
        [SetUp]
        public void Setup()
        {
            szatkownica = new zadanie.DzielnikWyrazow();
        }

        [Test]
        public void SprawdzDlugosc()
        {
            var lista = szatkownica.PodzielWyrazenie("23+5/5-3*5");
            var lista2 = szatkownica.PodzielWyrazenie("23+55-35");
            Assert.AreEqual(9, lista.Count);
            Assert.AreEqual(5, lista2.Count);

        }
        
        [Test]
        public void SprawdzDlugoscFault()
        {
            var lista = szatkownica.PodzielWyrazenie("23+5/5-3*5");
            Assert.AreNotEqual(10, lista.Count);
        }
        [Test]
        public void SpradzPierwsząCyfrę()
        {
            var lista = szatkownica.PodzielWyrazenie("23+5/5-3*5");
            Assert.AreEqual("23", lista[0]);
        }
    }
}
