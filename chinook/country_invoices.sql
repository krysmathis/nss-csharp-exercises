-- Provide a query that shows the # of invoices per country. HINT: GROUP BY
SELECT BillingCountry, count(*) as Invoices 
FROM Invoice
GROUP BY BillingCountry

