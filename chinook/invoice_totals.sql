--Provide a query that shows the Invoice Total, Customer name, Country and Sale Agent name for all invoices and customers
SELECT i.Total as InvoiceTotal, c.FirstName || " " || c.LastName as 'CustomerName', c.Country, e.FirstName || " " || e.LastName as 'SalesAgentName'
FROM Invoice i, Customer c, Employee e
WHERE i.CustomerId = c.CustomerId
AND c.SupportRepId = e.EmployeeId
ORDER BY SalesAgentName, i.BillingCountry, i.Total desc;
