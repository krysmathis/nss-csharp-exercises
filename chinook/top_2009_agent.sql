--Which sales agent made the most in sales in 2009?
SELECT Sales.Name, Max(Sales.Total) "Sales"
FROM (
SELECT e.FirstName || " " || e.LastName as "Name",  Sum(i.Total) as `Total`, strftime('%Y',i.InvoiceDate) as Year
FROM Invoice i, Customer c, Employee e
WHERE i.CustomerId = c.CustomerId
AND c.SupportRepId = e.EmployeeId
AND Year = "2009"
GROUP BY "Name"
) Sales;