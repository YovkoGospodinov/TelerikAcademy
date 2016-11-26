USE Computers
GO
CREATE PROCEDURE dbo.GetComputersWithGpuAndRamBetween @GPU FLOAT = 1.0, @MinRAM INT = 0, @MaxRAM INT = 32
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
	 JOIN ComputersGPUs AS cg
	 ON c.Id = cg.ComputerId
	 JOIN GPUs AS g
	 ON g.Id = cg.GPUId
	 WHERE g.Memory = @GPU,
	 WHERE c.Memory >= @MinRAM AND c.Memory <= @MaxRAM
END
GO


EXEC dbo.GetComputersWithGpuAndRamBetween @MinRAM = 8, @MaxRAM = 16
GO