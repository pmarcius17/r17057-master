using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrAppPomoc;

namespace DrApp
{
    public partial class FrmBazaPacijenata : Form
    {
        public FrmBazaPacijenata()
        {
            InitializeComponent();
        }

        private void OsvjeziPacijente()
        {
          BindingList<Pacijenti>  listaPacijenata = null;

            using (var db = new DoktorEntities())
            {
                Prijava.trenutniDoktor = (Doktori)(from o in db.Doktori where o.doktorId == Prijava.trenutniDoktor.doktorId select o).FirstOrDefault();
                listaPacijenata = new BindingList<Pacijenti>(Prijava.trenutniDoktor.Pacijenti.ToList());
            }

            pacijentiBindingSource.DataSource = listaPacijenata;
        }


        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            FrmUpisPacijenta novaForma = new FrmUpisPacijenta();
            novaForma.ShowDialog();
            OsvjeziPacijente();
        }

        private void FrmBazaPacijenata_Load(object sender, EventArgs e)
        {
            OsvjeziPacijente();
        }

        private void btnObrisiPacijenta_Click(object sender, EventArgs e)
        {
            using(var db = new DoktorEntities())
            {
                Pacijenti obrisiPacijenta = dgvPacijenti.CurrentRow.DataBoundItem as Pacijenti;
                db.Pacijenti.Remove(obrisiPacijenta);
                db.SaveChanges();
                OsvjeziPacijente();
            }
        }

        private void FrmBazaPacijenata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Pregled_pac.pdf");
               
            }
        }

        private void btnAzurirajPacijenta_Click(object sender, EventArgs e)
        {

        }

        private void btnPovijestBolesti_Click(object sender, EventArgs e)
        {
            if (dgvPacijenti.CurrentRow != null)
            {
                FrmPovijestBolesti novaForma = new FrmPovijestBolesti();
                novaForma.ShowDialog();
                OsvjeziPacijente();
            }
        }
    }
}


