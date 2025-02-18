using LyricsMatch.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LyricsMatch
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
            tbxPass.PasswordChar = '\u25CF';
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (DataProvider.CheckUsername(tbxUsername.Text))
            {
                User loggedUser = DataProvider.GetUser(tbxUsername.Text, tbxPass.Text);
                if (loggedUser != null)
                {
                    Form f = new MainPage(loggedUser);
                    f.Show();
                }
                else
                    MessageBox.Show("The password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
                MessageBox.Show("User with given username doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new SignUpPage();
            f.Show();
        }
    }
}
