-- count of products
SELECT p.ProductName, Count(od.OrderId) as Orders FROM `Order` o, OrderDetail od, Product p
WHERE o.Id = od.OrderId
AND od.ProductId = p.Id
AND o.ShippedDate is not null
GROUP BY p.ProductName;

-- list of months without orders
-- months
WITH RECURSIVE
  Month(m) AS (
     SELECT 1
     UNION ALL
     SELECT m+1 FROM Month
      LIMIT 12
  ),
  -- orders by month
MonthlyOrders as (
	SELECT strftime('%m', OrderDate)*1 as OrderMonth, count(*) as NumberOfOrders from `Order`
	WHERE OrderDate Between '2014-01-01' AND '2014-10-31'
	GROUP BY OrderMonth
  )
SELECT m.m as Month, NumberOfOrders FROM Month m
LEFT JOIN MonthlyOrders mo ON m.m = mo.OrderMonth
GROUP BY m.m;

-- top 3 items
SELECT p.ProductName, Count(od.OrderId) as Orders FROM `Order` o, OrderDetail od, Product p
WHERE o.Id = od.OrderId
AND od.ProductId = p.Id
AND o.ShippedDate is not null
GROUP BY p.ProductName
ORDER BY Orders desc
LIMIT 3

-- missing months for product = chai
-- list of months without orders
-- months
WITH RECURSIVE
  Month(m) AS (
     SELECT 1
     UNION ALL
     SELECT m+1 FROM Month
      LIMIT 12
  ),
  -- orders by month
MonthlyOrders as (
	SELECT strftime('%m', OrderDate)*1 as OrderMonth, count(*) as NumberOfOrders 
	FROM `Order` o, OrderDetail od, Product p
	WHERE OrderDate Between '2014-01-01' AND '2014-10-31'
	AND o.Id = od.OrderId
	AND od.ProductId = p.Id
	AND p.ProductName = "Chai"
	GROUP BY OrderMonth
  )
SELECT m.m as Month, NumberOfOrders FROM Month m
LEFT JOIN MonthlyOrders mo ON m.m = mo.OrderMonth
GROUP BY m.m;

-- list of employees who processed orders with chai
SELECT e.FirstName || " " || e.LastName as `Name`
FROM
	(SELECT o.EmployeeId
	FROM `Order` o, OrderDetail od, Product p
	WHERE o.Id = od.OrderId
	AND od.ProductId = p.Id
	AND p.ProductName = "Chai"
	GROUP BY o.EmployeeId) prod,
	Employee e
WHERE e.Id = prod.EmployeeId

-- Employees who order in the month of march
SELECT e.FirstName || " " || e.LastName as `Name`, Count(*) as OrderCount
FROM `Order` o, Employee e
WHERE o.EmployeeId = e.Id
AND strftime('%m', OrderDate) = '03'
GROUP BY `Name`

-- Get the list of employees who processed the orders that belong to the city in which they live
SELECT DISTINCT e.FirstName || " " || e.LastName as `Name`, e.City, e.Country
FROM `Order` o, Employee e
WHERE o.EmployeeId = e.Id
AND o.ShipCity = e.City
AND o.ShipCountry = e.Country;

--Get the list of employees who processed the orders that don’t belong to the city in which they live
SELECT DISTINCT e.FirstName || " " || e.LastName as `Name` FROM 
(
SELECT o.Id
FROM `Order` o
LEFT JOIN Employee e ON o.EmployeeId = e.Id 
AND o.ShipCity = e.City
AND o.ShipCountry = e.Country
WHERE e.City is Null
) missing,
Employee e,
`Order` o
WHERE missing.Id = o.Id
AND o.EmployeeId = e.Id