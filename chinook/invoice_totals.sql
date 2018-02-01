--Provide a query that shows the Invoice Total, Customer name, Country and Sale Agent name for all invoices and customers
SELECT SUM(i.Total) as InvoiceTotal, c.FirstName || " " || c.LastName as 'CustomerName', c.Country, e.FirstName || " " || e.LastName as 'SalesAgentName'
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
GROUP BY c.FirstName || " " || c.LastName, c.Country, e.FirstName || " " || e.LastName
ORDER BY e.LastName, e.FirstName;
