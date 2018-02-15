Select strftime('%Y', InvoiceDate) as year, SUM(total) as Total
FROM Invoice
WHERE year = "2011"
or year = "2009"
GROUP BY strftime('%Y', InvoiceDate);