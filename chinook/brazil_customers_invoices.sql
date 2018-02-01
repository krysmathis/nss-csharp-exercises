--Provide a query showing the Invoices of customers who are from Brazil. The resultant table should show the customer's full name, Invoice ID, Date of the invoice and billing country.
SELECT c.FirstName || " " || c.LastName as CustomerName, i.InvoiceId, i.InvoiceDate, i.BillingCountry
FROM Invoice i
INNER JOIN Customer c on i.CustomerId = c.CustomerId
Where c. Country = 'Brazil';