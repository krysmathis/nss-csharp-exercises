-- Provide a query that shows the count of customers assigned to each sales agent.
SELECT SalesAgentName, Count(CustomerId) as 'CustomerCount' FROM (
SELECT e.FirstName || " " || e.LastName as 'SalesAgentName', c.CustomerId
FROM Invoice i
LEFT JOIN Customer  c ON i.CustomerId = c.CustomerId
LEFT JOIN Employee e ON c.SupportRepId = e.EmployeeId
GROUP BY e.FirstName || " " || e.LastName, c.CustomerId)
GROUP BY SalesAgentName;