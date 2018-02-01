--Which sales agent made the most in sales over all?
SELECT Name, Max(Total) as Total
FROM (
SELECT e.FirstName || " " || e.LastName as "Name",  Sum(i.Total) as 'Total'
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
GROUP BY e.LastName, e.FirstName
);