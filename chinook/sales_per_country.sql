--Provide a query that shows the total sales per country.
SELECT BillingCountry, SUM(Total)
FROM Invoice
GROUP BY BillingCountry