-- Provide a query that shows the top 3 best selling artists.
SELECT * FROM
(
SELECT a.Name, Sum(quantity) as Purchases
FROM InvoiceLine il 
LEFT JOIN Track t ON il.TrackId = t.TrackId
LEFT JOIN Album al ON t.AlbumId = al.AlbumId
LEFT JOIN Artist a ON al.ArtistId = a.ArtistId
GROUP BY a.Name
) 
ORDER BY Purchases DESC 
LIMIT 3;