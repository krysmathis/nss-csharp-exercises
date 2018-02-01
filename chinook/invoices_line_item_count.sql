--invoices_line_item_count.sql: Provide a query that shows all Invoices but includes the # of invoice line items.
SELECT 
	i.InvoiceId,
	i.CustomerId,
	i.InvoiceDate,
	i.BillingAddress,
	i.BillingCity,
	i.BillingState,
	i.BillingCountry,
	i.BillingPostalCode,
	i.Total,
	Count(il.Invoiceid) as 'OrderLines'
FROM Invoice i
LEFT JOIN InvoiceLine il ON i.InvoiceId = il.InvoiceId
GROUP BY 	i.InvoiceId,
	i.CustomerId,
	i.InvoiceDate,
	i.BillingAddress,
	i.BillingCity,
	i.BillingState,
	i.BillingCountry,
	i.BillingPostalCode,
	i.Total
ORDER BY i.InvoiceId;