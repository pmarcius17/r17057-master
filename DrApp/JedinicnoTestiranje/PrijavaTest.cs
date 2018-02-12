using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrApp;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class PrijavaTest
    {
        [TestMethod]
        public void TestPrijava()
        {


            bool uspjesnaPrijava2 = Prijava.Prijavi("jura", "ma");
            Assert.IsFalse(uspjesnaPrijava2, "Nepostojeći korisnik");

            bool uspjesnaPrijava = Prijava.Prijavi("thranj", "ja");
            Assert.IsTrue(uspjesnaPrijava, "Prijava uspješna!");

            bool uspjesnaPrijava3 = Prijava.Prijavi("", "");
            Assert.IsFalse(uspjesnaPrijava3, "Upisite korisnicko ime i lozinku");

        }
    }
}
