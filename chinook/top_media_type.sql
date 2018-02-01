-- Provide a query that shows the most purchased Media Type.
SELECT Name, MAX(Purchases) FROM
(
SELECT m.Name, Sum(quantity) as Purchases
FROM InvoiceLine il 
LEFT JOIN Track t ON il.TrackId = t.TrackId
LEFT JOIN MediaType m ON t.MediaTypeId = m.MediaTypeId
GROUP BY m.Name
);