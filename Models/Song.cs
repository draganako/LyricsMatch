using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using GeoAPI.Geometries;

namespace LyricsMatch.Models
{
   
    [ElasticsearchType(RelationName = "songs")]
    public class Song
    {
        public int Id { get; set; }

        [Text(Name = "Author")]
        public String Author { get; set; }

        [Text(Name = "Name")]
        public String Name { get; set; }

        [Text(Name = "Genre", Fielddata =true)]
        public String Genre { get; set; }

        [Text(Name = "Language")]
        public String Language { get; set; }

        [Text(Name = "Lyrics")]
        public String Lyrics { get; set; }

        [Text(Name = "Year")]
        public Int16 Year { get; set; }

        [GeoShape(Name = "location")]
        public EnvelopeGeoShape Location { get; set; }

        [GeoPoint(Name = "location_center")]
        public PointGeoShape LocationCenter { get; set; }

        public int Views { get; set; }
        public String LocationName { get; set; }
    }
    
}
