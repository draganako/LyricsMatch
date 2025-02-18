using LyricsMatch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsMatch
{
    public partial class RecommendedPage : Form
    {
        User loggedUser;
        List<Song> recommendedLyrics;
        public RecommendedPage(User logged)
        {
            loggedUser = logged;
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            dgvRecommended.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecommended.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvRecommended.DataSource = new List<Song>();
            dgvRecommended.Columns["id"].Visible = false;
            dgvRecommended.Columns["name"].HeaderText = "Name";
            dgvRecommended.Columns["author"].HeaderText = "Author";
            dgvRecommended.Columns["language"].HeaderText = "Language";
            dgvRecommended.Columns["genre"].HeaderText = "Genre";

            dgvRecommended.Columns["locationname"].Visible = false;
            dgvRecommended.Columns["year"].Visible = false;
            dgvRecommended.Columns["location"].Visible = false;
            dgvRecommended.Columns["locationcenter"].Visible = false;
            dgvRecommended.Columns["lyrics"].Visible = false;
            dgvRecommended.Columns["views"].Visible = false;

            dgvRecommended.MultiSelect = false;
            dgvRecommended.ClearSelection();


            InsertPopularSongs();
            dgvRecommended.ClearSelection();

        }

        private void InsertPopularSongs()
        {
            recommendedLyrics = DataProvider.GetPopularSongs();

            if (recommendedLyrics.Count != 0)
            {
                recommendedLyrics = DataProvider.InsertIdsAndViewsToSongs(recommendedLyrics);
                dgvRecommended.DataSource = recommendedLyrics;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvRecommended.SelectedRows.Count > 0)
            {
                using (LyricsPage formChild = new LyricsPage((Song)dgvRecommended.CurrentRow.DataBoundItem, loggedUser))
                {
                    formChild.ShowDialog();
                    InsertPopularSongs();

                }
            }
        }
    }    
}
