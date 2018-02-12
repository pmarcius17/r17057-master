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
    public partial class FrmDodajLijek : Form
    {
        public FrmDodajLijek()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (var db = new DoktorEntities())
            {
                Lijekovi lijek = new Lijekovi()
                {
                    naziv_lijeka = txtNaziv.Text,
                    opis_lijeka = txtOpis.Text
                };
                db.Lijekovi.Add(lijek);
                db.SaveChanges();

            }
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
