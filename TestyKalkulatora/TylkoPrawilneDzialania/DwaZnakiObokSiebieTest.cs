﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestyKalkulatora.TylkoPrawilneDzialania
{
    class DwaZnakiObokSiebieTest
    {
        zadanie.SprawdzaczPoprawnosciDanych test;
        [SetUp]
        public void Setup()
        {
            test = new zadanie.SprawdzaczPoprawnosciDanych();
        }
        [Test]
        public void DwaZnakiOboksiebie()
        {
            Assert.Catch(() =>
            {
                test.DwaZnakiObokSiebie("3213-312312-+312");
            });
            Assert.Catch(() =>
            {
                test.DwaZnakiObokSiebie("3213--312312-312");
            });
            Assert.Catch(() =>
            {
                test.DwaZnakiObokSiebie("3213***-312312-+312");
            });
            Assert.Catch(() =>
            {
                test.DwaZnakiObokSiebie("3213-312312-+312");
            });
            Assert.DoesNotThrow(() =>
            {
                test.DwaZnakiObokSiebie("+3213-312312+312");
            });
        }
    }
}
