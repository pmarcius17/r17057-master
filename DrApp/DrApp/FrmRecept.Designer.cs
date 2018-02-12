namespace DrApp
{
    partial class FrmRecept
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecept));
            this.DoktoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._17057_DBDataSet = new DrApp._17057_DBDataSet();
            this.PacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReceptiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoktoriTableAdapter = new DrApp._17057_DBDataSetTableAdapters.DoktoriTableAdapter();
            this.PacijentiTableAdapter = new DrApp._17057_DBDataSetTableAdapters.PacijentiTableAdapter();
            this.LijekoviTableAdapter = new DrApp._17057_DBDataSetTableAdapters.LijekoviTableAdapter();
            this.ReceptiTableAdapter = new DrApp._17057_DBDataSetTableAdapters.ReceptiTableAdapter();
            this.rpvRecept = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DoktoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._17057_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LijekoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoktoriBindingSource
            // 
            this.DoktoriBindingSource.DataMember = "Doktori";
            this.DoktoriBindingSource.DataSource = this._17057_DBDataSet;
            // 
            // _17057_DBDataSet
            // 
            this._17057_DBDataSet.DataSetName = "_17057_DBDataSet";
            this._17057_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PacijentiBindingSource
            // 
            this.PacijentiBindingSource.DataMember = "Pacijenti";
            this.PacijentiBindingSource.DataSource = this._17057_DBDataSet;
            // 
            // LijekoviBindingSource
            // 
            this.LijekoviBindingSource.DataMember = "Lijekovi";
            this.LijekoviBindingSource.DataSource = this._17057_DBDataSet;
            // 
            // ReceptiBindingSource
            // 
            this.ReceptiBindingSource.DataMember = "Recepti";
            this.ReceptiBindingSource.DataSource = this._17057_DBDataSet;
            // 
            // DoktoriTableAdapter
            // 
            this.DoktoriTableAdapter.ClearBeforeFill = true;
            // 
            // PacijentiTableAdapter
            // 
            this.PacijentiTableAdapter.ClearBeforeFill = true;
            // 
            // LijekoviTableAdapter
            // 
            this.LijekoviTableAdapter.ClearBeforeFill = true;
            // 
            // ReceptiTableAdapter
            // 
            this.ReceptiTableAdapter.ClearBeforeFill = true;
            // 
            // rpvRecept
            // 
            reportDataSource1.Name = "DataSetDr";
            reportDataSource1.Value = this.DoktoriBindingSource;
            reportDataSource2.Name = "DataSetPacijent";
            reportDataSource2.Value = this.PacijentiBindingSource;
            reportDataSource3.Name = "DataSetLijekovi";
            reportDataSource3.Value = this.LijekoviBindingSource;
            reportDataSource4.Name = "DataSetRecepti";
            reportDataSource4.Value = this.ReceptiBindingSource;
            this.rpvRecept.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRecept.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvRecept.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvRecept.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvRecept.LocalReport.ReportEmbeddedResource = "DrApp.ReportRecept.rdlc";
            this.rpvRecept.Location = new System.Drawing.Point(2, 0);
            this.rpvRecept.Name = "rpvRecept";
            this.rpvRecept.Size = new System.Drawing.Size(706, 377);
            this.rpvRecept.TabIndex = 0;
            // 
            // FrmRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 380);
            this.Controls.Add(this.rpvRecept);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRecept";
            this.Text = "Recept";
            this.Load += new System.EventHandler(this.FrmRecept_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DoktoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._17057_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LijekoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DoktoriBindingSource;
        private _17057_DBDataSet _17057_DBDataSet;
        private System.Windows.Forms.BindingSource PacijentiBindingSource;
        private System.Windows.Forms.BindingSource LijekoviBindingSource;
        private System.Windows.Forms.BindingSource ReceptiBindingSource;
        private _17057_DBDataSetTableAdapters.DoktoriTableAdapter DoktoriTableAdapter;
        private _17057_DBDataSetTableAdapters.PacijentiTableAdapter PacijentiTableAdapter;
        private _17057_DBDataSetTableAdapters.LijekoviTableAdapter LijekoviTableAdapter;
        private _17057_DBDataSetTableAdapters.ReceptiTableAdapter ReceptiTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRecept;
    }
}