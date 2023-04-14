CREATE TABLE Item (
    ItemID  INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL,
    Size VARCHAR(10),
    Price DECIMAL(10,2) NOT NULL
);

-- Agent table definition
CREATE TABLE Agent (
    AgentID INT IDENTITY(1,1) PRIMARY KEY,
    AgentName VARCHAR(50) NOT NULL,
    Address VARCHAR(100) NOT NULL
);

-- Order table definition
CREATE TABLE [Order] (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    OrderDate DATE NOT NULL,
    AgentID INT NOT NULL FOREIGN KEY REFERENCES Agent(AgentID)
);

-- OrderDetail table definition
CREATE TABLE OrderDetail (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    OrderID INT NOT NULL FOREIGN KEY REFERENCES [Order](OrderID),
    ItemID INT NOT NULL FOREIGN KEY REFERENCES Item(ItemID),
    Quantity INT NOT NULL,
    UnitAmount DECIMAL(10,2) NOT NULL
);

INSERT INTO Item (ItemName, Size, Price)
VALUES 
   ('T-Shirt', 'M', 19.99),
('Jeans', '32x34', 49.99),
('Hoodie', 'L', 29.99),
('Sneakers', '9', 69.99),
('Backpack', 'One Size', 39.99),
('Sunglasses', 'One Size', 24.99),
('Watch', 'One Size', 59.99),
('Dress', 'S', 79.99),
('Suit', '40R', 199.99),
('Sweater', 'M', 39.99),
('Skirt', 'S', 29.99),
('Boots', '8', 89.99),
('Scarf', 'One Size', 14.99),
('Gloves', 'One Size', 9.99),
('Jacket', 'M', 99.99),
('Hat', 'One Size', 19.99),
('Belt', '36', 14.99),
('Purse', 'One Size', 49.99),
('Earrings', 'One Size', 19.99),
('Necklace', 'One Size', 29.99);

-- Seed data for Agent table
INSERT INTO Agent (AgentName, Address)
VALUES
  ('John Smith', '123 Main St, Anytown USA'),
('Jane Doe', '456 Oak Ave, Anytown USA'),
('Bob Johnson', '789 Elm St, Anytown USA'),
('Amy Lee', '321 Maple Rd, Anytown USA'),
('Mike Brown', '654 Pine Dr, Anytown USA'),
('Sarah Davis', '987 Cedar Ln, Anytown USA'),
('David Wilson', '246 Birch St, Anytown USA'),
('Karen Taylor', '369 Juniper Ave, Anytown USA'),
('Tom Jones', '802 Cherry Ln, Anytown USA'),
('Mary Johnson', '567 Pine St, Anytown USA'),
('Mark Lee', '143 Maple Ave, Anytown USA'),
('Lisa Davis', '569 Oak St, Anytown USA'),
('Tim Wilson', '789 Cedar Ave, Anytown USA'),
('Emily Taylor', '345 Birch Dr, Anytown USA'),
('Steve Jones', '908 Cherry Rd, Anytown USA'),
('Megan Johnson', '234 Pine Ave, Anytown USA'),
('Kevin Lee', '671 Maple Ln, Anytown USA'),
('Lauren Davis', '789 Oak Rd, Anytown USA'),
('Andrew Wilson', '245 Cedar St, Anytown USA'),
('Samantha Taylor', '123 Birch Ave, Anytown USA');

-- Seed data for Order table
INSERT INTO [Order] (OrderDate, AgentID)
VALUES
   ('2022-01-01', 1),
('2022-01-05', 3),
('2022-01-08', 2),
('2022-01-12', 5),
('2022-01-15', 4),
('2022-01-19', 6),
('2022-01-22', 7),
('2022-01-25', 8),
('2022-01-29', 10),
('2022-02-01', 9),
('2022-02-05', 12),
('2022-02-08', 11),
('2022-02-12', 13),
('2022-02-15', 15),
('2022-02-19', 14),
('2022-02-22', 16),
('2022-02-25', 17),
('2022-03-01', 19),
('2022-03-05', 18),
('2022-03-08', 20);

-- Seed data for OrderDetail table
INSERT INTO OrderDetail (OrderID, ItemID, Quantity, UnitAmount)
VALUES
 (1, 1, 2, 19.99),
(1, 3, 1, 29.99),
(1, 5, 1, 39.99),
(2, 2, 1, 49.99),
(2, 4, 1, 69.99),
(2, 7, 1, 59.99),
(3, 1, 1, 19.99),
(3, 6, 1, 24.99),
(3, 10, 2, 39.99),
(4, 8, 1, 79.99),
(4, 9, 1, 199.99),
(4, 12, 1, 89.99),
(5, 11, 1, 29.99),
(5, 13, 1, 14.99),
(5, 14, 1, 9.99),
(6, 15, 1, 99.99),
(6, 16, 1, 19.99),
(7, 17, 1, 14.99),
(7, 18, 1, 49.99),
(7, 19, 1, 19.99);
