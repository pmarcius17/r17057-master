using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrAppPomoc
{
    public class Pomoc
    {
        public static void PrikaziPDF(string nazivDatoteke)
        {
            System.Diagnostics.Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                FileName = nazivDatoteke

            };

            proc.Start();
        }
    }
}
