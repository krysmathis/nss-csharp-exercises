Select strftime('%Y', InvoiceDate) as year, SUM(total) as Total
FROM Invoice
WHERE InvoiceDate BETWEEN '2009-01-01' AND '2011-12-31'
GROUP BY strftime('%Y', InvoiceDate);