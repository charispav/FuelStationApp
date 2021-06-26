----------------------------------- CREATE SCHEMA-----------------------------
CREATE SCHEMA FuelStation;
----------------------------------- CREATE SCHEMA-----------------------------

----------------------------------- CUSTOMER----------------------------------

CREATE TABLE [FuelStation].[Customers](
    [ID] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [Surname] [nvarchar](50) NOT NULL,
    [CardNumber] [int] NOT NULL
)

INSERT INTO FuelStation.Customers ([ID], [Name], [Surname], [CardNumber]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd91' , 'Dorothea', 'Sarri', 1)

INSERT INTO FuelStation.Customers ([ID], [Name], [Surname], [CardNumber]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd92' , 'Haris', 'Pavlidis', 2)

select * from [FuelStation].[Customers]



----------------------------------- CUSTOMER----------------------------------

----------------------------------- ITEM--------------------------------------

CREATE TABLE [FuelStation].[Items](
    [ID] [uniqueidentifier] NOT NULL,
    [Code] [nvarchar](50) NOT NULL,
    [Description] [nvarchar](150) NOT NULL,
    [ItemType] [varchar] (20) NOT NULL,
	[Price] [numeric] (10,2) NOT NULL,
	[Cost] [numeric] (10,2) NOT NULL
)

INSERT INTO FuelStation.Items ([ID], [Code], [Description], [ItemType], [Price], [Cost]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd70' , '01-A', 'DIESEL', 'Fuel', 1.4 ,1)

INSERT INTO FuelStation.Items([ID], [Code], [Description], [ItemType], [Price], [Cost])  VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd71' , '01-B', 'GAS', 'Fuel' , 0.9, 0.7)

select * from [FuelStation].[Items]


----------------------------------- ITEM------------------------------------------

----------------------------------- TRANSACTION-----------------------------------

CREATE TABLE [FuelStation].[Transaction](
    [ID] [uniqueidentifier] NOT NULL,
    [Date] [date] NOT NULL,
    [CustomerID] [uniqueidentifier] NOT NULL,
    [DiscountValue] [numeric] (3,2) NOT NULL,
	[TotalValue] [numeric] (10,2) NOT NULL
)

INSERT INTO FuelStation.[Transaction] ([ID], [Date], [CustomerID], [DiscountValue], [TotalValue]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd00' , '20210626', '0cd7b170-155b-4180-91d4-74eea71bcd91', 0, 10)

INSERT INTO FuelStation.[Transaction] ([ID], [Date], [CustomerID], [DiscountValue], [TotalValue])  VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd01' , '20210626', '0cd7b170-155b-4180-91d4-74eea71bcd92', 0.10, 100)

select * from [FuelStation].[Transaction]

----------------------------------- TRANSACTION-----------------------------------

----------------------------------- TRANSACTIONLINE-----------------------------------

CREATE TABLE [FuelStation].[TransactionLine](
    [ID] [uniqueidentifier] NOT NULL,
    [TransactionId] [uniqueidentifier] NOT NULL,
    [ItemID] [uniqueidentifier] NOT NULL,
    [Quantity] [numeric] (5,2)  NOT NULL,
	[ItemPrice] [numeric] (10,2) NOT NULL,
	[Value] [numeric] (10,2) NOT NULL
)

INSERT INTO FuelStation.[TransactionLine] ([ID], [TransactionId], [ItemID], [Quantity], [ItemPrice], [Value]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd10' , '0cd7b170-155b-4180-91d4-74eea71bcd00', '0cd7b170-155b-4180-91d4-74eea71bcd70', 1, 1.4,1.4)

INSERT INTO FuelStation.[TransactionLine] ([ID], [TransactionId], [ItemID], [Quantity], [ItemPrice], [Value])  VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd11' , '0cd7b170-155b-4180-91d4-74eea71bcd01', '0cd7b170-155b-4180-91d4-74eea71bcd71', 1, 0.9,0.9)

select * from [FuelStation].[TransactionLine]

----------------------------------- TRANSACTIONLINE-----------------------------------



----------------------------------- EMPLOYEE-----------------------------------

CREATE TABLE [FuelStation].[Employee](
    [ID] [uniqueidentifier] NOT NULL,
    [Name] [nvarchar](50) NOT NULL,
    [Surname] [nvarchar](50) NOT NULL,
    [DateStart] [date] NOT NULL,
	[DateEnd] [date] NOT NULL,
	[Sallary] [numeric] (10,2) NOT NULL
)

INSERT INTO FuelStation.Employee ([ID], [Name], [Surname], [DateStart], [DateEnd], [Sallary]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd89' , 'Maria', 'Papadopoulou', '20200101', '20200930' ,800)

INSERT INTO FuelStation.Employee ([ID], [Name], [Surname], [DateStart], [DateEnd], [Sallary]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd90' , 'Giannis', 'Papadopoulos', '20210101', '20210501' ,1000)

select * from [FuelStation].[Employee]

----------------------------------- EMPLOYEE-----------------------------------

----------------------------------- LEDGER-------------------------------------

CREATE TABLE [FuelStation].[Ledger](
    [ID] [uniqueidentifier] NOT NULL,
    [DateFrom] [date] NOT NULL,
	[DateTo] [date] NOT NULL,
	[Income] [numeric] (10,2) NOT NULL,
	[Expences] [numeric] (10,2) NOT NULL,
	[Total] [numeric] (10,2) NOT NULL
)

INSERT INTO FuelStation.[Ledger] ([ID], [DateFrom], [DateTo], [Income], [Expences], [Total]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd10' , '20200101', '20200131', 2000, 1000,1000)

INSERT INTO FuelStation.[Ledger]  ([ID], [DateFrom], [DateTo], [Income], [Expences], [Total]) VALUES ('0cd7b170-155b-4180-91d4-74eea71bcd11' , '20200201', '20200228', 3000, 1000,2000)

select * from [FuelStation].[Ledger]

----------------------------------- LEDGER-------------------------------------