CREATE DATABASE MotoShopRacing
GO

USE MotoShopRacing
GO 

CREATE TABLE users(
	userID INT IDENTITY(1,1) NOT NULL,
	userFirstName VARCHAR(30) NOT NULL,
	userSecondName VARCHAR(30),
	userLastNames VARCHAR(30) NOT NULL,
	userRole BIT NOT NULL,	
	pass VARCHAR(40) NOT NULL,	
	CONSTRAINT PK_User PRIMARY KEY (userID)
)
GO

CREATE TABLE products(
	productID INT IDENTITY(1,1) NOT NULL,
	productName VARCHAR(75) NOT NULL,
	brand VARCHAR(30),
	quantity INT NOT NULL,
	price INT NOT NULL,
	CONSTRAINT PK_Product PRIMARY KEY (productID) 
)
GO

CREATE TABLE linkProdTicket(
	linkProdTick_ID INT IDENTITY(1,1),
	productID INT NOT NULL,
	ticketID INT NOT NULL,
	CONSTRAINT PL_LinkProdTick PRIMARY KEY (linkProdTick_ID)
)
GO

CREATE TABLE tickets(
	ticketID INT IDENTITY(1,1) NOT NULL,
	userID INT NOT NULL,
	productID INT NOT NULL,
	dateSale DATE NOT NULL,
	CONSTRAINT PK_Ticket PRIMARY KEY (ticketID)
)
GO

CREATE TABLE clients(
	clientID INT IDENTITY(1,1) NOT NULL,
	clientFirstName VARCHAR(30) NOT NULL,
	clientSecondName VARCHAR(30),
	clientLastNames VARCHAR(60) NOT NULL,
	clientPhoneNumber VARCHAR(12) NOT NULL,
	CONSTRAINT PK_Client PRIMARY KEY (clientID)
)
GO

CREATE TABLE linkClientDebt(
	linkCD_ID INT IDENTITY(1,1) NOT NULL,
	clientID INT NOT NULL,
	debtID INT NOT NULL,
	CONSTRAINT PK_LinkCD PRIMARY KEY (linkCD_ID)
)
GO

CREATE TABLE clientsDebts(
	debtID INT IDENTITY(1,1),
	productName VARCHAR(60) NOT NULL,
	productPrice INT NOT NULL,
	CONSTRAINT PK_Debt PRIMARY KEY (debtID)
)
GO

ALTER TABLE linkClientDebt
ADD CONSTRAINT FK_linkClientDebt
FOREIGN KEY (clientID)
REFERENCES clients (clientID)
GO

ALTER TABLE linkProdTicket
ADD CONSTRAINT FK_linkProd
FOREIGN KEY (productID)
REFERENCES products (productID) 
GO

ALTER TABLE linkProdTicket
ADD CONSTRAINT FK_linkProd1
FOREIGN KEY (ticketID)
REFERENCES tickets (ticketID) 
GO

ALTER TABLE linkClientDebt
ADD CONSTRAINT FK_linkClientDebt1
FOREIGN KEY (debtID)
REFERENCES clientsDebts (debtID)
GO

ALTER TABLE tickets
ADD CONSTRAINT FK_TicUser
FOREIGN KEY (userID)
REFERENCES users (userID)
GO

INSERT INTO users VALUES ('ADMIN', '', ' ', 1, '123')

select * from users

select productID As 'ID Producto', productName As 'Nombre Producto', brand As 'Marca', quantity As 'Cantidad', price As 'Precio' from products

INSERT INTO products VALUES ('', '', 0, 0)

--Tipos de fechas

--select CONVERT(VARCHAR(10),GETDATE(),110) AS 'Fecha 1'

--Select CONVERT(VARCHAR(19),GETDATE()) AS 'Fecha 2'

