using LyricsMatch.Models;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricsMatch
{
    public static class ElasticDataProvider
    {
        public static String Language { get; set; }
        public static String Genre { get; set; }
        public static bool MatchCase { get; set; }

        public static List<Song> GetLyrics(String qs)
        {
            if(!MatchCase)
                qs = "*" + qs + "*";
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DefaultIndex("songs");
            var client = new ElasticClient(settings);
            var searchResponse = client.Search<Song>(s => s.PostFilter
                        (f => f.Bool(b => b
                          .Must(mu =>
                           {
                               if (Language != "All")
                               {
                                   mu.Term(m => m
                                               .Value(Language)
                                               .Field(ff => ff.Language)
                                              );
                               }
                               if (Genre != "All")
                               {
                                   mu.Term(m => m
                                               .Value(Genre)
                                               .Field(ff => ff.Genre)
                                              );
                               }
                               return mu;       
                           }
                        )))
                        .From(0)
                        .Size(400)
                        .Query(q => q
                        .DisMax(dm => dm.Queries
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
                                 )
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
        public static List<Song> GetLyricsByAuthor(String qs)
        {
            if (!MatchCase)
                qs = "*" + qs + "*";
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DefaultIndex("songs");
            var client = new ElasticClient(settings);
            var searchResponse = client.Search<Song>(s => s.PostFilter
                        (f => f.Bool(b => b
                          .Must(mu =>
                          {

                              if (Language != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Language)
                                              .Field(ff => ff.Language)
                                             );
                              }

                              return mu;
                          }
                          ,
                          mu =>
                          {
                              if (Genre != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Genre)
                                              .Field(ff => ff.Genre)
                                             );
                              }
                              return mu;
                          }
                        )
                        )).Sort(ss => ss
                            .Field(f =>
                            {
                                f.Order(Nest.SortOrder.Ascending);
                                f.Field(ff => ff.Name.Suffix("raw"));
                                return f;
                            }
                            ))
                        .From(0)
                        .Size(400)
                        .Query(q => q
                        .DisMax(dm => dm.Queries
                             (b => b
                                     .Wildcard(m => m
                                         .Value(qs)
                                         .Field(ff => ff.Author)
                                     )
                                 )
                             ))

                    );

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }

            return songs;
            
        }
        public static List<Song> GetLyricsByName(String qs)
        {
            if (!MatchCase)
                qs = "*" + qs + "*";
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DefaultIndex("songs");
            var client = new ElasticClient(settings);
            var searchResponse = client.Search<Song>(s => s.PostFilter
                        (f => f.Bool(b => b
                          .Must(mu =>
                          {
                              
                             if (Language != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Language)
                                              .Field(ff => ff.Language)
                                             );
                              }

                              return mu;
                          }
                          ,
                          mu=>
                          {
                              if (Genre != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Genre)
                                              .Field(ff => ff.Genre)
                                             );
                              }
                              return mu;
                          }
                        )
                        ))
                        .Sort(ss => ss
                            .Field(f =>
                            {
                                f.Order(Nest.SortOrder.Ascending);
                                f.Field(ff => ff.Author.Suffix("raw"));
                                return f;
                            }
                            ))
                        .From(0)
                        .Size(400)
                        .Query(q => q
                        .DisMax(dm => dm.Queries
                             (b => b
                                     .Wildcard(m => m
                                         .Value(qs)
                                         .Field(ff => ff.Name)
                                     )
                                 )
                             ))

                    );


            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }

            return songs;

        }
        public static List<Song> GetLyricsByContent(String qs)
        {
            if (!MatchCase)
                qs = "*" + qs + "*";
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DefaultIndex("songs");
            var client = new ElasticClient(settings);
            var searchResponse = client.Search<Song>(s => s.PostFilter
                        (f => f.Bool(b => b
                          .Must(mu =>
                          {

                              if (Language != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Language)
                                              .Field(ff => ff.Language)
                                             );
                              }

                              return mu;
                          }
                          ,
                          mu =>
                          {
                              if (Genre != "All")
                              {
                                  mu.Term(m => m
                                              .Value(Genre)
                                              .Field(ff => ff.Genre)
                                             );
                              }
                              return mu;
                          }
                        )
                        ))
                        .Sort(ss => ss
                            .Field(f =>
                            {
                                f.Order(Nest.SortOrder.Ascending);
                                f.Field(ff => ff.Name.Suffix("raw"));
                                return f;
                            }
                            ))
                        .Sort(ss => ss
                            .Field(f =>
                            {
                                f.Order(Nest.SortOrder.Ascending);
                                f.Field(ff => ff.Author.Suffix("raw"));
                                return f;
                            }
                            ))
                        .From(0)
                        .Size(400)
                        .Query(q => q
                        .DisMax(dm => dm.Queries
                             (b => b
                                     .Wildcard(m => m
                                         .Value(qs)
                                         .Field(ff => ff.Lyrics)
                                     )
                                 )
                             ))

                    );

            var songs = new List<Song>();
            foreach (var hit in searchResponse.Hits)
            {
                songs.Add(hit.Source);
            }

            return songs;
        }
        public static List<Song> GetLyricsByNameAuthor(String name, String author)
        {
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DefaultIndex("songs");
            var elastic = new ElasticClient(settings);
          
            var searchResponse = elastic.Search<Song>(s => s
                                    .Index("songs")
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

    }
}
