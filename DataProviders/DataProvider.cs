using LyricsMatch.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LyricsMatch
{
    public static class DataProvider
    {
        public static List<string> Genres { get; set; } = new List<string> { "Pop", "Rock", "Metal", "Blues", "Country", "Hip Hop", "Punk", "Dance", "Trap", "R'n'B" };
        public static List<string> Languages { get; set; } = new List<string> { "English", "Spanish", "Basque", "Na" };
        public static List<string> Locations { get; set; } = new List<string> { "London", "New York", "Los Angeles", "Chicago", "Berlin", "Paris", "Belgrade" };
        public static List<int> YearsFrom { get; set; } = new List<int>(Enumerable.Range(1960, 2016));
        public static List<int> YearsTo { get; set; } = new List<int>(Enumerable.Range(1960, 2016));

        static string connstring = @"server=localhost;userid=root;password=root;database=lyricsmatch";

        public static bool CheckUsername(String username)
        {
            bool res = false;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM user WHERE username=\"" + username + "\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                res = rd.HasRows;
                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return res;
        }
        public static User AddUser(User user)
        {
            User addedUser = user;
            

            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "INSERT INTO user (username,first_name,last_name,password,picture)"
                                                       + " VALUES (\"" + addedUser.Username
                                                       + "\",\"" + addedUser.FirstName + "\",\"" + addedUser.LastName + "\",\"" + addedUser.Password + "\",\"" + addedUser.Picture + "\")";
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();

                addedUser.Id = GetUserId(addedUser.Username);

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return addedUser;

        }
        public static int GetUserId(String username)
        {
            User loggedUser = null;
            

            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM user WHERE username=\"" + username + "\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    loggedUser = new User();

                    while (rd.Read())
                        loggedUser.Id = rd.GetInt32(0);

                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return loggedUser.Id;

        }
        public static User GetUser(string username)
        {
            User loggedUser = null;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM user WHERE username=\"" + username + "\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    loggedUser = new User();

                    while (rd.Read())
                    {
                        loggedUser.Id = rd.GetInt32(0);
                        loggedUser.Username = rd.GetString(1);
                        loggedUser.FirstName = rd.GetString(2);
                        loggedUser.LastName = rd.GetString(3);
                        loggedUser.Password = rd.GetString(4);
                        loggedUser.Picture = rd.GetString(5);

                    }
                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return loggedUser;
        }
        public static User GetUser(String username, String pass)
        {
            User loggedUser = null;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM user WHERE username=\"" + username + "\" AND password=\"" + pass + "\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    loggedUser = new User();

                    while (rd.Read())
                    {
                        loggedUser.Id = rd.GetInt32(0);
                        loggedUser.Username = rd.GetString(1);
                        loggedUser.FirstName = rd.GetString(2);
                        loggedUser.LastName = rd.GetString(3);
                        loggedUser.Password = rd.GetString(4);
                        loggedUser.Picture = rd.GetString(5);

                    }
                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return loggedUser;

        }
        public static void UpdateUser(User user)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                user.Picture = user.Picture.Replace("\\", "\\\\");

                cmd.CommandText = "UPDATE user SET username=\""+user.Username+"\", first_name=\""+user.FirstName+"\", last_name=\"" 
                                            + user.LastName + "\", password=\"" + user.Password
                                            + "\", picture=\"" + user.Picture+"\" WHERE id =" + user.Id;
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public static void AddToUserHistory(User loggedUser, string text)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

           try
           {
               MySqlCommand cmd = new MySqlCommand();

               cmd.CommandText = "INSERT INTO history (user_id,text) VALUES (" + loggedUser.Id + ",\"" + text + "\")";
               cmd.Connection = conn;
               conn.Open();

               MySqlDataReader rd = cmd.ExecuteReader();
               rd.Close();

           }
           catch (Exception ex)
           {
               conn = null;
           }
           finally
           {
               if (conn != null)
               {
                   conn.Close();
               }
           }
               
        }
        public static List<String> GetUserHistory(User loggedUser)
        {
            List<String> historyList=null;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT text FROM history WHERE user_id=" + loggedUser.Id + "";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    historyList = new List<String>();

                    while (rd.Read())
                        historyList.Add(rd["text"].ToString());
                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return historyList;
        }
        public static List<String> DeleteHistoryItem(User loggedUser,String text)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "DELETE FROM history WHERE user_id = " + loggedUser.Id + " AND text = \"" + text + "\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            List<String> historyList = GetUserHistory(loggedUser);
            return historyList;
        }
        public static List<String> DeleteHistory(User loggedUser)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "DELETE FROM history WHERE user_id=" + loggedUser.Id;
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            List<String> historyList = GetUserHistory(loggedUser);
            return historyList;
        }
        public static List<Song> GetUserSongs(User loggedUser)
        {
            
          List<Song> songList = null;
          MySqlConnection conn = new MySqlConnection(connstring);

          try
          {
              conn.Open();
              MySqlCommand cmd = new MySqlCommand();

              songList = new List<Song>();

              cmd.CommandText = "SELECT s.* FROM song AS s INNER JOIN user_song AS tr " +
                                              "ON s.id = tr.song_id AND tr.user_id=" + loggedUser.Id;
    
              cmd.Connection = conn;
              MySqlDataReader rd = cmd.ExecuteReader();
              if (rd.HasRows)
              {
                  while (rd.Read())
                  {
                      Song song = new Song();

                      song.Id = Int32.Parse(rd["id"].ToString());
                      song.Name = rd["name"].ToString();
                      song.Author = rd["author"].ToString();
                      song.Language = rd["language"].ToString();
                      song.Genre = rd["genre"].ToString();
                      song.Views = Int32.Parse(rd["views"].ToString());
                      song.Lyrics = ElasticDataProvider.GetLyricsByNameAuthorDB(song.Name, song.Author)[0].Lyrics;
                      songList.Add(song);
                  }
             
              }

              rd.Close();
          }
          catch (Exception ex)
          {
              conn = null;
          }
          finally
          {
              if (conn != null)
              {
                  conn.Close();
              }
          }
          return songList;
           
        }
        public static List<Song> DeleteUserSong(User loggedUser, Song song)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "DELETE FROM user_song WHERE user_id=" + loggedUser.Id + " AND song_id="+song.Id;
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            List<Song> userSongs = GetUserSongs(loggedUser);
            return userSongs;
        }
        public static void AddUserSong(User loggedUser,Song song)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "INSERT INTO user_song (user_id,song_id) VALUES (" + loggedUser.Id
                            + "," + song.Id +")";
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();

                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public static int AddSongIfNotExists(Song song)
        {
            if (DataProvider.SongExistsMySQL(song.Name, song.Author)==0)
            {
                MySqlConnection conn = new MySqlConnection(connstring);

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "INSERT INTO song (name,author,language,genre,views) VALUES (\"" + song.Name
                                + "\",\"" + song.Author + "\",\"" + song.Language+ "\",\"" +song.Genre +"\", 1)";
                    cmd.Connection = conn;
                    conn.Open();

                    MySqlDataReader rdd = cmd.ExecuteReader();
                    rdd.Close();
                }
                catch (Exception ex)
                {
                    conn = null;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
               
            }
            return SongExistsMySQL(song.Name, song.Author);
            
        }
        public static int SongExistsMySQL(string name, string author)
        {
            int id = 0;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM song WHERE name=\"" + name + "\" AND author=\""+author+"\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while(rd.Read())
                        id = rd.GetInt32(0);

                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return id;
        }
        public static List<Song> InsertIdsAndViewsToSongs(List<Song> songs)
        {
            foreach (Song song in songs)
            {
                MySqlConnection conn = new MySqlConnection(connstring);

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT * FROM song WHERE name=\"" + song.Name + "\" AND author=\"" + song.Author + "\"";

                    cmd.Connection = conn;
                    conn.Open();
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            song.Id = Int32.Parse(rd["id"].ToString());
                            song.Views = Int32.Parse(rd["views"].ToString());
                        }
                    }
                    rd.Close();
                }
                catch (Exception ex)
                {
                    conn = null;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            return songs;
        }
        public static List<Comment> GetSongComments(Song song)
        {
            List<Comment> songComments = new List<Comment>();
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "SELECT * FROM comment WHERE song_idd=" + song.Id + "";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {

                    while (rd.Read())
                    {

                        Comment comm = new Comment();

                        comm.Id = Int32.Parse(rd["id"].ToString());
                        comm.Text = rd["text"].ToString();
                        comm.Song_id=Int32.Parse(rd["song_idd"].ToString());
                        comm.User_idd= Int32.Parse(rd["user_idd"].ToString());
                        songComments.Add(comm);


                    }

                }

                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return songComments;
        }
        public static List<String> GetSongCommentsAsStrings(Song song)
        {
            List<Comment> comms = GetSongComments(song);
            List<String> commStrings = null;
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                commStrings = new List<String>();

                foreach (Comment comment in comms)
                {
                    cmd.CommandText = "SELECT username FROM user WHERE id=" + comment.User_idd + "";
                    cmd.Connection = conn;
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {

                        while (rd.Read())
                            commStrings.Add(rd["username"].ToString()+": "+comment.Text);
                            
                    }

                    rd.Close();
                }
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return commStrings;
        }
        public static List<String> DeleteComment(User loggedUser, string commentText,Song song)
        {
            List<Comment> songComments = new List<Comment>();
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "DELETE FROM comment WHERE song_idd=" + song.Id + " AND user_idd="+loggedUser.Id+" AND text=\""+commentText+"\"";
                cmd.Connection = conn;
                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();
            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return GetSongCommentsAsStrings(song);
        }
        public static void AddComment(Song song, User user,String text)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "INSERT INTO comment (text,song_idd,user_idd) VALUES (\"" + text + "\"," + song.Id +"," + user.Id+")";
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public static void UpdateSongViews(Song song)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "UPDATE song SET views = " + (song.Views + 1) + " WHERE id =" + song.Id;
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public static List<Song> GetPopularSongs()
        {
            List<Song> songs=new List<Song>();
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT * FROM (SELECT * FROM song WHERE views > 3 ORDER BY views limit 10) AS r ORDER BY r.views DESC";
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Song song = new Song();
                        song.Id = Int32.Parse(rd["id"].ToString());
                        song.Name = rd["name"].ToString();
                        song.Author = rd["author"].ToString();
                        song.Language = rd["language"].ToString();
                        song.Genre = rd["genre"].ToString();
                        song.Views = Int32.Parse(rd["views"].ToString());
                        songs.Add(song);

                    }

                }
                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return songs;
           
        }
        public static Dictionary<string, int> GetSongViewsByCategory(Dictionary<string,int> viewsByCategory,bool byLanguage)
        {
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = "SELECT * FROM song";
                cmd.Connection = conn;
                conn.Open();

                MySqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    if (byLanguage == true)
                    {
                        while (rd.Read())
                            viewsByCategory[rd["language"].ToString()] += Int32.Parse(rd["views"].ToString());
                    }
                    else
                    {
                        while (rd.Read())
                            viewsByCategory[rd["genre"].ToString()] += Int32.Parse(rd["views"].ToString());
                    }
                }

                rd.Close();

            }
            catch (Exception ex)
            {
                conn = null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return viewsByCategory;

        }

    }
}
