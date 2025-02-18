namespace LyricsMatch
{
    partial class MainPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNumOfResults = new System.Windows.Forms.Label();
            this.gbxFilters = new System.Windows.Forms.GroupBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLyricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbxHistory = new System.Windows.Forms.ListBox();
            this.contextMenuStripOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.cbxLyrics = new System.Windows.Forms.CheckBox();
            this.cbxMatch = new System.Windows.Forms.CheckBox();
            this.cbxName = new System.Windows.Forms.CheckBox();
            this.cbxAuthor = new System.Windows.Forms.CheckBox();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.menuMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStripOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(465, 51);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LyricsMatch";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(111, 34);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(353, 27);
            this.tbxSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(496, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(796, 326);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(110, 32);
            this.btnView.TabIndex = 7;
            this.btnView.Text = "View selected";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(55, 48);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(856, 244);
            this.dgvResults.TabIndex = 6;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(420, 325);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(55, 32);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "◄";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(491, 325);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 32);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "►";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNumOfResults
            // 
            this.lblNumOfResults.AutoSize = true;
            this.lblNumOfResults.Location = new System.Drawing.Point(47, 325);
            this.lblNumOfResults.Name = "lblNumOfResults";
            this.lblNumOfResults.Size = new System.Drawing.Size(22, 20);
            this.lblNumOfResults.TabIndex = 15;
            this.lblNumOfResults.Text = "nr";
            // 
            // gbxFilters
            // 
            this.gbxFilters.Location = new System.Drawing.Point(124, 221);
            this.gbxFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFilters.Name = "gbxFilters";
            this.gbxFilters.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFilters.Size = new System.Drawing.Size(823, 141);
            this.gbxFilters.TabIndex = 16;
            this.gbxFilters.TabStop = false;
            this.gbxFilters.Text = "Filters";
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.profileToolStripMenuItem,
            this.topLyricsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuMain.Size = new System.Drawing.Size(1160, 28);
            this.menuMain.TabIndex = 25;
            this.menuMain.Text = "menuStrip1";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            this.historyToolStripMenuItem.DoubleClick += new System.EventHandler(this.historyToolStripMenuItem_DoubleClick);
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // topLyricsToolStripMenuItem
            // 
            this.topLyricsToolStripMenuItem.Name = "topLyricsToolStripMenuItem";
            this.topLyricsToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.topLyricsToolStripMenuItem.Text = "Recommended";
            this.topLyricsToolStripMenuItem.Click += new System.EventHandler(this.topLyricsToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvResults);
            this.groupBox1.Controls.Add(this.lblNumOfResults);
            this.groupBox1.Controls.Add(this.btnPrevious);
            this.groupBox1.Controls.Add(this.btnNext);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Location = new System.Drawing.Point(57, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(955, 360);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbxSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(184, 128);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(714, 85);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // lbxHistory
            // 
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.ItemHeight = 20;
            this.lbxHistory.Location = new System.Drawing.Point(965, 39);
            this.lbxHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(183, 364);
            this.lbxHistory.TabIndex = 16;
            this.lbxHistory.SelectedIndexChanged += new System.EventHandler(this.lbxHistory_SelectedIndexChanged);
            this.lbxHistory.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxHistory_MouseDown);
            // 
            // contextMenuStripOptions
            // 
            this.contextMenuStripOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.contextMenuStripOptions.Name = "contextMenuStripOptions";
            this.contextMenuStripOptions.Size = new System.Drawing.Size(145, 52);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(667, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "To";
            // 
            // cbxTo
            // 
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Metal",
            "Blues",
            "Country",
            "Hip Hop",
            "Punk",
            "Dance",
            "Trap",
            "R\'n\'B"});
            this.cbxTo.Location = new System.Drawing.Point(705, 317);
            this.cbxTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(77, 28);
            this.cbxTo.TabIndex = 43;
            this.cbxTo.SelectedIndexChanged += new System.EventHandler(this.cbxTo_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "From";
            // 
            // cbxFrom
            // 
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Metal",
            "Blues",
            "Country",
            "Hip Hop",
            "Punk",
            "Dance",
            "Trap",
            "R\'n\'B"});
            this.cbxFrom.Location = new System.Drawing.Point(540, 317);
            this.cbxFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(77, 28);
            this.cbxFrom.TabIndex = 41;
            this.cbxFrom.SelectedIndexChanged += new System.EventHandler(this.cbxFrom_SelectedIndexChanged_1);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(139, 320);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 40;
            this.lblLocation.Text = "Location";
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Metal",
            "Blues",
            "Country",
            "Hip Hop",
            "Punk",
            "Dance",
            "Trap",
            "R\'n\'B"});
            this.cbxGenre.Location = new System.Drawing.Point(455, 268);
            this.cbxGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(121, 28);
            this.cbxGenre.TabIndex = 36;
            this.cbxGenre.SelectedIndexChanged += new System.EventHandler(this.cbxGenre_SelectedIndexChanged_1);
            // 
            // cbxLocation
            // 
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Items.AddRange(new object[] {
            "Pop",
            "Rock",
            "Metal",
            "Blues",
            "Country",
            "Hip Hop",
            "Punk",
            "Dance",
            "Trap",
            "R\'n\'B"});
            this.cbxLocation.Location = new System.Drawing.Point(226, 317);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(203, 28);
            this.cbxLocation.TabIndex = 39;
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged_1);
            // 
            // cbxLyrics
            // 
            this.cbxLyrics.AutoSize = true;
            this.cbxLyrics.Location = new System.Drawing.Point(315, 272);
            this.cbxLyrics.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLyrics.Name = "cbxLyrics";
            this.cbxLyrics.Size = new System.Drawing.Size(66, 24);
            this.cbxLyrics.TabIndex = 33;
            this.cbxLyrics.Text = "Lyrics";
            this.cbxLyrics.UseVisualStyleBackColor = true;
            this.cbxLyrics.CheckedChanged += new System.EventHandler(this.cbxLyrics_CheckedChanged_1);
            // 
            // cbxMatch
            // 
            this.cbxMatch.AutoSize = true;
            this.cbxMatch.Location = new System.Drawing.Point(812, 274);
            this.cbxMatch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxMatch.Name = "cbxMatch";
            this.cbxMatch.Size = new System.Drawing.Size(107, 24);
            this.cbxMatch.TabIndex = 38;
            this.cbxMatch.Text = "Match Case";
            this.cbxMatch.UseVisualStyleBackColor = true;
            this.cbxMatch.CheckedChanged += new System.EventHandler(this.cbxMatch_CheckedChanged_1);
            // 
            // cbxName
            // 
            this.cbxName.AutoSize = true;
            this.cbxName.Location = new System.Drawing.Point(139, 272);
            this.cbxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxName.Name = "cbxName";
            this.cbxName.Size = new System.Drawing.Size(71, 24);
            this.cbxName.TabIndex = 31;
            this.cbxName.Text = "Name";
            this.cbxName.UseVisualStyleBackColor = true;
            this.cbxName.CheckedChanged += new System.EventHandler(this.cbxName_CheckedChanged_1);
            // 
            // cbxAuthor
            // 
            this.cbxAuthor.AutoSize = true;
            this.cbxAuthor.Location = new System.Drawing.Point(216, 272);
            this.cbxAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxAuthor.Name = "cbxAuthor";
            this.cbxAuthor.Size = new System.Drawing.Size(76, 24);
            this.cbxAuthor.TabIndex = 32;
            this.cbxAuthor.Text = "Author";
            this.cbxAuthor.UseVisualStyleBackColor = true;
            this.cbxAuthor.CheckedChanged += new System.EventHandler(this.cbxAuthor_CheckedChanged_1);
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "Basque",
            "Na"});
            this.cbxLanguage.Location = new System.Drawing.Point(682, 270);
            this.cbxLanguage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(100, 28);
            this.cbxLanguage.TabIndex = 34;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Language";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "Genre";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 790);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cbxGenre);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.cbxLyrics);
            this.Controls.Add(this.cbxMatch);
            this.Controls.Add(this.cbxName);
            this.Controls.Add(this.cbxAuthor);
            this.Controls.Add(this.cbxLanguage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxFilters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStripOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblNumOfResults;
        private System.Windows.Forms.GroupBox gbxFilters;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topLyricsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ListBox lbxHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOptions;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.CheckBox cbxLyrics;
        private System.Windows.Forms.CheckBox cbxMatch;
        private System.Windows.Forms.CheckBox cbxName;
        private System.Windows.Forms.CheckBox cbxAuthor;
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

