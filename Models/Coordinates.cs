using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsMatch.Models
{
    public class Coordinates
    {
        [Number(NumberType.Double, Name = "lat")]
        public double Lat { get; set; }

        [Number(NumberType.Double, Name = "lon")]
        public double Lon { get; set; }
    }
}
