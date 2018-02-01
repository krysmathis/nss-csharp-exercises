-- Provide a query that includes the purchased track name AND artist name with each invoice line item.
SELECT t.Name, ar.Name, il.*
FROM InvoiceLine il
LEFT JOIN Track t ON t.TrackId = il.TrackId
LEFT JOIN Album al ON t.AlbumId = al.AlbumId
LEFT JOIN Artist ar ON ar.ArtistId = al.ArtistId