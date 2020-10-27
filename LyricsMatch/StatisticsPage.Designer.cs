namespace LyricsMatch
{
    partial class StatisticsPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartLanguage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartLanguage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Statistics";
            // 
            // chartLanguage
            // 
            chartArea7.Name = "ChartArea1";
            this.chartLanguage.ChartAreas.Add(chartArea7);
            this.chartLanguage.Location = new System.Drawing.Point(859, 121);
            this.chartLanguage.Name = "chartLanguage";
            series7.ChartArea = "ChartArea1";
            series7.Name = "Series1";
            this.chartLanguage.Series.Add(series7);
            this.chartLanguage.Size = new System.Drawing.Size(479, 275);
            this.chartLanguage.TabIndex = 11;
            this.chartLanguage.Text = "chart1";
            // 
            // chartGenre
            // 
            chartArea8.Name = "ChartArea1";
            this.chartGenre.ChartAreas.Add(chartArea8);
            this.chartGenre.Location = new System.Drawing.Point(53, 121);
            this.chartGenre.Name = "chartGenre";
            series8.ChartArea = "ChartArea1";
            series8.Name = "Series1";
            this.chartGenre.Series.Add(series8);
            this.chartGenre.Size = new System.Drawing.Size(758, 275);
            this.chartGenre.TabIndex = 12;
            this.chartGenre.Text = "chartGenre";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(33, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1323, 333);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // StatisticsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 453);
            this.Controls.Add(this.chartGenre);
            this.Controls.Add(this.chartLanguage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StatisticsPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyricsMatch";
            ((System.ComponentModel.ISupportInitialize)(this.chartLanguage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLanguage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}