-- Which country's customers spent the most?
SELECT BillingCountry, MAX(Total) FROM (
SELECT BillingCountry, SUM(Total) as 'Total'
FROM Invoice
GROUP BY BillingCountry);