SELECT FirstName || " " || LastName as 'Name', CustomerId, Country 
FROM CUSTOMER 
WHERE Country != 'USA';