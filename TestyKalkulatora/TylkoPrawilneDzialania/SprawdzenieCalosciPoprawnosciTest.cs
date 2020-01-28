using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.TylkoPrawilneDzialania
{
    class SprawdzenieCalosciPoprawnosciTest
    {
        zadanie.SprawdzaczPoprawnosciDanych test;
        [SetUp]
        public void Setup()
        {
            test = new zadanie.SprawdzaczPoprawnosciDanych();
        }
        [Test]
        public void SprawdzPoprawnoscDobregoDzialania()
        {
            Assert.DoesNotThrow(() =>
            {
                test.SprawdzPoprawnosc("232-31");
            });
        }
        [Test]
        public void SprawdzPoprawnoscZlegoDzialania()
        {
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("-232-31");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("232-31-");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("-232-31-");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("232--31");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("f232-31");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("-23wq2-31");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("232--31");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("-232");
            });
            Assert.Catch(() =>
            {
                test.SprawdzPoprawnosc("31");
            });
        }
    }
}
