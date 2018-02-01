Select Count(InvoiceId) as 'Total Invoices'
FROM Invoice
WHERE InvoiceDate BETWEEN '2009-01-01' AND '2011-12-31';