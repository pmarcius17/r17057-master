namespace DrApp
{
    partial class FrmStatistika
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStatistika));
            this.chartStatistika = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStatistika
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistika.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistika.Legends.Add(legend1);
            this.chartStatistika.Location = new System.Drawing.Point(3, 2);
            this.chartStatistika.Name = "chartStatistika";
            series1.BorderColor = System.Drawing.Color.Tan;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Recepti";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Pacijenti";
            this.chartStatistika.Series.Add(series1);
            this.chartStatistika.Series.Add(series2);
            this.chartStatistika.Size = new System.Drawing.Size(421, 340);
            this.chartStatistika.TabIndex = 0;
            this.chartStatistika.Text = "chart1";
            // 
            // FrmStatistika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 343);
            this.Controls.Add(this.chartStatistika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmStatistika";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.FrmStatistika_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStatistika_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistika;
    }
}