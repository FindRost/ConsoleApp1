////
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int a = 4;
//int b = 5;
//if (a > 1)
//{
//    if (b > 2)
//    {
//        int SUM = a + b;
//        Console.WriteLine(sum);
//    }
//}

//public partial class MainClass
//{
//    public double Add(double a, double b
//        {
//        return a + b;
//    })
//}
//public partial class MainClass
//{
//    public double Add(double a, double b
//        {
//        return a - b;
//    })
//}
//public partial class MainClass
//{
//    public double Add(double a, double b
//        {
//        return a * b;
//    })
//}
//public partial class MainClass
//{
//    public double Add(double a, double b
//        {
//        return a / b;
//    })
//}
//public partial class MainClass
//{
//    public double Add(double a, double b
//        {
//        return a * b;
//    })
//}
////

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

string r = "Rost";
string h = "hello";
if (r == h)
{
    Console.WriteLine("одинковые значения");
}



--CREATE TABLE Jobs(
--	job_ID serial PRIMARY KEY,
--	job_title varchar(50) NOT NULL,
--	min_salary integer,
--	max_salary integer
--	);

--create table Users(
--	user_ID serial PRIMARY KEY,
--  first_name varchar(50) NOT NULL,
--	last_name varchar(50) NOT NULL,
--	job_ID integer NOT NULL,
--	FOREIGN KEY (job_ID) REFERENCES Jobs(job_ID)
--	);

--INSERT INTO Jobs(job_title, min_salary, max_salary) VALUES
--('Software Developer', 50000, 120000),
--('Data Scientist', 60000, 130000),
--('System Administrator', 40000, 90000),
--('Product Manager', 70000, 140000);

--INSERT INTO Users(first_name, last_name, job_ID) VALUES
--('John', 'Doe', 1), --Software Developer
--('Jane', 'Smith', 2), --Data Scientist
--('Alice', 'Johnson', 3), --System Administrator
--('Bob', 'Brown', 4); --Product Manager;

select first_name, last_name from Users where user_ID = 1



    CREATE TABLE Jobs (
	job_ID serial PRIMARY KEY,
    job_title varchar(50) NOT NULL,
    min_salary integer,
    max_salary integer
	);

create table Users (
	user_ID serial PRIMARY KEY,
    first_name varchar(50) NOT NULL,
    last_name varchar(50) NOT NULL,
    job_ID integer NOT NULL,
    FOREIGN KEY (job_ID) REFERENCES Jobs(job_ID)
	);

INSERT INTO Jobs (job_title, min_salary, max_salary) VALUES
	('Software Developer', 50000, 120000),
	('Data Scientist', 60000, 130000),
	('System Administrator', 40000, 90000),
	('Product Manager', 70000, 140000);

INSERT INTO Users (first_name, last_name, job_ID) VALUES
	('John','Doe',1), --Software Developer
	('Jane','Smith',2), --Data Scientist
	('Alice','Johnson',3), --System Administrator
	('Bob', 'Brown',4); --Product Manager;

select first_name, last_name from Users where user_ID = 1

CREATE TABLE employees (
	employee_id SERIAL PRIMARY KEY,
    first_name VARCHAR(50),
    last_name varchar(50),
    salary integer,
    CHECK (salary > 0)
);

create table Dailytime(
	dailytimeID serial primary key,
    ReceiptDate TIMESTAMP
	);
INSERT INTO Dailytime(ReceiptDate) VALUES
	('2024-04-13 01:23:45.0')
);
--receipt
CREATE TABLE Customers (
	customer_ID serial PRIMARY KEY,
    customer_title varchar(50) NOT NULL,
    total_sale integer,
    min_sale integer,
    max_sale integer
	);
CREATE TABLE Cashiers (
	cashier_ID serial PRIMARY KEY,
    cashier_name varchar(50) NOT NULL,
    cashier_lastname varchar(50) NOT NULL,
    total_sale integer,
    min_sale integer,
    max_sale integer
	);
INSERT INTO Customers (customer_title, total_sale, min_sale, max_sale) VALUES
	('OOO ROMASHKA', 100000, 50000, 120000),
	('OOO TD', 120000, 60000, 130000),
	('AO GAZ', 170000, 40000, 90000),
	('IP IVANOV', 110000, 70000, 140000);
INSERT INTO Cashiers (cashier_name, cashier_lastname, total_sale, min_sale, max_sale) VALUES
	('John','Doe',100000, 50000, 120000), --OOO ROMASHKA
	('Jane','Smith',120000, 60000, 130000), --OOO TD
	('Alice','Johnson',170000, 40000, 90000), --AO GAZ
	('Bob', 'Brown',110000, 70000, 140000); --IP IVANOV;

CREATE TABLE Orders (
	order_ID serial PRIMARY KEY,
    order_name varchar(50) NOT NULL,
    order_lastname varchar(50) NOT NULL,
    total_sale integer,
    min_sale integer,
    max_sale integer
	);
CREATE TABLE Email (
	Email_ID serial PRIMARY KEY,
    Email_name varchar(50) NOT NULL,
		);
CREATE TABLE Products (
	product_ID serial PRIMARY KEY,
    product_title varchar(50) NOT NULL,
    total_sale integer,
    min_sale integer,
    max_sale integer
	);
CREATE TABLE Categories (
	category_ID serial PRIMARY KEY,
    category_title varchar(50) NOT NULL,
    total_sale integer,
    min_sale integer,
    max_sale integer
	);
INSERT INTO Orders (orders_title, total_sale, min_sale, max_sale) VALUES
	('OOO ROMASHKA', 100000, 50000, 120000),
	('OOO TD', 120000, 60000, 130000),
	('AO GAZ', 170000, 40000, 90000),
	('IP IVANOV', 110000, 70000, 140000);
INSERT INTO Email (Email_name ) VALUES
	('ROMASHKA@mail.ru'), --OOO ROMASHKA
	('TD@ya.ru'), --OOO TD
	('GAZ@icloud.com'), --AO GAZ
	('IVANOV@gmail.com'); --IP IVANOV;
INSERT INTO Products (products_title, total_sale, min_sale, max_sale) VALUES
	('milk', 100000, 50000, 120000),
	('oil', 120000, 60000, 130000),
	('bread', 170000, 40000, 90000),
	('fish', 110000, 70000, 140000);
INSERT INTO Categories (categories_name, total_sale, min_sale, max_sale) VALUES
	('dry',100000, 50000, 120000), --OOO ROMASHKA
	('alko','Smith',120000, 60000, 130000), --OOO TD
	('diy',170000, 40000, 90000), --AO GAZ
	('fresh',110000, 70000, 140000); --IP IVANOV;