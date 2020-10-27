namespace LyricsMatch
{
    partial class LyricsPage
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
            this.rtbxLyrics = new System.Windows.Forms.RichTextBox();
            this.lblSongName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lbxComments = new System.Windows.Forms.ListBox();
            this.btnPostNewComment = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbxLyrics
            // 
            this.rtbxLyrics.BackColor = System.Drawing.SystemColors.Menu;
            this.rtbxLyrics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbxLyrics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxLyrics.Location = new System.Drawing.Point(192, 145);
            this.rtbxLyrics.Name = "rtbxLyrics";
            this.rtbxLyrics.Size = new System.Drawing.Size(419, 455);
            this.rtbxLyrics.TabIndex = 1;
            this.rtbxLyrics.Text = "";
            this.rtbxLyrics.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbxLyrics_MouseClick);
            this.rtbxLyrics.MouseHover += new System.EventHandler(this.rtbxLyrics_MouseHover);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.Location = new System.Drawing.Point(241, 55);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(116, 25);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Song Name";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(234, 90);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(51, 18);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // lbxComments
            // 
            this.lbxComments.FormattingEnabled = true;
            this.lbxComments.HorizontalScrollbar = true;
            this.lbxComments.ItemHeight = 16;
            this.lbxComments.Location = new System.Drawing.Point(113, 655);
            this.lbxComments.Name = "lbxComments";
            this.lbxComments.Size = new System.Drawing.Size(567, 116);
            this.lbxComments.TabIndex = 1;
            // 
            // btnPostNewComment
            // 
            this.btnPostNewComment.Location = new System.Drawing.Point(336, 166);
            this.btnPostNewComment.Name = "btnPostNewComment";
            this.btnPostNewComment.Size = new System.Drawing.Size(97, 26);
            this.btnPostNewComment.TabIndex = 3;
            this.btnPostNewComment.Text = "Post new";
            this.btnPostNewComment.UseVisualStyleBackColor = true;
            this.btnPostNewComment.Click += new System.EventHandler(this.btnPostNewComment_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(439, 166);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(156, 26);
            this.btnViewProfile.TabIndex = 4;
            this.btnViewProfile.Text = "View selected profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnPostNewComment);
            this.groupBox1.Controls.Add(this.btnViewProfile);
            this.groupBox1.Location = new System.Drawing.Point(85, 626);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 212);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comments";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToFavoritesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToFavoritesToolStripMenuItem
            // 
            this.addToFavoritesToolStripMenuItem.Name = "addToFavoritesToolStripMenuItem";
            this.addToFavoritesToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.addToFavoritesToolStripMenuItem.Text = "Add to favorites";
            this.addToFavoritesToolStripMenuItem.Click += new System.EventHandler(this.addToFavoritesToolStripMenuItem_Click);
            // 
            // LyricsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 851);
            this.Controls.Add(this.lbxComments);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblSongName);
            this.Controls.Add(this.rtbxLyrics);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LyricsPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LyricsMatch";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxLyrics;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ListBox lbxComments;
        private System.Windows.Forms.Button btnPostNewComment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToFavoritesToolStripMenuItem;
    }
}