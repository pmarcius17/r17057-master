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
    public partial class FrmMainDrApp : Form
    {
        public FrmMainDrApp()
        {
            InitializeComponent();
        }

        private void pregledPacijentaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            FrmBazaPacijenata formaUpisPacijenta = new FrmBazaPacijenata();
            formaUpisPacijenta.MdiParent = this;
            formaUpisPacijenta.WindowState = FormWindowState.Maximized;
            formaUpisPacijenta.Show();
        }

        private void pregledLijekovaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            FrmPregledLijekova formapregledLijeka = new FrmPregledLijekova();
            formapregledLijeka.MdiParent = this;
            formapregledLijeka.WindowState = FormWindowState.Maximized;
            formapregledLijeka.Show();
        }

        private void odjavaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            this.Hide();
            FrmLogin formaLogin = new FrmLogin();
            formaLogin.ShowDialog();
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Korisnicka_dokumentacija.pdf");
            
        }

        private void statistikaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            FrmStatistika forma = new FrmStatistika();
            forma.MdiParent = this;
            forma.WindowState = FormWindowState.Maximized;
            forma.Show();
        }
    }
}
