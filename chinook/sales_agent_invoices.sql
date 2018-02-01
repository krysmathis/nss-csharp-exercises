SELECT e.FirstName || " " || e.LastName as "Name",  i.* 
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
ORDER BY e.LastName, e.FirstName