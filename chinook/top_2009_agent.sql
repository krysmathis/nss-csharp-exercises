--Which sales agent made the most in sales in 2009?
SELECT Name, Max(Total) 
FROM (
SELECT e.FirstName || " " || e.LastName as "Name",  Sum(i.Total) as `Total`
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
WHERE i.InvoiceDate BETWEEN '2009-01-01' AND '2009-12-31'
GROUP BY e.LastName, e.FirstName
);
