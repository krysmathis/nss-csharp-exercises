-- Provide a query that shows the most purchased track of 2013
-- returns the maximum number of purchases
with TopTracks as 
(
	SELECT count(t.Name) as PurchaseCount, t.Name
	FROM InvoiceLine il, Track t, Invoice i
	WHERE il.TrackId = t.TrackId
	AND il.InvoiceId = i.InvoiceId
	AND strftime('%Y',i.InvoiceDate) = '2013'
	GROUP BY t.Name
	Order by PurchaseCount DESC

)

SELECT Name, PurchaseCount from TopTracks
WHERE 
(Select Max(PurchaseCount) from TopTracks) = PurchaseCount
