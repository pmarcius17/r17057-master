using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DrApp;

namespace JedinicnoTestiranje
{
    [TestClass]
    public class RegistracijaTest
    {
        [TestMethod]
        public void RegistirajTest()
        {
            Doktori noviDoktor = new Doktori();
            noviDoktor.ime = "Toni";
            noviDoktor.prezime = "Kukoc";
            noviDoktor.adresa = "Split";
            noviDoktor.korisnicko_ime = "toni";
            noviDoktor.lozinka = "to";
            noviDoktor.email = "lopta@gmail.com";

            bool uspjesnaRegistracija = Registracija.Registriraj(noviDoktor);
            Assert.IsFalse(uspjesnaRegistracija, "Korisnik postoji !");

            Doktori noviDoktor1 = new Doktori();
            noviDoktor1.ime = "Tonimir";
            noviDoktor1.prezime = "Kukoc";
            noviDoktor1.adresa = "Zadar";
            noviDoktor1.korisnicko_ime = "tonimir";
            noviDoktor1.lozinka = "to";
            noviDoktor1.email = "lopta22@gmail.com";

            bool uspjesnaRegistracija1 = Registracija.Registriraj(noviDoktor1);
            Assert.IsTrue(uspjesnaRegistracija1, "Uspjesno registriran !");

            Doktori noviDoktor2 = new Doktori();
            noviDoktor2.ime = "Tomi";
            noviDoktor2.prezime = "Kukoc";
            noviDoktor2.adresa = "Zagreb";
            noviDoktor2.korisnicko_ime = "thranj";
            noviDoktor2.lozinka = "to";
            noviDoktor2.email = "lopta221@gmail.com";

            bool uspjesnaRegistracija2 = Registracija.Registriraj(noviDoktor2);
            Assert.IsFalse(uspjesnaRegistracija2, "Korisnik sa tim korisničkim imenom postoji !");

        }
    }
}
