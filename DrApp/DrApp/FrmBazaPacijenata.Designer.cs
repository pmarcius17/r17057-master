namespace DrApp
{
    partial class FrmBazaPacijenata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBazaPacijenata));
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            this.btnObrisiPacijenta = new System.Windows.Forms.Button();
            this.btnAzurirajPacijenta = new System.Windows.Forms.Button();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.btnPovijestBolesti = new System.Windows.Forms.Button();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Location = new System.Drawing.Point(12, 12);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(124, 32);
            this.btnDodajPacijenta.TabIndex = 1;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // btnObrisiPacijenta
            // 
            this.btnObrisiPacijenta.Location = new System.Drawing.Point(173, 12);
            this.btnObrisiPacijenta.Name = "btnObrisiPacijenta";
            this.btnObrisiPacijenta.Size = new System.Drawing.Size(124, 32);
            this.btnObrisiPacijenta.TabIndex = 2;
            this.btnObrisiPacijenta.Text = "Obriši pacijenta";
            this.btnObrisiPacijenta.UseVisualStyleBackColor = true;
            this.btnObrisiPacijenta.Click += new System.EventHandler(this.btnObrisiPacijenta_Click);
            // 
            // btnAzurirajPacijenta
            // 
            this.btnAzurirajPacijenta.Location = new System.Drawing.Point(329, 12);
            this.btnAzurirajPacijenta.Name = "btnAzurirajPacijenta";
            this.btnAzurirajPacijenta.Size = new System.Drawing.Size(124, 32);
            this.btnAzurirajPacijenta.TabIndex = 3;
            this.btnAzurirajPacijenta.Text = "Azuriraj pacijenta";
            this.btnAzurirajPacijenta.UseVisualStyleBackColor = true;
            this.btnAzurirajPacijenta.Click += new System.EventHandler(this.btnAzurirajPacijenta_Click);
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AllowUserToAddRows = false;
            this.dgvPacijenti.AllowUserToDeleteRows = false;
            this.dgvPacijenti.AutoGenerateColumns = false;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.datumRodenja});
            this.dgvPacijenti.DataSource = this.pacijentiBindingSource;
            this.dgvPacijenti.Location = new System.Drawing.Point(9, 50);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.ReadOnly = true;
            this.dgvPacijenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacijenti.Size = new System.Drawing.Size(544, 325);
            this.dgvPacijenti.TabIndex = 4;
            // 
            // btnPovijestBolesti
            // 
            this.btnPovijestBolesti.Location = new System.Drawing.Point(421, 379);
            this.btnPovijestBolesti.Name = "btnPovijestBolesti";
            this.btnPovijestBolesti.Size = new System.Drawing.Size(132, 31);
            this.btnPovijestBolesti.TabIndex = 5;
            this.btnPovijestBolesti.Text = "Prikaži povijest bolesti";
            this.btnPovijestBolesti.UseVisualStyleBackColor = true;
            this.btnPovijestBolesti.Click += new System.EventHandler(this.btnPovijestBolesti_Click);
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(DrApp.Pacijenti);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ime";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "prezime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "adresa";
            this.dataGridViewTextBoxColumn3.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "oib";
            this.dataGridViewTextBoxColumn4.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // datumRodenja
            // 
            this.datumRodenja.DataPropertyName = "datumRodenja";
            this.datumRodenja.HeaderText = "Datum rodenja";
            this.datumRodenja.Name = "datumRodenja";
            this.datumRodenja.ReadOnly = true;
            // 
            // FrmBazaPacijenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 422);
            this.Controls.Add(this.btnPovijestBolesti);
            this.Controls.Add(this.dgvPacijenti);
            this.Controls.Add(this.btnAzurirajPacijenta);
            this.Controls.Add(this.btnObrisiPacijenta);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmBazaPacijenata";
            this.Text = "Pregled pacijenata";
            this.Load += new System.EventHandler(this.FrmBazaPacijenata_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBazaPacijenata_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPacijenta;
        private System.Windows.Forms.Button btnObrisiPacijenta;
        private System.Windows.Forms.Button btnAzurirajPacijenta;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.Button btnPovijestBolesti;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumRodenja;
    }
}