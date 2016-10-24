UPDATE Orders
SET ShipCityId = c.Id
		FROM Cities AS c
		WHERE Orders.ShipCity = c.Name
	