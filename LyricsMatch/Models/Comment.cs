using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsMatch.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public String Text { get; set; }
        public int Song_id { get; set; }
        public int User_idd { get; set; }
    }
}
