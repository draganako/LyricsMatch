using Nest;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LyricsMatch.Models;
using System.Windows;

namespace LyricsMatch
{
    public partial class MainPage : Form
    {
        private bool historyVisible = false;
        private User loggedUser;
        private List<Song> resultsList = new List<Song>();
        private int index;
        private int resultsPerPage = 20;
        private int startingIndex = 0;
        private int endingIndex;
        private bool flag;
        public MainPage(User loggedUser)
        {
            this.loggedUser = loggedUser;
            InitializeComponent();
            Prepare();
            EstablishConnectionToElasticsearch();
            EstablishConnectionToMySQL();
        }
        private bool EstablishConnectionToElasticsearch()
        {
            var local = new Uri("http://localhost:9200");

            var settings = new ConnectionSettings(local);

            var elastic = new ElasticClient(settings);

            var res = elastic.Cluster.Health();

            if(!res.IsValid)
                System.Windows.Forms.MessageBox.Show( "Can't connect to database", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return res.IsValid;
        }
        private bool EstablishConnectionToMySQL()
        {

                string connstring = @"server=localhost;userid=root;password=root;database=lyricsmatch";

                MySqlConnection conn = null;

                try
                {
                    conn = new MySqlConnection(connstring);
                    conn.Open();

                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show( e.ToString(), "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return false;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }

            return true;
            
        }

        private void Prepare()
        {
            lblNumOfResults.Text = "";

            List<string> sourceGenres = DataProvider.Genres;
            sourceGenres.Insert(0, "All");
            cbxGenre.DataSource = sourceGenres;
            cbxGenre.SelectedItem = cbxGenre.Items[0];
            DataProvider.Genres.Remove("All");

            List<string> sourceLanguages = DataProvider.Languages;
            sourceLanguages.Insert(0, "All");
            cbxLanguage.DataSource = sourceLanguages;
            cbxLanguage.SelectedItem = cbxLanguage.Items[0];
            DataProvider.Languages.Remove("All");

            List<string> sourceLocations = DataProvider.Locations;
            sourceLocations.Insert(0, "All");
            cbxLocation.DataSource = sourceLocations;
            cbxLocation.SelectedItem = cbxLocation.Items[0];
            DataProvider.Locations.Remove("All");

            List<string> sourceYearsFrom = DataProvider.YearsFrom.ConvertAll<string>(x => x.ToString());
            sourceYearsFrom.Insert(0, "All");
            cbxFrom.DataSource = sourceYearsFrom;
            cbxFrom.SelectedItem = cbxFrom.Items[0];

            List<string> sourceYearsTo = DataProvider.YearsTo.ConvertAll<string>(x => x.ToString());
            sourceYearsTo.Insert(0, "All");
            cbxTo.DataSource = sourceYearsTo;
            cbxTo.SelectedItem = cbxTo.Items[0];

            //DataProvider.Years.Remove("All");

            btnPrevious.Visible = false;
            btnNext.Visible = false;

            lbxHistory.DataSource = DataProvider.GetUserHistory(loggedUser);
            lbxHistory.Visible = historyVisible;
            lbxHistory.SelectionMode = SelectionMode.One;
            lbxHistory.ClearSelected();

            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvResults.DataSource = new List<Song>();
            dgvResults.Columns["id"].Visible = false;
            dgvResults.Columns["name"].HeaderText = "Name";
            dgvResults.Columns["author"].HeaderText = "Author";
            dgvResults.Columns["language"].HeaderText = "Language";
            dgvResults.Columns["genre"].HeaderText = "Genre";
            dgvResults.Columns["year"].HeaderText = "Year";
            dgvResults.Columns["locationname"].HeaderText = "Location";

            dgvResults.Columns["location"].Visible = false;
            dgvResults.Columns["locationcenter"].Visible = false;
            dgvResults.Columns["lyrics"].Visible = false;
            dgvResults.Columns["views"].Visible = false;

            dgvResults.MultiSelect = false;
            dgvResults.ClearSelection();

        }
       
        private void ChangeHistoryVisibility()
        {
            historyVisible = !historyVisible;
            lbxHistory.Visible = historyVisible;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
            MakeHistoryUpdates();
            
        }

        private void MakeHistoryUpdates()
        {
            DataProvider.AddToUserHistory(loggedUser, tbxSearch.Text);
            List<string> res = DataProvider.GetUserHistory(loggedUser);
            int count = res.Count;
            lbxHistory.DataSource = res;
            lbxHistory.SelectedIndex = count - 1;
            lbxHistory.ClearSelected();
        }

        private void ExecuteSearch()
        {
            String queryString = tbxSearch.Text;
            List<Song> retrievedResults=new List<Song>();

            if (cbxAuthor.Checked && cbxName.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByNameAuthor(queryString);
            if (cbxAuthor.Checked && cbxName.Checked && cbxLyrics.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByNameAuthorLyrics(queryString);
            else if (cbxAuthor.Checked && cbxName.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByNameAuthor(queryString);
            else if (cbxAuthor.Checked && cbxLyrics.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByAuthorContent(queryString);
            else if (cbxName.Checked && cbxLyrics.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByNameContent(queryString);
            else if (cbxAuthor.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByAuthor(queryString);
            else if (cbxName.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByName(queryString);
            else if (cbxLyrics.Checked)
                retrievedResults = ElasticDataProvider.GetLyricsByContent(queryString);
            else
                retrievedResults = ElasticDataProvider.GetLyrics(queryString);


            lblNumOfResults.Text = "Results found: " + retrievedResults.Count;

            foreach(Song song in retrievedResults)
            {
                switch (song.LocationCenter.Coordinates.Longitude)
                {
                    case -0.09: song.LocationName = "London";break;
                    case -73.979538: song.LocationName = "New York"; break;
                    case -118.41175: song.LocationName = "Los Angeles"; break;
                    case -87.732091: song.LocationName = "Chicago"; break;
                    case 13.424753: song.LocationName = "Berlin"; break;
                    case 2.346941: song.LocationName = "Paris"; break;
                    case 20.4222935: song.LocationName = "Belgrade"; break;

                    default: song.LocationName = "London"; break;
                }
           
            }

            if (retrievedResults.Count == 0)
                resultsList = new List<Song>();
            else
            {
                retrievedResults = DataProvider.InsertIdsAndViewsToSongs(retrievedResults);
                resultsList = retrievedResults;
            }

            PopulateGridWithResults(false);
            ChangeNextVisibility();

        }

        private void ChangeNextVisibility()
        {
            if (endingIndex == resultsList.Count - 1)
                btnNext.Visible = false;
            else
                btnNext.Visible = true;
        }
        private void ChangePreviousVisibility()
        {
            if (startingIndex == 0)
                btnPrevious.Visible = false;
            else
                btnPrevious.Visible = true;
        }

        private void UpdateResults(bool refresh)
        {
            resultsList = DataProvider.InsertIdsAndViewsToSongs(resultsList);

            PopulateGridWithResults(refresh);

            ChangePreviousVisibility();
            ChangeNextVisibility();
        }

        private void PopulateGridWithResults(bool refresh)
        {
            if (!refresh)
            {
                startingIndex = 0;
                endingIndex = startingIndex + resultsPerPage - 1;
                if (endingIndex >= resultsList.Count)
                    endingIndex = resultsList.Count - 1;
            }
            int numPerPage = endingIndex - startingIndex + 1;
            dgvResults.DataSource = resultsList.GetRange(startingIndex, numPerPage);
            dgvResults.ClearSelection();
        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvResults.SelectedRows.Count > 0)
            {
                using (LyricsPage formChild = new LyricsPage((Song)dgvResults.CurrentRow.DataBoundItem, loggedUser))
                {
                    formChild.ShowDialog();
                    UpdateResults(true);
                }

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            startingIndex -= resultsPerPage;
            endingIndex = startingIndex + resultsPerPage - 1;
            dgvResults.DataSource = resultsList.GetRange(startingIndex, resultsPerPage);

            dgvResults.ClearSelection();

            ChangePreviousVisibility();
            ChangeNextVisibility();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            startingIndex += resultsPerPage;
            endingIndex = startingIndex + resultsPerPage - 1;
            if (endingIndex >= resultsList.Count)
                endingIndex = resultsList.Count - 1;
            int numPerPage = endingIndex - startingIndex + 1;
            dgvResults.DataSource = resultsList.GetRange(startingIndex, numPerPage);

            dgvResults.ClearSelection();

            ChangePreviousVisibility();
            ChangeNextVisibility();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form stats = new StatisticsPage();
            stats.Show();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ProfilePage(loggedUser, true);
            f.Show();
        }

        private void topLyricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form f = new RecommendedPage(loggedUser))
            {
                f.ShowDialog();
                UpdateResults(true);
            }
        }

        private void lbxHistory_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                index = lbxHistory.IndexFromPoint(e.Location);
                {
                    if (index == lbxHistory.SelectedIndex)
                    {
                        contextMenuStripOptions.Show(Cursor.Position);
                    }
                }
            }
            flag = true;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxHistory.DataSource = DataProvider.DeleteHistoryItem(loggedUser, lbxHistory.SelectedItem.ToString());
            lbxHistory.ClearSelected();

        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxHistory.DataSource = DataProvider.DeleteHistory(loggedUser);
            lbxHistory.ClearSelected();

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeHistoryVisibility();
        }

        private void historyToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            ChangeHistoryVisibility();
        }

        private void lbxHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                if (lbxHistory.SelectedValue != null)
                    tbxSearch.Text = lbxHistory.SelectedValue.ToString();
                flag = false;
            }
            else
                return;
        }

        private void cbxName_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxName.Checked)
                ElasticDataProvider.NameChecked = true;
            else
                ElasticDataProvider.NameChecked = false;
        }

        private void cbxAuthor_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxAuthor.Checked)
                ElasticDataProvider.AuthorChecked = true;
            else
                ElasticDataProvider.AuthorChecked = false;
        }

        private void cbxLyrics_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbxLyrics.Checked)
                ElasticDataProvider.LyricsChecked = true;
            else
                ElasticDataProvider.LyricsChecked = false;

        }

        private void cbxLocation_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ElasticDataProvider.Location = cbxLocation.Text;
        }

        private void cbxGenre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxGenre.Text != "All")
                ElasticDataProvider.Genre = cbxGenre.Text;
            else
                ElasticDataProvider.Genre = "";
        }

        private void cbxFrom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!cbxFrom.Text.Equals("All") && !cbxFrom.Text.Equals(null))
                ElasticDataProvider.YearFrom = Int16.Parse(cbxFrom.Text);
        }

        private void cbxTo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!cbxTo.Text.Equals("All") && !cbxTo.Text.Equals(null))
                ElasticDataProvider.YearTo = Int16.Parse(cbxTo.Text);
        }

        private void cbxMatch_CheckedChanged_1(object sender, EventArgs e)
        {
            ElasticDataProvider.MatchCase = cbxMatch.Checked;
        }

        private void cbxLanguage_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbxLanguage.Text != "All")
                ElasticDataProvider.Language = cbxLanguage.Text;
            else
                ElasticDataProvider.Language = "";
        }
    }
}
