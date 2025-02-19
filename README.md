# LyricsMatch
Demo .NET Forms application for searching and commenting on song lyrics

## System architecture

This system was developed in three different versions to compare the performance of corresponding Elasticsearch versions and the data structures they rely on. The following description will focus on the newest version.
The LyricsMatch system, which this application is a part of, consists of the following components:

• Data source – document lyrics-data.csv downloaded from the Kaggle website which includes 17063 song lyrics, in English, Spanish, Basque language and instrumentals, 
processed to include the year of publication and the coordinates of the top left, bottom right and center point of the place from which the song originated;
• Logstash – a pipeline that downloads data from lyrics-data.csv and loads them with the desired transformations into the lyrics_data index;
• Text database – Elasticsearch index, created via the Logstash pipeline;
• Database – MySQL database that has the role of storing data about users, song lyrics, comments, search history and their mutual connections;
• Lyricsmatch client application – .NET application using MySQL database and Elasticsearch index;
• Kibana – software that is part of the Elastic Stack and is an interface for visualization and analysis of the Elasticsearch cluster;
• Metricbeat – software for downloading system and cluster metrics and displaying them in Kibana.

![image](https://github.com/user-attachments/assets/c1b81c6a-c397-4fd2-8ce3-e1c1f3362d6b)

**Data source**

The lyrics-data.csv document was chosen as the data source, which after removing unreadable items and inserting the coordinates of the song publication locations, includes 17063 song texts, in English, Spanish, Basque and instrumentals, in ten different genres.
The song table contains columns Author, Name, Lyrics, Language, x_NW, y_NW, x_SE, y_SE, x_center, y_center, Genre, and Year (author, name, lyrics, language, coordinates of the top left, bottom right, and center points of the place of publication, genre, 
and year of publication). The document named lyrics-data-additional.csv (with 1664 items) has additional data, made from a part of the first file's data, with the changed names of the authors and the new genre of all songs, Groove.

**Indexing**

Indexing is done by creating a Logstash pipeline based on lyrics-data.csv. Fields whose type should be highlighted are Year - whole number, i.e. integer and x_nw, y_nw, x_se, y_se, x_center and y_center as decimal, specifically float and geo_shape and geo_point structures. 

**Database**

Entities related to the application are placed in a MySQL database - song, continent, user, user_song, history, and comment. The User class models the application user, who can have several favorite songs, and one song can be in the favorite list of several different users 
(which is represented by a special user_song table). The history table represents the user's search history, and the comment represents the comments of different users of different songs. 

![image](https://github.com/user-attachments/assets/53364069-5af4-4564-b5d2-9664f2e3db3d)

**Lyricsmatch client application**

The LyricsMatch application should allow users to sign up and sign in, view the most popular genres and lyrics, comment and add lyrics to favorites. Most importantly, the application provides a search by term that includes a selection of a search filter for the whole 
(match case) or part of the term, then each of the text fields (Name, Author, Lyrics, etc.), the place of publication and the range of years of publication. Filtering by language and genre is also available.
The DataProviders folder contains the DataProvider and ElasticDataProvider classes, containing the necessary database query functions.

To work with MySQL database entities, a data model is needed - classes corresponding to the database tables (Song, User, Comment). The LyricsMatch application implements four types of SQL queries - SELECT, INSERT, DELETE and UPDATE - within the static DataProvider class. 

To connect the application to the Elasticsearch database, NEST is used, a high-level .NET client that provides a query DSL language for searching the Elasticsearch index. 
The Song class models the lyrics of a song and has a mapping of each attribute. 

The GetLyricsByNameAuthorLyrics function, central to the search logic, returns the most relevant documents based on user input and selected filters. If the user chooses that the entered word must be identical to the one from the result, no wildcard characters (*) are added to the entered search text. 
The PostFilter part of the search is performed after the documents are obtained by the rest of the function code, and within its Bool function, filtering by location is performed. Also, a Must structure is defined, where each of the fields Author, Name and Lyrics should contain the entered text, 
and Language and Genre should match the selected one (if the user has not selected a specific language or genre, the search is by all values, i.e. by the value of the Language or Genre variables, equal to the character *). 
The From function defines the first sub-result in the return value, and the maximum number of results is defined through the Size function. After the Size function, the Query part is defined, and executed before the described PostFilter part. 
Query includes a Range query, over a range of numbers. It is performed over the Year field, between the two entered years. 
Finally, the hits are placed in a list of songs.

![image](https://github.com/user-attachments/assets/8bec313b-a947-46f7-8d3f-f3d2f699088d)
