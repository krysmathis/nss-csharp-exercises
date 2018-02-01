SELECT e.FirstName || " " || e.LastName as "Name",  Sum(i.Total) as `Total`
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
GROUP BY e.LastName, e.FirstName
