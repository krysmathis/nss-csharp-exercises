/* Query all entries in the Genre table */
SELECT * FROM Genre;

/* Using the INSERT statement, add one of your favorite artists to the Artist table. */
INSERT INTO Artist (ArtistId, ArtistName, YearEstablished)
VALUES (null, 'Tony Rice', 1970);

/* Using the INSERT statement, add one, or more, albums by your artist to the Album table. */
INSERT INTO Album (AlbumId, Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId)
VALUES (null, 'Native American', '2/14/1992', 2548, 'Rounder', 28, 8);

/* Using the INSERT statement, add some songs that are on that album to the Song table. */
INSERT INTO Song (SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES (null,'Shadows', 223, '2/14/1992', 8, 28, 24);

INSERT INTO Song (SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES (null,'St. James Hospital', 299, '2/14/1992', 8, 28, 24);

INSERT INTO Song (SongId, Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId)
VALUES (null,'Night Flyer', 240, '2/14/1992', 8, 28, 24);

/* Write a SELECT query that provides the song titles, album title, and artist name for all of the data you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, and the WHERE keyword to filter the results to the album and artist you added. */
SELECT 
s.Title as SONG_TITLE, 
a.Title as ALBUM_TITLE ,
ar.ArtistName as ARTIST_NAME
FROM 
Song s
LEFT JOIN Album a ON
s.AlbumId = a.AlbumId
LEFT JOIN Artist ar ON
s.ArtistId = ar.ArtistId
WHERE s.ArtistId = 28;

/* Write a SELECT statement to display how many songs exist for each album. You'll need to use the COUNT() function and the GROUP BY keyword sequence. */
SELECT a.Title as ALBUM_TITLE, Count(*)
FROM Song s
LEFT JOIN Album a ON
s.AlbumId = a.AlbumId
Group by a.Title

/* Write a SELECT statement to display how many songs exist for each artist. You'll need to use the COUNT() function and the GROUP BY keyword sequence. */
SELECT ar.ArtistName, count(*) as SONG_COUNT
FROM SONG s
LEFT JOIN Artist ar ON
s.ArtistId = ar.ArtistId
GROUP BY ar.ArtistName;

/* Write a SELECT statement to display how many songs exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence. */
SELECT g.Label as GENRE, Count(*) as SONG_COUNT
FROM Song s
LEFT JOIN Genre g ON
s.GenreId = g.GenreId
Group by g.Label;

/* Using MAX() function, write a select statement to find the album with the longest duration. The result should display the album title and the duration. */
SELECT Title, MAX(AlbumLength) as Duration
FROM Album

/* Using MAX() function, write a select statement to find the song with the longest duration. The result should display the song title and the duration. */
SELECT s.Title, Max(SongLength) as Duration
FROM Song s


/* Modify the previous query to also display the title of the album. */
SELECT s.Title, a.Title, Max(SongLength) as Duration
FROM Song s
LEFT JOIN Album a ON 
s.AlbumId = a.AlbumId



