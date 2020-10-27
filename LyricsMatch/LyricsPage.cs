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
    public partial class LyricsPage : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "HideCaret")]
        public static extern long HideCaret(IntPtr hwnd);

        private Song selectedLyrics;
        private User loggedUser;

        public LyricsPage(Song selectedLyrics,User lu)
        {
            loggedUser = lu;
            this.selectedLyrics = selectedLyrics;
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            InsertLyricsId();
            HideCaret(rtbxLyrics.Handle);
            selectedLyrics.Lyrics= ElasticDataProvider.GetLyricsByNameAuthor(selectedLyrics.Name, selectedLyrics.Author)[0].Lyrics;

            rtbxLyrics.Text = ReplaceFullstopDelimiters(selectedLyrics.Lyrics);
            lblSongName.Text = selectedLyrics.Name;
            lblAuthor.Text = "by "+selectedLyrics.Author;

            lbxComments.DataSource = DataProvider.GetSongCommentsAsStrings(selectedLyrics);
            lbxComments.SelectionMode = SelectionMode.One;
            lbxComments.ClearSelected();
               
        }

        private string ReplaceFullstopDelimiters(string lyrics)
        {
            return " "+lyrics.Replace(".", "\n");
        }

        private void InsertLyricsId()
        {
            if (selectedLyrics.Id == 0)
                selectedLyrics.Id = DataProvider.AddSongIfNotExists(selectedLyrics);
            else
                DataProvider.UpdateSongViews(selectedLyrics);

        }
        public void RefreshComments()
        {
            lbxComments.DataSource = DataProvider.GetSongCommentsAsStrings(selectedLyrics);
        }

        private void addToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataProvider.AddUserSong(loggedUser, selectedLyrics);
            MessageBox.Show("Song added to favorites", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPostNewComment_Click(object sender, EventArgs e)
        {
            using (CommentPage formChild = new CommentPage(loggedUser, selectedLyrics))
            {
                formChild.ShowDialog();
                RefreshComments();
            }
        }

        private void rtbxLyrics_MouseClick(object sender, MouseEventArgs e)
        {
            HideCaret(rtbxLyrics.Handle);

        }

        private void rtbxLyrics_MouseHover(object sender, EventArgs e)
        {
            HideCaret(rtbxLyrics.Handle);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] words = lbxComments.SelectedItem.ToString().Split(':');
            string[] tmp = words[1].Split(' ');
            string commentText = tmp[1];
            if(words[0].Equals(loggedUser.Username))
                lbxComments.DataSource = DataProvider.DeleteComment(loggedUser, commentText, selectedLyrics);
            else
                MessageBox.Show("Deletion of other users' comments is not permitted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (lbxComments.SelectedItems.Count != 0)
            {
                string[] words = lbxComments.SelectedItem.ToString().Split(':');
                string username = words[0];
                Form f = null;

                if (username.Equals(loggedUser.Username))
                    f = new ProfilePage(loggedUser, true);
                else
                {
                    User user = DataProvider.GetUser(username);
                    f = new ProfilePage(user, false);
                }
                f.Show();
            }

        }


    }
}
