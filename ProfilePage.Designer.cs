namespace LyricsMatch
{
    partial class ProfilePage
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvFavorites = new System.Windows.Forms.DataGridView();
            this.btnViewLyrics = new System.Windows.Forms.Button();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.lblProfile = new System.Windows.Forms.Label();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemEditProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(167, 40);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 17);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "lblUsername";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "lblName";
            // 
            // dgvFavorites
            // 
            this.dgvFavorites.AllowUserToAddRows = false;
            this.dgvFavorites.AllowUserToDeleteRows = false;
            this.dgvFavorites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFavorites.Location = new System.Drawing.Point(49, 280);
            this.dgvFavorites.Name = "dgvFavorites";
            this.dgvFavorites.ReadOnly = true;
            this.dgvFavorites.RowHeadersWidth = 51;
            this.dgvFavorites.RowTemplate.Height = 24;
            this.dgvFavorites.Size = new System.Drawing.Size(691, 277);
            this.dgvFavorites.TabIndex = 0;
            // 
            // btnViewLyrics
            // 
            this.btnViewLyrics.Location = new System.Drawing.Point(592, 351);
            this.btnViewLyrics.Name = "btnViewLyrics";
            this.btnViewLyrics.Size = new System.Drawing.Size(122, 34);
            this.btnViewLyrics.TabIndex = 2;
            this.btnViewLyrics.Text = "View Selected";
            this.btnViewLyrics.UseVisualStyleBackColor = true;
            this.btnViewLyrics.Click += new System.EventHandler(this.btnViewLyrics_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Location = new System.Drawing.Point(441, 351);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(125, 34);
            this.btnDeleteSelected.TabIndex = 1;
            this.btnDeleteSelected.Text = "Delete Selected";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(44, 59);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(66, 25);
            this.lblProfile.TabIndex = 4;
            this.lblProfile.Text = "Profile";
            // 
            // pbxProfile
            // 
            this.pbxProfile.Image = global::LyricsMatch.Properties.Resources.profilePicture;
            this.pbxProfile.Location = new System.Drawing.Point(16, 19);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(111, 108);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 0;
            this.pbxProfile.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteSelected);
            this.groupBox1.Controls.Add(this.btnViewLyrics);
            this.groupBox1.Location = new System.Drawing.Point(26, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 402);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Favorites";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemEditProfile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuItemEditProfile
            // 
            this.tsMenuItemEditProfile.Name = "tsMenuItemEditProfile";
            this.tsMenuItemEditProfile.Size = new System.Drawing.Size(96, 24);
            this.tsMenuItemEditProfile.Text = "Edit Profile";
            this.tsMenuItemEditProfile.Click += new System.EventHandler(this.tsMenuItemEditProfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.pbxProfile);
            this.groupBox2.Controls.Add(this.lblUsername);
            this.groupBox2.Location = new System.Drawing.Point(195, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(415, 133);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Delete Selected";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(592, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "View Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ProfilePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.dgvFavorites);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProfilePage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyricsMatch";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFavorites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvFavorites;
        private System.Windows.Forms.Button btnViewLyrics;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemEditProfile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}