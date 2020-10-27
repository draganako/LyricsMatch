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
    public partial class CommentPage : Form
    {

        private User loggedUser;
        private Song currentSong;
        
        public CommentPage(User logged, Song cs)
        {
            loggedUser = logged;
            currentSong = cs;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DataProvider.AddComment(currentSong, loggedUser, rtbxComment.Text);
            this.Close();
        }
    }
}
