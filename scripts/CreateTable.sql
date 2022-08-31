CREATE TABLE dbo.Color
(ColorID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name]  VARCHAR(50) NOT NULL,
 HexCode VARCHAR(50) NOT NULL, 
 PRIMARY KEY(ColorID)
);

CREATE TABLE dbo.Car_Type
(TypeID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name] VARCHAR(50) NOT NULL, 
 PRIMARY KEY(TypeID)
);

CREATE TABLE dbo.Country
(CountryID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name] VARCHAR(50) NOT NULL, 
 PRIMARY KEY(CountryID)
);

CREATE TABLE dbo.[State]
(StateID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name] VARCHAR(50) NOT NULL, 
 CountryID INT,
 PRIMARY KEY(StateID),
 FOREIGN KEY(CountryID) REFERENCES dbo.Country(CountryID), 
);

CREATE TABLE dbo.City
(CityID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name] VARCHAR(50) NOT NULL,
 StateID INT,
 PRIMARY KEY(CityID),
 FOREIGN KEY(StateID) REFERENCES dbo.[State](StateID)
);

CREATE TABLE dbo.Manufacturer
(ManufacturerID INT IDENTITY(1,1) UNIQUE NOT NULL,
 [Name] VARCHAR(50) NOT NULL, 
 CountryID INT, 
 PRIMARY KEY(ManufacturerID),
 FOREIGN KEY(CountryID) REFERENCES dbo.Country(CountryID), 
);
 
CREATE TABLE dbo.Model
(ModelID INT IDENTITY(1,1) UNIQUE NOT NULL,
 [Name] VARCHAR(50) NOT NULL, 
 ManufacturerID INT,
 TypeID INT, 
 PRIMARY KEY(ModelID),
 FOREIGN KEY(ManufacturerID) REFERENCES dbo.Manufacturer(ManufacturerID), 
 FOREIGN KEY(TypeID) REFERENCES dbo.Car_Type(TypeID), 
);

CREATE TABLE dbo.Vehicle
(VIN          UNIQUEIDENTIFIER NOT NULL, 
 ManufacturerID INT, 
 ModelID      INT, 
 TypeID       INT, 
 ColorID      INT, 
 Milage       INT, 
 [Year]       DATE,
 Fuel		  VARCHAR(50) NOT NULL CHECK(Fuel IN('Gasoline', 'Diesel', 'CNG', 'Biodiesel', 'LPG', 'Ethanol', 'Methanol', 'Hydrogen', 'Electric', 'Hybrid')),
 PRIMARY KEY(VIN), 
 FOREIGN KEY(TypeID) REFERENCES dbo.Car_Type(TypeID), 
 FOREIGN KEY(ColorID) REFERENCES dbo.Color(ColorID),
 FOREIGN KEY(ManufacturerID) REFERENCES dbo.Manufacturer(ManufacturerID)
);

CREATE TABLE dbo.Person_Type
(PersonTypeID INT IDENTITY(1,1) UNIQUE NOT NULL,
 [Name] 	  VARCHAR(50) NOT NULL,
 PRIMARY KEY(PersonTypeID) 
);

CREATE TABLE dbo.Person
(PersonID     INT IDENTITY(1,1) UNIQUE NOT NULL,
 PersonTypeID INT NOT NULL,
 NationalCode VARCHAR(50) NOT NULL,
 FirstName    VARCHAR(50) NOT NULL, 
 LastName     VARCHAR(50) NOT NULL,
 Gender       VARCHAR(50), 
 CityID       INT,
 EmailAddress VARCHAR(50),
 ModificationDate	DATETIME,
 PRIMARY KEY(PersonID), 
 FOREIGN KEY(CityID) REFERENCES dbo.City(CityID),
 FOREIGN KEY(PersonTypeID) REFERENCES dbo.Person_Type(PersonTypeID)
);

CREATE TABLE dbo.Transaction_Type
(TypeCode INT IDENTITY(1,1) UNIQUE NOT NULL, 
 [Name]   VARCHAR(50) NOT NULL, 
 PRIMARY KEY(TypeCode)
);

CREATE TABLE dbo.[Transaction]
(TransactionID INT IDENTITY(1,1) UNIQUE NOT NULL, 
 TypeCode      INT, 
 PersonID	   INT,
 VIN           UNIQUEIDENTIFIER, 
 [Date]        VARCHAR(50), 
 Price         INT,
 Currency 	   VARCHAR(50), 
 PRIMARY KEY(TransactionID), 
 FOREIGN KEY(TypeCode) REFERENCES dbo.Transaction_type(TypeCode), 
 FOREIGN KEY(PersonID) REFERENCES dbo.Person(PersonID), 
 FOREIGN KEY(VIN) REFERENCES dbo.Vehicle(VIN));