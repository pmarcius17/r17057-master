namespace DrApp
{
    partial class FrmPovijestBolesti
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPovijestPacijenta = new System.Windows.Forms.DataGridView();
            this.btnOtvoriPovijest = new System.Windows.Forms.Button();
            this.btnDodajZapis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestPacijenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Povijest bolesti pacijenta:";
            // 
            // dgvPovijestPacijenta
            // 
            this.dgvPovijestPacijenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPovijestPacijenta.Location = new System.Drawing.Point(12, 28);
            this.dgvPovijestPacijenta.Name = "dgvPovijestPacijenta";
            this.dgvPovijestPacijenta.Size = new System.Drawing.Size(424, 266);
            this.dgvPovijestPacijenta.TabIndex = 1;
            // 
            // btnOtvoriPovijest
            // 
            this.btnOtvoriPovijest.Location = new System.Drawing.Point(54, 306);
            this.btnOtvoriPovijest.Name = "btnOtvoriPovijest";
            this.btnOtvoriPovijest.Size = new System.Drawing.Size(141, 42);
            this.btnOtvoriPovijest.TabIndex = 2;
            this.btnOtvoriPovijest.Text = "Otvori selektiranu bilješku";
            this.btnOtvoriPovijest.UseVisualStyleBackColor = true;
            // 
            // btnDodajZapis
            // 
            this.btnDodajZapis.Location = new System.Drawing.Point(248, 306);
            this.btnDodajZapis.Name = "btnDodajZapis";
            this.btnDodajZapis.Size = new System.Drawing.Size(141, 42);
            this.btnDodajZapis.TabIndex = 3;
            this.btnDodajZapis.Text = "Dodaj novu bilješku";
            this.btnDodajZapis.UseVisualStyleBackColor = true;
            this.btnDodajZapis.Click += new System.EventHandler(this.btnDodajZapis_Click);
            // 
            // FrmPovijestBolesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 367);
            this.Controls.Add(this.btnDodajZapis);
            this.Controls.Add(this.btnOtvoriPovijest);
            this.Controls.Add(this.dgvPovijestPacijenta);
            this.Controls.Add(this.label1);
            this.Name = "FrmPovijestBolesti";
            this.Text = "Povijest bolesti pacijenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPovijestPacijenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPovijestPacijenta;
        private System.Windows.Forms.Button btnOtvoriPovijest;
        private System.Windows.Forms.Button btnDodajZapis;
    }
}