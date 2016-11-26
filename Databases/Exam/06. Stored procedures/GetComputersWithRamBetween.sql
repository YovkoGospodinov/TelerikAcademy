USE Computers
GO
CREATE PROCEDURE dbo.usp_GetComputersWithRamBetween @MinRAM INT = 0, @MaxRAM INT = 32
AS
BEGIN
	SELECT c.Id,
		 v.Name AS Vendor,
		 m.Name AS Model
	 FROM Computers AS c
	 JOIN Vendors AS v
	 ON c.VendorId = v.Id
	 JOIN Models AS m
	 ON c.ModelId = m.Id
	 WHERE c.Memory >= @MinRAM AND c.Memory <= @MaxRAM
END
GO


EXEC dbo.usp_GetComputersWithRamBetween @MinRAM = 8, @MaxRAM = 16
GO