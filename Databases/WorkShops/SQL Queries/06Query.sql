INSERT INTO Cities (Name)
SELECT DISTINCT o.ShipCity
 FROM Cities AS c
 RIGHT JOIN Orders AS o
 ON o.ShipCity = c.Name
 WHERE c.Name IS NULL
 
 
 
INSERT INTO Cities (Name)
SELECT DISTINCT o.ShipCity
FROM Orders o
WHERE NOT EXISTS (SELECT * 
                  FROM Cities c
                  WHERE c.Name = o.ShipCity)

