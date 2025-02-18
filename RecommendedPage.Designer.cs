namespace LyricsMatch
{
    partial class RecommendedPage
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
            this.lblRec = new System.Windows.Forms.Label();
            this.dgvRecommended = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommended)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(29, 28);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(144, 25);
            this.lblRec.TabIndex = 5;
            this.lblRec.Text = "Recommended";
            // 
            // dgvRecommended
            // 
            this.dgvRecommended.AllowUserToAddRows = false;
            this.dgvRecommended.AllowUserToDeleteRows = false;
            this.dgvRecommended.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecommended.Location = new System.Drawing.Point(25, 33);
            this.dgvRecommended.Name = "dgvRecommended";
            this.dgvRecommended.ReadOnly = true;
            this.dgvRecommended.RowHeadersWidth = 51;
            this.dgvRecommended.RowTemplate.Height = 24;
            this.dgvRecommended.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecommended.Size = new System.Drawing.Size(634, 313);
            this.dgvRecommended.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.dgvRecommended);
            this.groupBox1.Location = new System.Drawing.Point(25, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 415);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(547, 363);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(112, 29);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View selected";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Recommended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 514);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.groupBox1);
            this.Name = "Recommended";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyricsMatch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecommended)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.DataGridView dgvRecommended;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnView;
    }
}