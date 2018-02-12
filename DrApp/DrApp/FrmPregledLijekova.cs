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
    public partial class FrmPregledLijekova : Form
    {
        public static Pacijenti odabraniPacijent = null;
        private int noviReceptId;

        public FrmPregledLijekova()
        {
            InitializeComponent();

            BindingList<Pacijenti> listaPacijenata = null;

            using (var db = new DoktorEntities())
            {
                listaPacijenata = new BindingList<Pacijenti>(Prijava.trenutniDoktor.Pacijenti.ToList());
            }

            pacijentiBindingSource.DataSource = listaPacijenata;
        }


        private void OsvjeziLijekove()
        {
            BindingList<Lijekovi> listaLijekova = null;
            using (var db = new DoktorEntities())
            {
                listaLijekova = new BindingList<Lijekovi>(db.Lijekovi.ToList());
            }

            lijekBindingSource.DataSource = listaLijekova;
        }

    
        private void btnDodajLijek_Click(object sender, EventArgs e)
        {
            FrmDodajLijek formaDodajLijek = new FrmDodajLijek();
            formaDodajLijek.ShowDialog();
            OsvjeziLijekove();
        }

        private void FrmPregledLijekova_Load(object sender, EventArgs e)
        {
            OsvjeziLijekove();
        }

        private void UpisiRecept()
        {
            Pacijenti trenutni = cmbPacijenti.SelectedItem as Pacijenti;

            if (trenutni != null)
            {
                if (txtKolicinaLijeka.Text != "" && txtKolicinaLijeka.Text != null)
                {
                    if (dgvLijekovi.SelectedRows.Count > 0)
                    {
                        Lijekovi lijek = dgvLijekovi.CurrentRow.DataBoundItem as Lijekovi;

                        using (var db = new DoktorEntities())
                        {
                            Recepti recept = new Recepti
                            {
                                datum = DateTime.Now,
                                opis = txtKolicinaLijeka.Text,
                                pacijentId = trenutni.pacijentId,
                                doktorId = Prijava.trenutniDoktor.doktorId,
                                lijekId = lijek.lijekId
                            };

                            db.Recepti.Add(recept);
                            db.SaveChanges();

                            db.Entry(recept).GetDatabaseValues();
                            noviReceptId = recept.receptId;

                            OtvoriFormuRecept();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Potrebno je odabrati lijek.");
                    }
                 
                }
                else
                {
                    MessageBox.Show("Potrebno je upisati potrebnu kolicinu lijeka.");
                }
            }
            else
            {
                MessageBox.Show("Potrebno je odabrati pacijenta.");
            }
        }

        private void btnKreirajRecept_Click(object sender, EventArgs e)
        {
            UpisiRecept();
        }

        private void OtvoriFormuRecept()
        {
            if (cmbPacijenti.SelectedValue != null && dgvLijekovi.SelectedRows.Count > 0)
            {
                Lijekovi lijek = (Lijekovi)dgvLijekovi.CurrentRow.DataBoundItem;
                int pacijentId = (int)cmbPacijenti.SelectedValue;

                FrmRecept forma = new FrmRecept(pacijentId, lijek.lijekId, noviReceptId);
                forma.ShowDialog();
            }
        }

        private void FrmPregledLijekova_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Pomoc.PrikaziPDF(@"..\..\..\Pomoc\Pregled_lijekova.pdf");
                
            }
        }
    }
}
