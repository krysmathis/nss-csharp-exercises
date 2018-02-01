-- Provide a query that shows the total number of tracks in each playlist. The Playlist name should be include on the resulant table.
SELECT p.Name, Count(pt.TrackId) as Tracks
FROM PlaylistTrack pt
LEFT JOIN Playlist p ON pt.PlaylistId = p.PlaylistId
GROUP BY p.Name;