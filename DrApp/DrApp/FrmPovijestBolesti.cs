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
    public partial class FrmPovijestBolesti : Form
    {
        public FrmPovijestBolesti()
        {
            InitializeComponent();
        }

        private void OsvjeziPovijestBolesti()
        {

        }

        private void btnDodajZapis_Click(object sender, EventArgs e)
        {
            FrmDodajBilješku novaForma = new FrmDodajBilješku();
            novaForma.ShowDialog();
            OsvjeziPovijestBolesti();
        }
    }
}
