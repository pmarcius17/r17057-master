using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrApp
{
    public class Registracija
    {
        public static bool Registriraj(Doktori noviDoktor)
        {
            int upisaniRedovi = 0;

            using (var db = new DoktorEntities())
            {
                Doktori postojeciKorisnik = db.Database.SqlQuery<Doktori>("Select * from doktori where korisnicko_ime='" + noviDoktor.korisnicko_ime + "'").FirstOrDefault<Doktori>();
                if (postojeciKorisnik != null)
                {
                    return false;
                }
                db.Doktori.Add(noviDoktor);

                try
                {
                    upisaniRedovi = db.SaveChanges();

                }
                catch (Exception ex) { }
            }

            return upisaniRedovi != 0;
        }
    }
}
