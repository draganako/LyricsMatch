using LyricsMatch.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsMatch
{
    public partial class ProfilePage : Form
    {
        public User LoggedUser { get; set; }
        private User otherUser;

        public ProfilePage(User user,bool personal)
        {
            if (personal)
                this.LoggedUser = user;
            else
                this.otherUser = user;

            InitializeComponent();
            Prepare();

        }

        private void Prepare()
        {
            if (LoggedUser != null)
            {
                Prepare(LoggedUser);
                lblProfile.Text = "My profile";
            }
            else if (otherUser != null)
            {
                Prepare(otherUser);
                btnDeleteSelected.Visible = false;
                tsMenuItemEditProfile.Visible = false;
            }

            dgvFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFavorites.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFavorites.MultiSelect = false;
            dgvFavorites.ClearSelection();

            dgvFavorites.Columns["id"].Visible = false;
            dgvFavorites.Columns["name"].HeaderText = "Name";
            dgvFavorites.Columns["author"].HeaderText = "Author";
            dgvFavorites.Columns["language"].HeaderText = "Language";
            dgvFavorites.Columns["genre"].HeaderText = "Genre";

            dgvFavorites.Columns["locationname"].Visible = false;
            dgvFavorites.Columns["year"].Visible = false;
            dgvFavorites.Columns["location"].Visible = false;
            dgvFavorites.Columns["locationcenter"].Visible = false;
            dgvFavorites.Columns["lyrics"].Visible = false;
            dgvFavorites.Columns["views"].Visible = false;
            
            dgvFavorites.MultiSelect = false;
            dgvFavorites.ClearSelection();


        }

        private void Prepare(User u)
        {
            lblUsername.Text = "Username: "+ u.Username;
            lblName.Text = "Name: " + u.FirstName + " " + u.LastName;
            dgvFavorites.DataSource = DataProvider.GetUserSongs(u);

            if ((u.Picture == null) || (u.Picture==""))
                pbxProfile.Image = Properties.Resources.profilePicture;
            else
                pbxProfile.Image = new Bitmap(u.Picture);
        }

        private void btnViewLyrics_Click(object sender, EventArgs e)
        {
            if (dgvFavorites.SelectedRows.Count > 0)
            {
                Song song = (Song)dgvFavorites.CurrentRow.DataBoundItem;

                Form f = new LyricsPage(song, LoggedUser);
                f.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            dgvFavorites.DataSource= DataProvider.DeleteUserSong(LoggedUser, (Song)dgvFavorites.CurrentRow.DataBoundItem);
        }

        private void tsMenuItemEditProfile_Click(object sender, EventArgs e)
        {
            using (Form f=new EditProfilePage(this))
            {
                f.ShowDialog();
                Prepare();
            }
        }
    }
}
