-- Provide a query that includes the purchased track name with each invoice line item.
SELECT t.Name, il.*
FROM InvoiceLine il
LEFT JOIN Track t ON t.TrackId = il.TrackId;