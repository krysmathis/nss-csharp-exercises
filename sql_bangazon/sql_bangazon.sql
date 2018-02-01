DELETE FROM ComputerEmployee;
DELETE FROM EmployeeTraining;
DELETE FROM Training;
DELETE FROM Computer;
DELETE FROM Employee;
DELETE FROM Department;
DELETE FROM OrderProduct;
DELETE FROM `Order`;
DELETE FROM CustomerPaymentType;
DELETE FROM PaymentType;
DELETE FROM PRODUCT;
DELETE FROM Customer;
DELETE FROM ProductCategory;



DROP TABLE IF EXISTS ComputerEmployee;
DROP TABLE IF EXISTS  EmployeeTraining;
DROP TABLE IF EXISTS Training;
DROP TABLE IF EXISTS Computer;
DROP TABLE IF EXISTS Department;
DROP TABLE IF EXISTS Employee;
DROP TABLE IF EXISTS OrderProduct;
DROP TABLE IF EXISTS CustomerPaymentType;
DROP TABLE IF EXISTS PaymentType;
DROP TABLE IF EXISTS `Order`;
DROP TABLE IF EXISTS PRODUCT;
DROP TABLE IF EXISTS Customer;
DROP TABLE IF EXISTS ProductCategory;


CREATE TABLE `Department` (
	`DepartmentId` INTEGER PRIMARY KEY AUTOINCREMENT,
	`Name` TEXT NOT NULL,
	`Location` TEXT NOT NULL,
	`ExpenseBudget` REAL NOT NULL
);

CREATE TABLE `Employee` (
	`EmployeeId` INTEGER primary key autoincrement,
	`DepartmentId` INTEGER NOT NULL,
	`FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
	`Position` TEXT NOT NULL,
	`IsSupervisor` INT NOT NULL,
	`EmploymentStartDate` TEXT NOT NULL,
	`EmploymentEndDate` TEXT,
	`Birthday` TEXT NOT NULL,
	 FOREIGN KEY (`DepartmentId`) REFERENCES `Department` (`DepartmentId`)
);

/* COMPUTER */
CREATE TABLE `Computer` (
	`ComputerId` INTEGER primary key autoincrement,
	`SerialNumber` INTEGER NOT NULL,
	`Manufacturer` TEXT NOT NULL,
	`ModelNumber` TEXT NOT NULL,
	`RAM` TEXT NOT NULL,
	`HardDrive` TEXT NOT NULL,
	`IsFunctional` INTEGER NOT NULL,
	`PurchaseDate` TEXT NOT NULL,
	`DecommissionedDate` TEXT
);

/* COMPUTEREMPLOYEES */
CREATE TABLE `ComputerEmployee` (
	`ComputerEmployeeId` INTEGER primary key autoincrement,
	`ComputerId` INTEGER NOT NULL,
	`EmployeeId` INTEGER NOT NULL,
	`StartDate` TEXT NOT NULL,
	`EndDate` TEXT,
	FOREIGN KEY (`ComputerId`) REFERENCES `Computer`(`ComputerId`),
	FOREIGN KEY (`EmployeeId`) REFERENCES `Employee`(`EmployeeId`)
); 

/*TRAINING */
CREATE TABLE `Training` (
	`TrainingId` INTEGER Primary key autoincrement,
	`Name` TEXT NOT NULL,
	`Description` TEXT NOT NULL,
	`StartDate` TEXT NOT NULL,
	`Hours` integer Not Null,
	`EndDate` TEXT,
	`MaxAttendees` INTEGER NOT NULL,
	`Instructor` TEXT NOT NULL
);

/* EMPLOYEE TRAINING */
CREATE TABLE `EmployeeTraining` (
	`EmployeeTraining` INTEGER primary key autoincrement,
	`TrainingId` Integer not null,
	`EmployeeId` Integer not null,
	`IsComplete` Integer not null,
	foreign key (`TrainingId`) REFERENCES `Training`(`TrainingId`),
	foreign key (`EmployeeId`) REFERENCES `Employee`(`EmployeeId`)
);
/* PRODUCTCATEGORIES */
CREATE TABLE `ProductCategory` (
	`ProductCategoryId` Integer primary key autoincrement,
	`Number` Integer not null,
	`Name` Text not null
);

 /* CUSTOMER */
CREATE TABLE `Customer` (
	`CustomerId` INTEGER Primary key autoincrement,
	`FirstName` TEXT NOT NULL,
	`LastName` TEXT NOT NULL,
	`AccountCreationDate` TEXT NOT NULL,
	`LastActivityDate` TEXT NOT NULL,
	`IsInactive` INT NOT NULL,
	`Email` TEXT NOT NULL,
	`AvatarLink` INT NOT NULL,
	`Address` TEXT NOT NULL,
	`City` TEXT NOT NULL,
	`State` TEXT NOT NULL,
	`ZipCode` TEXT NOT NULL
);


/*PRODUCTS */
CREATE TABLE `Product` (
	`ProductId` INTEGER primary key autoincrement,
	`ProductCategoryId` INTEGER NOT NULL,
	`CustomerId` INTEGER NOT NULL,
	`Title` TEXT NOT NULL,
	`Description` TEXT NOT NULL,
	`Price` REAL NOT NULL,
	`Quantity` INT NOT NULL,
	`Image` INT NOT NULL,
	FOREIGN KEY (`ProductCategoryId`) REFERENCES `ProductCategory` (`ProductCategoryId`),
	FOREIGN KEY (`CustomerId`) REFERENCES `Customer` (`CustomerId`)
);

/* PAYMENT TYPES */
CREATE TABLE `PaymentType` (
	`PaymentTypeId` INTEGER Primary key autoincrement,
	`Name` TEXT NOT NULL
);

/* CUSTOMER PAYMENT TYPES */
CREATE TABLE `CustomerPaymentType` (
	`CustomerPaymentTypeId` INTEGER primary key autoincrement,
	`CustomerId` INTEGER NOT NULL,
	`PaymentTypeId` INTEGER NOT NULL,
	`AccountNumber` INTEGER NOT NULL,
	FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`),
	FOREIGN KEY (`PaymentTypeId`) REFERENCES `PaymentType`(`PaymentTypeId`) 
);

CREATE TABLE `Order` (
	`OrderId` INTEGER primary key autoincrement,
	`CustomerId` INTEGER NOT NULL,
	`CustomerPaymentTypeId` INTEGER NOT NULL,
	`CreatedOn` TEXT NOT null,
	FOREIGN KEY (`CustomerId`) REFERENCES `Customer`(`CustomerId`),
	FOREIGN KEY(`CustomerPaymentTypeId`) REFERENCES `CustomerPaymentType`(`CustomerPaymentTypeId`)
);

CREATE TABLE `OrderProduct` (
	`OrderDetailId` INTEGER primary key autoincrement,
	`OrderId` INTEGER NOT NULL,
	`ProductId` INTEGER NOT NULL,
	FOREIGN KEY (`OrderId`) REFERENCES `Order`(`OrderId`),
	FOREIGN KEY(`ProductId`) REFERENCES `Product`(`ProductId`)
);

/* INSERT DATA */

/* DEPT */
INSERT INTO Department VALUES (null,'IT','2-E',130000);
INSERT INTO Department VALUES (null,'Supply Chain','2-E',250000);

/* EMPLOYEE */
INSERT INTO EMPLOYEE  
	SELECT null,
				d.DepartmentId,
				'Mark',
				'Marquez',
				'Director',
				1,
				'2018-03-31',
				null,
				'1977-02-12'
		FROM Department d
		WHERE d.Name = "IT";
		
INSERT INTO EMPLOYEE  
	SELECT null,
				d.DepartmentId,
				'Linda',
				'Miller',
				'Analyst',
				0,
				'2018-03-31',
				null,
				'1989-03-13'
		FROM Department d
		WHERE d.Name = "Supply Chain";
		
INSERT INTO Computer VALUES (null, 1,'Dell', 'Latitude', '8GB','256GB',1,'2015-02-15',null);
INSERT INTO Computer VALUES (null, 2,'HP', 'Parallon', '8GB','512GB',1,'2016-02-15',null);

INSERT INTO ComputerEmployee
	SELECT null,
		c.ComputerId,
		e.EmployeeId,
		'2015-04-01',
		null
	FROM Employee e, Computer c
	WHERE e.FirstName = 'Mark' AND e.LastName='Marquez'
	AND c.SerialNumber = 1;
	
INSERT INTO ComputerEmployee
	SELECT null,
		c.ComputerId,
		e.EmployeeId,
		'2015-04-01',
		null
	FROM Employee e, Computer c
	WHERE e.FirstName = 'Linda' AND e.LastName='Miller'
	AND c.SerialNumber = 2;
/* Training */
INSERT INTO Training Values (null, 'SQL', 'Write SQL', '2018-04-01', '2018-04-01',4, 20, 'Max Bezier');
INSERT INTO Training Values (null, 'NoSQL', 'Write NoSQL', '2018-04-02', '2018-04-02',8, 25, 'Max Bezier');

/* Employee Training */
INSERT INTO EmployeeTraining
	SELECT null,
		t.TrainingId,
		e.EmployeeId,
		0
	FROM Training t, Employee e
	WHERE t.Name = 'SQL' 
	AND e.FirstName = 'Mark' and e.LastName = 'Marquez';
	
INSERT INTO EmployeeTraining
	SELECT null,
		t.TrainingId,
		e.EmployeeId,
		0
	FROM Training t, Employee e
	WHERE t.Name = 'NoSQL' 
	AND e.FirstName = 'Linda' and e.LastName = 'Miller';
	
/* Product Category */
INSERT INTO ProductCategory VALUES (null,100,'Computers');
INSERT INTO ProductCategory VALUES (null,200,'Wedding');

/* Payment Type */
INSERT INTO PaymentType VALUES (null, 'Paypal');
INSERT INTO PaymentType VALUES (null, 'Visa');

/* Customers */
INSERT INTO Customer VALUES (null, 'Jerry', 'Seinfeld', '2015-01-03', '2018-01-21',0,'jerry@jerry.com','//link','1600 Pennsylvania Ave', 'New York', 'NY', '37206-2345');
INSERT INTO Customer VALUES (null, 'George', 'Costanza', '2015-02-03', '2018-01-21',0,'george@george.com','//link','1600 Pennsylvania Ave', 'New York', 'NY', '37206-2345');

/* Product */
INSERT INTO Product 
	SELECT null,
	pc.ProductCategoryId,
	c.CustomerId,
	'Laptop',
	'Used laptop still works',
	25.00,
	1,
	'//htstet'
	FROM ProductCategory pc, Customer c
	WHERE pc.Name = 'Computers'
	AND c.FirstName = 'Jerry' and c.LastName = 'Seinfeld';
	
INSERT INTO Product 
	SELECT null,
	pc.ProductCategoryId,
	c.CustomerId,
	'Box of Wedding Stuff',
	'Old invitations mainly, use at your own risk',
	15.00,
	1,
	'//htstet'
	FROM ProductCategory pc, Customer c
	WHERE pc.Name = 'Wedding'
	AND c.FirstName = 'George' and c.LastName = 'Costanza';
	
	
/* Customer Payment Type' */
INSERT INTO CustomerPaymentType
	SELECT null,
		p.PaymentTypeId,
		c.CustomerId,
		12345
	FROM PaymentType p, Customer c
	WHERE p.Name = 'Visa'
	AND c.FirstName = 'Jerry' and c.LastName = 'Seinfeld';
	
INSERT INTO CustomerPaymentType
	SELECT null,
		p.PaymentTypeId,
		c.CustomerId,
		12345
	FROM PaymentType p, Customer c
	WHERE p.Name = 'Paypal'
	AND c.FirstName = 'George' and c.LastName = 'Costanza';
	
INSERT INTO `Order`
	SELECT 
		null,
		c.CustomerId,
		cpt.CustomerPaymentTypeId,
		Date()
	From Customer c, CustomerPaymentType cpt, PaymentType pt
	WHERE c.FirstName = 'Jerry' and c.LastName = 'Seinfeld'
	AND pt.Name = 'Visa' AND pt.PaymentTypeId = cpt.PaymentTypeId
	AND cpt.CustomerId = c.CustomerId;
	
INSERT INTO `Order`
	SELECT 
		null,
		c.CustomerId,
		cpt.CustomerPaymentTypeId,
		Date()
	From Customer c, CustomerPaymentType cpt, PaymentType pt
	WHERE c.FirstName = 'George' and c.LastName = 'Costanza'
	AND pt.Name = 'Paypal' AND pt.PaymentTypeId = cpt.PaymentTypeId
	AND cpt.CustomerId = c.CustomerId;

	
INSERT INTO OrderProduct
	SELECT null,
		o.OrderId,
		p.ProductId
	FROM Product p, `Order` o, Customer c
	WHERE p.Title = 'Box of Wedding Stuff'
	AND c.FirstName = 'Jerry' and c.LastName = 'Seinfeld'
	AND c.CustomerId = o.CustomerId;
	
INSERT INTO OrderProduct
	SELECT null,
		o.OrderId,
		p.ProductId
	FROM Product p, `Order` o, Customer c
	WHERE p.Title = 'Laptop'
	AND c.FirstName = 'George' and c.LastName = 'Costanza'
	AND c.CustomerId = o.CustomerId;
	
		