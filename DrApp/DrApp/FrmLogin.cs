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
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {

            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            if (string.IsNullOrEmpty(txtKorisnickoIme.Text))
            {
                MessageBox.Show("Unesite korisničko ime.", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKorisnickoIme.Focus();
                return;

            }

            try
            {
                if (Prijava.Prijavi(korisnickoIme, lozinka))
                {

                    FrmMainDrApp forma = new FrmMainDrApp();
                    this.Hide();
                    forma.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Korisnicko ime ili lozinka je pogrešno unesena", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            FrmRegistracija novaRegistracija = new FrmRegistracija();
            novaRegistracija.ShowDialog();
        }

        private void txtKorisnickoIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                txtLozinka.Focus();
            }
        }

        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnPrijaviSe.PerformClick();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Prijava.pdf");
            }
        }
    }
}
