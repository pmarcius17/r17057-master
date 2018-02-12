using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrApp
{
   public class Prijava
    {
        public static Doktori trenutniDoktor = null;

        public static bool Prijavi(string korisnickoIme, string lozinka)
        {
            bool prijavaUspjesna = false;

            using (var db = new DoktorEntities())
            {
                var query = from o in db.Doktori
                            where o.korisnicko_ime == korisnickoIme && o.lozinka == lozinka
                            select o;

                if (query.SingleOrDefault() != null)
                {
                    trenutniDoktor = (Doktori)query.SingleOrDefault();
                    prijavaUspjesna = true;
                }
            }

            return prijavaUspjesna;
        }
    }
}
