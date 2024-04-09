-- Create the AutoLot database
CREATE DATABASE AutoLot;
GO

-- Switch context to the AutoLot database
USE AutoLot;
GO

-- Create Inventory table
CREATE TABLE Inventory(
    CarId INT IDENTITY(1,1) PRIMARY KEY,
    Make NVARCHAR(50),
    Color NVARCHAR(50),
    PetName NVARCHAR(50)
);
GO

-- Insert data into the Inventory table
INSERT INTO Inventory(Make, Color, PetName) VALUES
    ('VW', 'Black', 'Zippy'),
    ('Ford', 'Rust', 'Rusty'),
    ('Saab', 'Black', 'Mel'),
    ('Yogo', 'Yellow', 'Clunker'),
    ('BMW', 'Black', 'Bimmer'),
    ('BMV', 'Green', 'Hank'),
    ('BMV', 'Pink', 'Pinky');
GO

-- Create Customers table
CREATE TABLE Customers(
    CustId INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50)
);
GO

-- Insert data into the Customers table
INSERT INTO Customers(FirstName, LastName) VALUES
    ('Dave', 'Brenner'),
    ('Matt', 'Walton'),
    ('Steve', 'Hagen'),
    ('Pat', 'Walton');
GO

-- Create Orders table
CREATE TABLE Orders(
    OrderId INT IDENTITY(1,1) PRIMARY KEY,
    CustId INT,
    CarId INT,
    FOREIGN KEY (CustId) REFERENCES Customers(CustId),
    FOREIGN KEY (CarId) REFERENCES Inventory(CarId)
);
GO

-- Insert data into the Orders table
INSERT INTO Orders(CustId, CarId) VALUES
    (1, 5),
    (2, 1),
    (3, 4),
    (4, 7);
GO
