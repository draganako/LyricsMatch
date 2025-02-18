using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsMatch.Models
{
    public class User
    {

      public int Id { get; set; }
      public String Username { get; set; }
      public String FirstName { get; set; }    
      public String LastName { get; set; }
      public String Password { get; set; }
      public String Picture { get; set; }

    }
}
