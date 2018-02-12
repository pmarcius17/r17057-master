using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrAppPomoc;

namespace DrApp
{
    public partial class FrmStatistika : Form
    {
        public FrmStatistika()
        {
            InitializeComponent();
        }

        private void UcitajPodatkeZaGraf()
        {
            using (var db = new DoktorEntities())
            {
                var query = from Doktori in db.Doktori
                            select new
                            {
                                ImePrezime = string.Concat(Doktori.ime, " ", Doktori.prezime),
                                Recepti = Doktori.Recepti.Count,
                                Pacijenti = Doktori.Pacijenti.Count,
                            };

                foreach (var item in query)
                {
                    chartStatistika.Series["Recepti"].Points.AddXY(item.ImePrezime, item.Recepti);
                    chartStatistika.Series["Pacijenti"].Points.AddXY(item.ImePrezime, item.Pacijenti);
                }
            }
        }

        private void FrmStatistika_Load(object sender, EventArgs e)
        {
            UcitajPodatkeZaGraf();
        }

        private void FrmStatistika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Statistika.pdf");
                
            }
        }
    }
}
