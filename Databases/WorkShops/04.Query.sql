UPDATE Employees
SET CityId = c.Id
    FROM Cities AS c
	JOIN Employees AS e
	ON c.Name = e.City

UPDATE Suppliers
SET CityId = c.Id
    FROM Cities AS c
	JOIN Suppliers AS s
	ON c.Name = s.City

UPDATE Customers 
SET CityId = c.Id
    FROM Cities AS c
	JOIN Customers AS cust
	ON c.Name = cust.City


	