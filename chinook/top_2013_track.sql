-- Provide a query that shows the most purchased track of 2013
SELECT Name, Max(Purchases) FROM 
(
SELECT t.Name, Sum(quantity) as Purchases
FROM InvoiceLine il 
LEFT JOIN Track t ON il.TrackId = t.TrackId
LEFT JOIN Invoice i ON il.InvoiceId = i.InvoiceId
WHERE  i.InvoiceDate BETWEEN '2013-01-01' AND '2013-12-31'
GROUP BY t.Name
);