--Entering ColorName to see all cars with that ColorName
GO
CREATE FUNCTION CarsColor(@Color VARCHAR(50))
RETURNS TABLE
AS
RETURN
SELECT
	man.[Name] AS Manufacturer,
	mdl.[Name] AS Model,
	cty.[Name] AS [ChassisType],
	cnt.[Name] AS CountryOfProduction,
	YEAR(vcl.[Year]) AS YearOfProduction,
	vcl.[Milage],
	vcl.[Fuel] AS FuelType	
FROM 
	dbo.Vehicle AS vcl 
	INNER JOIN dbo.Manufacturer AS man ON vcl.ManufacturerID = man.ManufacturerID
	INNER JOIN dbo.Country AS cnt ON man.CountryID = cnt.CountryID
	INNER JOIN dbo.Model AS mdl ON vcl.ModelID = mdl.ModelID
	INNER JOIN dbo.Car_Type AS cty ON vcl.TypeID = cty.TypeID
	INNER JOIN dbo.Color AS clr ON vcl.ColorID = clr.ColorID
WHERE 	C.[Name] = @Color

SELECT * FROM [dbo].[CarsColor]('Brink pink')


--- Filter cars FROM min to max milage.
CREATE OR ALTER FUNCTION MilageFilter(@MilageMin INT, @MilageMax INT)
RETURNS TABLE
AS
RETURN
SELECT
	man.[Name] AS Manufacturer,
	mdl.[Name] AS Model,
	cty.[Name] AS [ChassisType],
	cnt.[Name] AS CountryOfProduction,
	YEAR(vcl.[Year]) AS YearOfProduction,
	vcl.[Milage],
	vcl.[Fuel] AS FuelType,
	clr.[Name] AS ColorName	
FROM 
	dbo.Vehicle AS vcl 
	INNER JOIN dbo.Manufacturer AS man ON vcl.ManufacturerID = man.ManufacturerID
	INNER JOIN dbo.Country AS cnt ON man.CountryID = cnt.CountryID
	INNER JOIN dbo.Model AS mdl ON vcl.ModelID = mdl.ModelID
	INNER JOIN dbo.Car_Type AS cty ON vcl.TypeID = cty.TypeID
	INNER JOIN dbo.Color AS clr ON vcl.ColorID = clr.ColorID
WHERE vcl.Milage >= @MilageMin AND vcl.Milage <= @MilageMax;

SELECT * FROM [dbo].MilageFilter(0, 1000)


--- Find the HexCode of the given ColorName
CREATE OR ALTER FUNCTION ColorNameToHexCode(@ColorName VARCHAR(50))
    RETURNS VARCHAR(50)
    BEGIN
		DECLARE @ret VARCHAR(50);
		SET @ret = (SELECT HexCode
					FROM Color
					WHERE [Name] = @ColorName)
		RETURN @ret;
	END

SELECT [dbo].ColorNameToHexCode('Wine')


 --- Input is the CountryName and output is the number of cars of that country in the inventory
CREATE OR ALTER FUNCTION MadeCars(@CountryName VARCHAR(50))
    RETURNS VARCHAR(50)
    BEGIN
        DECLARE @Status VARCHAR(50);
		DECLARE @Amount INT;
        IF(@CountryName in (SELECT cnt.[Name]
							FROM [Transaction] AS trn
							INNER JOIN vehicle AS vcl ON trn.VIN = vcl.VIN
							INNER JOIN manufacturer AS man ON vcl.ManufacturerID = man.ManufacturerID
							INNER JOIN dbo.Country AS cnt ON man.CountryID = cnt.CountryID))
			BEGIN
			SET @Amount=(SELECT COUNT(cnt.[Name])
						FROM [Transaction] AS trn
						INNER JOIN vehicle AS vcl ON trn.VIN = vcl.VIN
						INNER JOIN manufacturer AS man ON vcl.ManufacturerID = man.ManufacturerID
						INNER JOIN dbo.Country AS cnt ON man.CountryID = cnt.CountryID
						WHERE cnt.[Name] = @CountryName
						GROUP BY cnt.[Name]) 
            SET @Status = 'Number of '	+ @CountryName + ' made cars: ' + Cast(@Amount AS varchar(20))	
			END
        
        ELSE SET @Status = 'No car in the inventory from '	 + @CountryName
        RETURN @Status
    END

SELECT [dbo].[MadeCars]('Ukraine')


--- Get CountryName and returns the complete list of transactions in that country Banks
CREATE FUNCTION [dbo].[CountrySalesDetail](@CountryName varchar(50)) 
RETURNS TABLE
AS
RETURN
SELECT
	CONCAT(per.FirstName, ' ', per.LastName) AS CustomerFullName,
	per.NationalCode,
	trn.VIN,
	man.[Name] AS Manufacturer,
	mdl.[Name] AS Model,
	cty.[Name] AS [ChassisType],
	YEAR(vcl.[Year]) AS YearOfProduction,
	vcl.[Milage],
	vcl.[Fuel] AS FuelType,
	trn.[Date] AS DateOfTransaction,
	trn.Price,
	trn.Currency
FROM dbo.[Transaction] AS trn
	INNER JOIN dbo.Vehicle AS vcl ON trn.VIN = vcl.VIN
	INNER JOIN dbo.Manufacturer AS man ON vcl.ManufacturerID = man.ManufacturerID
	INNER JOIN dbo.Country AS cnt ON man.CountryID = cnt.CountryID
	INNER JOIN dbo.Model AS mdl ON vcl.ModelID = mdl.ModelID
	INNER JOIN dbo.Car_Type AS cty ON vcl.TypeID = cty.TypeID
	INNER JOIN dbo.Person AS per ON trn.PersonID = per.PersonID
	INNER JOIN dbo.Person_Type AS pty ON per.PersonTypeID = pty.PersonTypeID
	INNER JOIN dbo.Transaction_Type AS trntype ON trn.TypeCode = trntype.TypeCode
WHERE
	cnt.[Name] = @CountryName;

SELECT * FROM [dbo].[CountrySalesDetail]('United States')