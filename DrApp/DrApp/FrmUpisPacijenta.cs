using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrApp
{
    public partial class FrmUpisPacijenta : Form
    {
        public FrmUpisPacijenta()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            using (var db = new DoktorEntities())
            {

                Pacijenti noviPacijent = new Pacijenti()
                {
                    ime = txtIme.Text,
                    prezime = txtPrezime.Text,
                    adresa = txtAdresa.Text,
                    oib = txtOIB.Text,
                    datumRodenja = tbDatumRodenja.Text,
                    doktorId = Prijava.trenutniDoktor.doktorId 
                };

               
                if (txtOIB.TextLength >= 12 || txtOIB.TextLength<=10)
                {
                    MessageBox.Show("Duljina OIB-a mora biti 11");
                    txtOIB.Text = "";
                    return;

                }
                else
                {
                    db.Pacijenti.Add(noviPacijent);
                    db.SaveChanges();
                }
                
            }
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
