using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.TylkoPrawilneDzialania
{
    class PrzynajmniejJednoDzialanieTest
    {
        zadanie.SprawdzaczPoprawnosciDanych test;
        [SetUp]
        public void Setup()
        {
            test = new zadanie.SprawdzaczPoprawnosciDanych();
        }
        [Test]
        public void PrzynajmniejJednoDzialanie()
        {
            Assert.Catch(() =>
            {
                test.PrzynajmniejJednoDzialanie("-h");
            });
            Assert.Catch(() =>
            {
                test.PrzynajmniejJednoDzialanie("ff");
            });
            Assert.Catch(() =>
            {
                test.PrzynajmniejJednoDzialanie("");
            });
            Assert.Catch(() =>
            {
                test.PrzynajmniejJednoDzialanie("-h-");
            });
        }

    }
}
