using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.TylkoPrawilneDzialania
{
    class TylkoCyfryiZnakiTest
    {
        zadanie.SprawdzanieDanych test;
        [SetUp]
        public void Setup()
        {
            test = new zadanie.SprawdzanieDanych();
        }
        [Test]
        public void LiteraWSrodku()
        {
            Assert.Catch(() =>
            {
                test.TylkoCyfryiZnaki("32a13-312312-312");
            });
        }
        [Test]
        public void ZnakWSrodku()
        {
            Assert.Catch(() =>
            {
                test.TylkoCyfryiZnaki("32дк13 - 312312-312");
            });
        }
        [Test]
        public void NieRzucaBledem()
        {
            Assert.DoesNotThrow(() =>
            {
                test.TylkoCyfryiZnaki("3213-312312-312");
            });
        }
        [Test]
        public void Spacja()
        {
            Assert.Catch(() =>
            {
                test.TylkoCyfryiZnaki("3213 -312312- 312");
            });
        }
    }
}
