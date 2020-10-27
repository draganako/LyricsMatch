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
    public partial class EditProfilePage : Form
    {
        private User loggedUser;
        private ProfilePage profilePage;

        public EditProfilePage(ProfilePage profilePage)
        {
            loggedUser = profilePage.LoggedUser;
            this.profilePage = profilePage;
            InitializeComponent();
            Prepare();
        }

        private void Prepare()
        {
            tbxFirstNameP.Text = loggedUser.FirstName;
            tbxLastNameP.Text = loggedUser.LastName;
            tbxPasswordP.Text = loggedUser.Password;
            tbxUsernameP.Text = loggedUser.Username;

            if ((loggedUser.Picture == null) || (loggedUser.Picture == ""))
                pbxProfile.Image = Properties.Resources.profilePicture;
            else
                pbxProfile.Image = new Bitmap(loggedUser.Picture);

        }

        private void PropagateChangesToProfile()
        {
            profilePage.LoggedUser.FirstName = tbxFirstNameP.Text;
            profilePage.LoggedUser.LastName = tbxLastNameP.Text;
            profilePage.LoggedUser.Password = tbxPasswordP.Text;
            profilePage.LoggedUser.Username = tbxUsernameP.Text;

            if (loggedUser.Picture != null)
                profilePage.LoggedUser.Picture = loggedUser.Picture;
        }

        private bool IsPasswordStrong()
        {
            if (tbxPasswordP.TextLength >= 7 && tbxPasswordP.Text.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        private void pbxProfile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    pbxProfile.Image = new Bitmap(openFileDialog.FileName);
                    loggedUser.Picture = filePath;

                }
            }
        }

        private void btnDoneP_Click(object sender, EventArgs e)
        {
            if (IsPasswordStrong())
            {
                PropagateChangesToProfile();
                DataProvider.UpdateUser(loggedUser);

                this.Close();
            }
            else
                MessageBox.Show("Password has to be at least 7 characters long and contain digits",
                                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
