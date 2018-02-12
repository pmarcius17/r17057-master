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
    public partial class FrmRecept : Form
    {

        private int pacijentId;
        private int lijekId;
        private int receptId;

        public FrmRecept(int pacijentId, int lijekId, int receptId)
        {
            this.pacijentId = pacijentId;
            this.lijekId = lijekId;
            this.receptId = receptId;
            InitializeComponent();
        }

        private void FrmRecept_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the '_17057_DBDataSet.Doktori' table. You can move, or remove it, as needed.
            this.DoktoriTableAdapter.FillByDoktorId(this._17057_DBDataSet.Doktori,Prijava.trenutniDoktor.doktorId);
            // TODO: This line of code loads data into the '_17057_DBDataSet.Pacijenti' table. You can move, or remove it, as needed.
            this.PacijentiTableAdapter.FillByPacijentId(this._17057_DBDataSet.Pacijenti, pacijentId);
            // TODO: This line of code loads data into the '_17057_DBDataSet.Lijekovi' table. You can move, or remove it, as needed.
            this.LijekoviTableAdapter.FillByLijekId(this._17057_DBDataSet.Lijekovi, lijekId);
            // TODO: This line of code loads data into the '_17057_DBDataSet.Recepti' table. You can move, or remove it, as needed.
            this.ReceptiTableAdapter.FillByReceptId(this._17057_DBDataSet.Recepti, receptId);

            
            this.rpvRecept.RefreshReport();
           
        }
    }
}
