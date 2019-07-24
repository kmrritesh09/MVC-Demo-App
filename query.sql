CREATE TABLE Customer
(
	ID INT PRIMARY KEY,
	NAME VARCHAR(100)
)

CREATE TABLE CustomerType
(
	ID INT PRIMARY KEY,
	Type VARCHAR(50),
	IsActive CHAR(1)
)

CREATE TABLE Customer_CustomerType
(
	ID INT PRIMARY KEY,
	CustomerID INT FOREIGN KEY REFERENCES Customer(ID),
	CustomerTypeID INT FOREIGN KEY REFERENCES CustomerType(ID)
)

INSERT INTO Customer VALUES (1, 'cust1')
INSERT INTO Customer VALUES (2, 'cust2')
INSERT INTO Customer VALUES (3, 'cust3')
INSERT INTO Customer VALUES (4, 'cust4')
INSERT INTO Customer VALUES (5, 'cust5')
INSERT INTO Customer VALUES (6, 'cust6')
INSERT INTO Customer VALUES (7, 'cust7')
INSERT INTO Customer VALUES (8, 'cust8')
INSERT INTO Customer VALUES (9, 'cust9')
INSERT INTO Customer VALUES (10, 'cust10')

INSERT INTO CustomerType VALUES (1, 'ABC','0')
INSERT INTO CustomerType VALUES (2, 'DEF', '1')
INSERT INTO CustomerType VALUES (3, 'XYZ', '1')

INSERT INTO Customer_CustomerType VALUES (1, 1, 1);
INSERT INTO Customer_CustomerType VALUES (2, 2, 2);
INSERT INTO Customer_CustomerType VALUES (3, 3, 1);
INSERT INTO Customer_CustomerType VALUES (4, 4, 3);
INSERT INTO Customer_CustomerType VALUES (5, 5, 3);
INSERT INTO Customer_CustomerType VALUES (6, 6, 3);
INSERT INTO Customer_CustomerType VALUES (7, 7, 3);
INSERT INTO Customer_CustomerType VALUES (8, 8, 2);
INSERT INTO Customer_CustomerType VALUES (9, 9, 2);
INSERT INTO Customer_CustomerType VALUES (10, 10, 3);

SELECT * FROM Customer;
SELECT * FROM CustomerType;
SELECT * FROM Customer_CustomerType;
