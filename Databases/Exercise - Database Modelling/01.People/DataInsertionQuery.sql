INSERT INTO [dbo].[Continent] (Name)
 VALUES
  ('Europe'),
  ('Asia'),
  ('North America')

INSERT INTO [dbo].[Country] (Name, ContinentId)
 VALUES
  ('Bulgaria', 1),
  ('Japan', 2),
  ('USA', 3)

INSERT INTO [dbo].[Town] (Name, CountryId)
 VALUES
  ('Sofia', 1),
  ('Koyasu', 2),
  ('Merritt Island', 3)

INSERT INTO [dbo].[Address] (AddressText, TownId)
 VALUES
  ('blv. Vitosha 12', 1),
  ('Isehara-shi', 2),
  ('1950 Monticello Avenue', 3)

INSERT INTO [dbo].[Person] (FirstName, LastName, AddressId)
 VALUES
  ('Ivan', 'Ivanov', 1),
  ('Cho', 'Diaki', 2),
  ('Jim', 'Wailey', 3)