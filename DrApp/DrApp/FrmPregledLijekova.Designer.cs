namespace DrApp
{
    partial class FrmPregledLijekova
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
            this.dgvLijekovi = new System.Windows.Forms.DataGridView();
            this.lijekIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis_lijeka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lijekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDodajLijek = new System.Windows.Forms.Button();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbPacijenti = new System.Windows.Forms.ComboBox();
            this.btnKreirajRecept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKolicinaLijeka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLijekovi
            // 
            this.dgvLijekovi.AllowUserToAddRows = false;
            this.dgvLijekovi.AllowUserToDeleteRows = false;
            this.dgvLijekovi.AutoGenerateColumns = false;
            this.dgvLijekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLijekovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lijekIdDataGridViewTextBoxColumn,
            this.naziv_lijeka,
            this.opis_lijeka});
            this.dgvLijekovi.DataSource = this.lijekBindingSource;
            this.dgvLijekovi.Location = new System.Drawing.Point(12, 47);
            this.dgvLijekovi.Name = "dgvLijekovi";
            this.dgvLijekovi.ReadOnly = true;
            this.dgvLijekovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLijekovi.Size = new System.Drawing.Size(399, 150);
            this.dgvLijekovi.TabIndex = 0;
            // 
            // lijekIdDataGridViewTextBoxColumn
            // 
            this.lijekIdDataGridViewTextBoxColumn.DataPropertyName = "lijekId";
            this.lijekIdDataGridViewTextBoxColumn.HeaderText = "lijekId";
            this.lijekIdDataGridViewTextBoxColumn.Name = "lijekIdDataGridViewTextBoxColumn";
            this.lijekIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lijekIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // naziv_lijeka
            // 
            this.naziv_lijeka.DataPropertyName = "naziv_lijeka";
            this.naziv_lijeka.HeaderText = "naziv_lijeka";
            this.naziv_lijeka.Name = "naziv_lijeka";
            this.naziv_lijeka.ReadOnly = true;
            // 
            // opis_lijeka
            // 
            this.opis_lijeka.DataPropertyName = "opis_lijeka";
            this.opis_lijeka.HeaderText = "opis_lijeka";
            this.opis_lijeka.Name = "opis_lijeka";
            this.opis_lijeka.ReadOnly = true;
            // 
            // lijekBindingSource
            // 
            this.lijekBindingSource.DataSource = typeof(DrApp.Lijekovi);
            // 
            // btnDodajLijek
            // 
            this.btnDodajLijek.Location = new System.Drawing.Point(12, 12);
            this.btnDodajLijek.Name = "btnDodajLijek";
            this.btnDodajLijek.Size = new System.Drawing.Size(81, 29);
            this.btnDodajLijek.TabIndex = 1;
            this.btnDodajLijek.Text = "Dodaj lijek";
            this.btnDodajLijek.UseVisualStyleBackColor = true;
            this.btnDodajLijek.Click += new System.EventHandler(this.btnDodajLijek_Click);
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(DrApp.Pacijenti);
            // 
            // cmbPacijenti
            // 
            this.cmbPacijenti.DataSource = this.pacijentiBindingSource;
            this.cmbPacijenti.DisplayMember = "ImePrezime";
            this.cmbPacijenti.FormattingEnabled = true;
            this.cmbPacijenti.Location = new System.Drawing.Point(289, 237);
            this.cmbPacijenti.Name = "cmbPacijenti";
            this.cmbPacijenti.Size = new System.Drawing.Size(121, 21);
            this.cmbPacijenti.TabIndex = 2;
            this.cmbPacijenti.ValueMember = "pacijentId";
            // 
            // btnKreirajRecept
            // 
            this.btnKreirajRecept.Location = new System.Drawing.Point(289, 273);
            this.btnKreirajRecept.Name = "btnKreirajRecept";
            this.btnKreirajRecept.Size = new System.Drawing.Size(122, 34);
            this.btnKreirajRecept.TabIndex = 3;
            this.btnKreirajRecept.Text = "Kreiraj recept";
            this.btnKreirajRecept.UseVisualStyleBackColor = true;
            this.btnKreirajRecept.Click += new System.EventHandler(this.btnKreirajRecept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Propisana kolicina lijeka";
            // 
            // txtKolicinaLijeka
            // 
            this.txtKolicinaLijeka.Location = new System.Drawing.Point(12, 237);
            this.txtKolicinaLijeka.Multiline = true;
            this.txtKolicinaLijeka.Name = "txtKolicinaLijeka";
            this.txtKolicinaLijeka.Size = new System.Drawing.Size(245, 70);
            this.txtKolicinaLijeka.TabIndex = 5;
            // 
            // FrmPregledLijekova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 319);
            this.Controls.Add(this.txtKolicinaLijeka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKreirajRecept);
            this.Controls.Add(this.cmbPacijenti);
            this.Controls.Add(this.btnDodajLijek);
            this.Controls.Add(this.dgvLijekovi);
            this.KeyPreview = true;
            this.Name = "FrmPregledLijekova";
            this.Text = "Pregled lijekova";
            this.Load += new System.EventHandler(this.FrmPregledLijekova_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPregledLijekova_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLijekovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLijekovi;

        private System.Windows.Forms.BindingSource lijekBindingSource;
        private System.Windows.Forms.Button btnDodajLijek;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.ComboBox cmbPacijenti;
        private System.Windows.Forms.Button btnKreirajRecept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKolicinaLijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv_lijeka;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis_lijeka;
    }
}