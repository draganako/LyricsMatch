using LyricsMatch.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LyricsMatch
{
    public static class ElasticDataProvider
    {
        public static String Language { get; set; } = "";
        public static String Genre { get; set; } = "";
        public static String Location { get; set; } = "All";
        public static Int16 YearFrom { get; set; } = 1960;
        public static Int16 YearTo { get; set; } = 2016;

        public static Boolean AuthorChecked { get; set; } = false;
        public static Boolean NameChecked { get; set; } = false;
        public static Boolean LyricsChecked { get; set; } = false;
        public static bool MatchCase { get; set; }
        public static ElasticClient ElasticsearchClient { get; set; } = GetElasticClient();

        public static List<Song> GetLyrics(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
           .PostFilter(q => q
               .Bool(b =>
               b.Filter(SetFilters()).Must(

                          mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                          mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre)
                          )
                      )
                      ))
           .From(0)
           .Size(400).Query(q => q
           .Range(c => c
           .Field(p => p.Year)
             .GreaterThanOrEquals(YearFrom)
             .LessThanOrEquals(YearTo)
           ))
           .Query(q => q.
           DisMax(dm => dm.Queries
                               (b => b
                                       .Wildcard(m => m
                                           .Value(qs)
                                           .Field(ff => ff.Author)
                                       )
                                      , sh => sh
                                       .Wildcard(m => m
                                           .Value(qs)
                                           .Field(ff => ff.Name)
                                           .Boost(2)
                                       ), sh => sh
                                       .Wildcard(m => m
                                           .Value(qs)
                                           .Field(ff => ff.Lyrics)
                                       )
                                   )))
           )
           ;


            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;

        }

        public static List<Song> GetLyricsByName(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Name).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                            mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre)
                            )
                        )
                        ))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByAuthor(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                       mu => mu.Match(mp => mp.Field(f => f.Author).Query(qs)),
                       mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                       mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre))
                       )
                        ))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByContent(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Lyrics).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                            mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre)
                            ))
                        ))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByNameAuthor(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Name).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Author).Query(qs)),
                            mu => mu.Wildcard(mp => mp.Field(f => f.Language).Value(Language)),
                            mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre))

                        )))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByNameAuthorLyrics(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";


            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Name).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Author).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Lyrics).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                            mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre))

                        )))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByAuthorContent(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";

            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Author).Query(qs)) &&
                            mu.Match(mp => mp.Field(f => f.Lyrics).Query(qs)) &&
                            mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)) &&
                            mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre))

                        )))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }

        public static List<Song> GetLyricsByNameContent(String qs)
        {
            if (!MatchCase && qs != null && qs != "")
                qs = "*" + qs + "*";


            var searchResponse = ElasticsearchClient.Search<Song>(s => s
             .PostFilter(q => q
                 .Bool(b =>
                 b.Filter(SetFilters()).Must(

                            mu => mu.Match(mp => mp.Field(f => f.Name).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Lyrics).Query(qs)),
                            mu => mu.Match(mp => mp.Field(f => f.Language.Suffix("keyword")).Query(Language)),
                            mu => mu.Match(mp => mp.Field(f => f.Genre.Suffix("keyword")).Query(Genre))

                        )))
             .From(0)
             .Size(400).Query(q => q
             .Range(c => c
             .Field(p => p.Year)
               .GreaterThanOrEquals(YearFrom)
               .LessThanOrEquals(YearTo)
             ))
             )
             ;

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }
            return songs;
        }
        private static BulkResponse BulkInsert(ElasticClient client, IEnumerable<Song> entities)
        {
            var request = new BulkDescriptor();

            foreach (var entity in entities)
            {
                request
                    .Index<Song>(op => op
                        .Id(Guid.NewGuid().ToString())
                        .Index("lyrics_data")
                        .Document(entity));
            }

            return client.Bulk(request);
        }

        public static List<Song> GetLyricsByNameAuthorDB(String name, String author)
        {
            var searchResponse = ElasticsearchClient.Search<Song>(s => s
                                      .From(0)
                                      .Size(400)
                                          .Query(q => q
                                              .Match(m => m

                                                  .Field(f => f.Author)
                                                  .Query(author)
                                                  ) && q
                                              .Match(m => m
                                                  .Field(f => f.Name)
                                                  .Query(name)
                                                     )
                                                  )
                                           );

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }

            return songs;
        }

        private static ElasticClient GetElasticClient()
        {
            var local = new Uri("http://localhost:9200/");
            var settings = new ConnectionSettings(local).DefaultIndex("lyrics_data").DisableDirectStreaming()
                   .PrettyJson()
                   .OnRequestCompleted(callDetails =>
                   {
                       if (callDetails.RequestBodyInBytes != null)
                       {
                           System.Diagnostics.Debug.WriteLine(
                               $"{callDetails.HttpMethod} {callDetails.Uri} " +
                               $"{Encoding.UTF8.GetString(callDetails.RequestBodyInBytes)}");
                           Console.ReadLine();
                       }
                       else
                       {
                           System.Diagnostics.Debug.WriteLine($"{callDetails.HttpMethod} {callDetails.Uri}");
                           Console.ReadLine();
                       }

                       System.Diagnostics.Debug.WriteLine("");
                       Console.ReadLine();

                       if (callDetails.ResponseBodyInBytes == null)
                       {
                           System.Diagnostics.Debug.WriteLine($"Status: {callDetails.HttpStatusCode}" +
                                    $"{new string('-', 30)}");
                           Console.ReadLine();
                       }
                   });

            return new ElasticClient(settings);


        }

        private static GeoCoordinate getSelectedNW()
        {
            switch (Location)
            {
                case ("London"):
                    return new GeoCoordinate(51.69, -0.51);
                case ("New York"):
                    return new GeoCoordinate(40.91763, -74.258843);
                case ("Los Angeles"):
                    return new GeoCoordinate(34.3373, -118.6682);
                case ("Chicago"):
                    return new GeoCoordinate(41.8337855, -87.940101);
                case ("Berlin"):
                    return new GeoCoordinate(52.506877, 13.088345);
                case ("Paris"):
                    return new GeoCoordinate(48.8588655, 2.224122);
                case ("Belgrade"):
                    return new GeoCoordinate(44.942688, 20.221376);
                default:
                    return new GeoCoordinate(0, 0);
            }

        }

        private static GeoCoordinate getSelectedSE()
        {
            switch (Location)
            {
                case ("London"):
                    return new GeoCoordinate(51, 0.34);
                case ("New York"):
                    return new GeoCoordinate(40.476578, -73.700233);
                case ("Los Angeles"):
                    return new GeoCoordinate(33.6595, -118.1553);
                case ("Chicago"):
                    return new GeoCoordinate(41.644531, -87.524081);
                case ("Berlin"):
                    return new GeoCoordinate(52.338245, 13.761161);
                case ("Paris"):
                    return new GeoCoordinate(48.815575, 2.46976);
                case ("Belgrade"):
                    return new GeoCoordinate(44.688046, 20.623211);
                default:
                    return new GeoCoordinate(0, 0);
            }

        }

        private static List<Func<QueryContainerDescriptor<Song>, QueryContainer>> SetFilters()
        {
            var filters = new List<Func<QueryContainerDescriptor<Song>, QueryContainer>>();

            if (Location != "All")
            {
                filters.Add(b => b.Bool(p => p
                        .Must(p => p.MatchAll())
                        .Filter(p =>
                         p.GeoShape(c => c
                                    .Field(p => p.Location)
                                    .Shape(s => s
                                        .Envelope(getSelectedNW(), getSelectedSE())
                                     )
                                        .Relation(GeoShapeRelation.Intersects)
                                        )
            )
            )
        );
            }

            return filters;
        }
    }
}

