namespace LyricsMatch
{
    partial class EditProfilePage
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
            this.btnDoneP = new System.Windows.Forms.Button();
            this.lblEditProfile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPasswordP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxUsernameP = new System.Windows.Forms.TextBox();
            this.tbxLastNameP = new System.Windows.Forms.TextBox();
            this.tbxFirstNameP = new System.Windows.Forms.TextBox();
            this.pbxProfile = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoneP
            // 
            this.btnDoneP.Location = new System.Drawing.Point(140, 406);
            this.btnDoneP.Name = "btnDoneP";
            this.btnDoneP.Size = new System.Drawing.Size(81, 29);
            this.btnDoneP.TabIndex = 28;
            this.btnDoneP.Text = "Done";
            this.btnDoneP.UseVisualStyleBackColor = true;
            this.btnDoneP.Click += new System.EventHandler(this.btnDoneP_Click);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfile.Location = new System.Drawing.Point(21, 24);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Size = new System.Drawing.Size(91, 20);
            this.lblEditProfile.TabIndex = 30;
            this.lblEditProfile.Text = "Edit Profile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Password";
            // 
            // tbxPasswordP
            // 
            this.tbxPasswordP.Location = new System.Drawing.Point(187, 334);
            this.tbxPasswordP.Name = "tbxPasswordP";
            this.tbxPasswordP.Size = new System.Drawing.Size(100, 22);
            this.tbxPasswordP.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "First name";
            // 
            // tbxUsernameP
            // 
            this.tbxUsernameP.Location = new System.Drawing.Point(187, 201);
            this.tbxUsernameP.Name = "tbxUsernameP";
            this.tbxUsernameP.Size = new System.Drawing.Size(100, 22);
            this.tbxUsernameP.TabIndex = 36;
            // 
            // tbxLastNameP
            // 
            this.tbxLastNameP.Location = new System.Drawing.Point(187, 292);
            this.tbxLastNameP.Name = "tbxLastNameP";
            this.tbxLastNameP.Size = new System.Drawing.Size(100, 22);
            this.tbxLastNameP.TabIndex = 38;
            // 
            // tbxFirstNameP
            // 
            this.tbxFirstNameP.Location = new System.Drawing.Point(187, 244);
            this.tbxFirstNameP.Name = "tbxFirstNameP";
            this.tbxFirstNameP.Size = new System.Drawing.Size(100, 22);
            this.tbxFirstNameP.TabIndex = 37;
            // 
            // pbxProfile
            // 
            this.pbxProfile.Image = global::LyricsMatch.Properties.Resources.profilePicture;
            this.pbxProfile.Location = new System.Drawing.Point(140, 53);
            this.pbxProfile.Name = "pbxProfile";
            this.pbxProfile.Size = new System.Drawing.Size(100, 96);
            this.pbxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfile.TabIndex = 44;
            this.pbxProfile.TabStop = false;
            this.pbxProfile.Click += new System.EventHandler(this.pbxProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 217);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal information";
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 455);
            this.Controls.Add(this.pbxProfile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxPasswordP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxUsernameP);
            this.Controls.Add(this.tbxLastNameP);
            this.Controls.Add(this.tbxFirstNameP);
            this.Controls.Add(this.btnDoneP);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditProfile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LyricsMatch";
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDoneP;
        private System.Windows.Forms.Label lblEditProfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPasswordP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUsernameP;
        private System.Windows.Forms.TextBox tbxLastNameP;
        private System.Windows.Forms.TextBox tbxFirstNameP;
        private System.Windows.Forms.PictureBox pbxProfile;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}