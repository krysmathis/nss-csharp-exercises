-- Provide a query that shows the top 5 most purchased songs.
SELECT t.Name, Sum(quantity) Purchases
FROM InvoiceLine il 
LEFT JOIN Track t ON il.TrackId = t.TrackId
GROUP BY t.Name
ORDER BY Purchases DESC 
LIMIT 5;