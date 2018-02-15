Select strftime('%Y', InvoiceDate) as year, Count(InvoiceId) as 'Total Invoices'
FROM Invoice
WHERE year = '2009'
OR year = '2011'
GROUP BY year;