UPDATE  Cities
SET CountryId = Countries.Id
	FROM Countries
	JOIN Employees
	ON Employees.Country = Countries.Name
	WHERE Cities.Name = Employees.City

UPDATE Cities
SET CountryId = Countries.Id
	FROM Countries
	JOIN Customers
	ON Customers.Country = Countries.Name
	WHERE Cities.Name = Customers.City

UPDATE Cities
SET CountryId = Countries.Id
	FROM Countries
	JOIN Suppliers
	ON Suppliers.Country = Countries.Name
	WHERE Cities.Name = Suppliers.City