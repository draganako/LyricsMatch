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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private bool IsPasswordStrong()
        {
            if (tbxPassword.TextLength >= 7 && tbxPassword.Text.Any(char.IsDigit))
                return true;
            else
                return false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (DataProvider.CheckUsername(tbxUsername.Text))
                MessageBox.Show("Username already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (IsPasswordStrong())
                {
                    User user = new User();
                    user.Username = tbxUsername.Text;
                    user.FirstName = tbxFirstName.Text;
                    user.LastName = tbxLastName.Text;
                    user.Password = tbxPassword.Text;
                    user.Picture = null;

                    Form f = new MainPage(DataProvider.AddUser(user));
                    f.Show();
                }
                else
                    MessageBox.Show("Password has to be at least 7 characters long and contain digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
