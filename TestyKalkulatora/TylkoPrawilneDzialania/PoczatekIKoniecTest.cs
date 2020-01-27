using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadanie;

namespace TestyKalkulatora.TylkoPrawilneDzialania
{
    class PoczatekIKoniecTest
    {
        zadanie.TylkoPrawilneDzialania test;
        [SetUp]
        public void Setup()
        {
            test = new zadanie.TylkoPrawilneDzialania();
        }
        [Test]
        public void ZlyPoczatek()
        {
            Assert.Catch(() =>
            {
                test.PoczatekiKoniecToCyfra("-3213-312312-312");

            });
        }
        [Test]
        public void Zlykoniec()
        {
            Assert.Catch(() =>
            {
                test.PoczatekiKoniecToCyfra("3213-312312-312-");

            });
        }
        [Test]
        public void ObaSaZlePoczatki()
        {
            Assert.Catch(() =>
            {
                test.PoczatekiKoniecToCyfra("-3213-312312-312-");

            });
        }
        [Test]
        public void DobryPoczatekIDobryKoniec()
        {
            Assert.DoesNotThrow(() =>
            {
                test.PoczatekiKoniecToCyfra("3321-3-2-1");
            });
        }
    }
}
