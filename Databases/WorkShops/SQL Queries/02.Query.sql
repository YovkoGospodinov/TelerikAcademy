INSERT INTO Cities (Name)

SELECT DISTINCT City FROM Employees WHERE City IS NOT NULL
UNION
SELECT DISTINCT City FROM Suppliers WHERE City IS NOT NULL
UNION 
SELECT DISTINCT  City FROM Customers WHERE City IS NOT NULL