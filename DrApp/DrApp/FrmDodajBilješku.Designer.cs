namespace DrApp
{
    partial class FrmDodajBilješku
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbImePacijenta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbImeDoktora = new System.Windows.Forms.Label();
            this.btnSpremiBiljesku = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "POVIJEST BOLESTI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "0";
            // 
            // lbImePacijenta
            // 
            this.lbImePacijenta.AutoSize = true;
            this.lbImePacijenta.Location = new System.Drawing.Point(13, 63);
            this.lbImePacijenta.Name = "lbImePacijenta";
            this.lbImePacijenta.Size = new System.Drawing.Size(0, 13);
            this.lbImePacijenta.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(416, 240);
            this.textBox1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bilješke:";
            // 
            // lbImeDoktora
            // 
            this.lbImeDoktora.AutoSize = true;
            this.lbImeDoktora.Location = new System.Drawing.Point(24, 374);
            this.lbImeDoktora.Name = "lbImeDoktora";
            this.lbImeDoktora.Size = new System.Drawing.Size(0, 13);
            this.lbImeDoktora.TabIndex = 6;
            // 
            // btnSpremiBiljesku
            // 
            this.btnSpremiBiljesku.Location = new System.Drawing.Point(344, 396);
            this.btnSpremiBiljesku.Name = "btnSpremiBiljesku";
            this.btnSpremiBiljesku.Size = new System.Drawing.Size(88, 31);
            this.btnSpremiBiljesku.TabIndex = 7;
            this.btnSpremiBiljesku.Text = "Spremi bilješku";
            this.btnSpremiBiljesku.UseVisualStyleBackColor = true;
            this.btnSpremiBiljesku.Click += new System.EventHandler(this.btnSpremiBiljesku_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(241, 396);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(88, 31);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmDodajBilješku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 439);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnSpremiBiljesku);
            this.Controls.Add(this.lbImeDoktora);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbImePacijenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDodajBilješku";
            this.Text = "FrmDodajBilješku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbImePacijenta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbImeDoktora;
        private System.Windows.Forms.Button btnSpremiBiljesku;
        private System.Windows.Forms.Button btnOdustani;
    }
}