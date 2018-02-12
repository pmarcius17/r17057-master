using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrAppPomoc;

namespace DrApp
{
    public partial class FrmRegistracija : Form
    {
        string ime;
        string prezime;
        string email;
        string korisnickoIme;
        string lozinka;
        string ponovljenaLozinka;
        string adresa;

        public FrmRegistracija()
        {
            InitializeComponent();
        }

        private void btnPotvrdiRegistraciju_Click(object sender, EventArgs e)
        {
            ime = txtIme.Text;
            prezime = txtPrezime.Text;
            email = txtEmail.Text;
            korisnickoIme = txtKorisnickoIme.Text;
            lozinka = txtLozinka.Text;
            ponovljenaLozinka = txtPonovljenjaLozinka.Text;
            adresa = txtAdresa.Text;

            if (ProvjeraUnosa())
            {
                Doktori noviDoktor = new Doktori();
                noviDoktor.ime = ime;
                noviDoktor.prezime = prezime;
                noviDoktor.email = email;
                noviDoktor.korisnicko_ime = korisnickoIme;
                noviDoktor.lozinka = lozinka;
                noviDoktor.adresa = adresa;

                if (Registracija.Registriraj(noviDoktor))
                {
                    MessageBox.Show("Uspješna registracija");
                    this.Hide();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Korisnik s tim korisničkim imenom već postoji!", "Neuspješna registracija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtKorisnickoIme.Text = "";
                }
            }
        }

        private bool ProvjeraUnosa()
        {
            if (ime == "" || prezime == "" || email == "" || korisnickoIme == "" || adresa == "" || lozinka == "" || ponovljenaLozinka == "")
            {
                MessageBox.Show("Nisu uneseni svi potrebni podaci za registraciju.", "Neuspješna registracija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (lozinka != ponovljenaLozinka)
            {
                MessageBox.Show("Lozinke se ne podudaraju!", "Neuspješna registracija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!(regex.Match(email)).Success)
            {
                MessageBox.Show("Email nije pravilnog formata.", "Neuspješna registracija", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Text = "";
                return false;
            }
            return true;
        }

        private void btnPonisti_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRegistracija_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Registracija.pdf");
               
            }
        }
    }
}
