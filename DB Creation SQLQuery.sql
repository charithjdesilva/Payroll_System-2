CREATE DATABASE GryfindoSystemV2;

USE GryfindoSystemV2;

CREATE TABLE SysAdmin(
	username VARCHAR(20) NOT NULL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	password VARCHAR(20) NOT NULL
);

CREATE TABLE Faculty(
	FacultyID INT PRIMARY KEY,
	FacultyStartedDate DATE NOT NULL,
	Name VARCHAR(100) NOT NULL,
);

CREATE TABLE Department(
	DepartmentID INT PRIMARY KEY,
	FacultyID INT NOT NULL,
	DepartmentStartedDate DATE NOT NULL,
	Name VARCHAR(100) NOT NULL,
	FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);

CREATE TABLE Employee(
	EmployeeID INT NOT NULL PRIMARY KEY,
	Emp_name VARCHAR(100) NOT NULL,
	Emp_dob DATE NOT NULL,
	Emp_gender VARCHAR(6) NOT NULL,
	Emp_phone VARCHAR(10) NOT NULL,
	Emp_address VARCHAR(200) NOT NULL,
	monthlySalary DECIMAL(14, 2) NULL,
	otRates_hourly DECIMAL(10, 2) NULL,
	allowances DECIMAL(14, 2) NULL,
	DepartmentID INT NOT NULL,
	username VARCHAR(20) NOT NULL,
	CONSTRAINT genderCheck CHECK (Emp_gender = 'Female' or Emp_gender = 'Male'),
	FOREIGN KEY (DepartmentID) REFERENCES Department(DepartmentID),
	FOREIGN KEY (username) REFERENCES SysAdmin(username)
);

CREATE TABLE Salary(
	SalaryID INT PRIMARY KEY,
	EmployeeID INT NOT NULL,
	BasePay DECIMAL(14, 2) NULL,
	NoPay DECIMAL(14, 2) NULL,
	GrossPay DECIMAL(14, 2) NULL,
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);


CREATE TABLE Settings(
	salCycleBeginDate DATE NOT NULL,
	salCycleEndDate DATE NOT NULL,
	dateRange INT NOT NULL,
	noOfLeaves DECIMAL(3, 0) NOT NULL,
	username VARCHAR(20) NOT NULL,
	FOREIGN KEY (username) REFERENCES SysAdmin(username)
);

CREATE TABLE EmpDependent(
	DependentID INT PRIMARY KEY,
	EmployeeID INT NOT NULL,
	Dep_Name VARCHAR(100) NOT NULL,
	Dep_dob DATE NOT NULL,
	Dep_gender VARCHAR(6) NOT NULL,
	Dep_phone VARCHAR(10) NOT NULL,
	CONSTRAINT genderCheckDep CHECK (Dep_gender = 'Female' or Dep_gender = 'Male'),
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE Holiday(
	HolidayID INT PRIMARY KEY,
	No_of_days INT NOT NULL,
	Name VARCHAR(100) NOT NULL,
	HolidayStartDate DATE NOT NULL
);

CREATE TABLE Leave(
	LeaveID INT PRIMARY KEY,
	No_of_days INT NOT NULL,
	Name VARCHAR(100) NOT NULL,
	LeaveStartDate DATE NOT NULL,
	LeaveType VARCHAR(100) NOT NULL,
	EmployeeID INT NOT NULL,
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

CREATE TABLE EmployeeHoliday(
	EmployeeHolidayID INT PRIMARY KEY,
	HolidayID INT NOT NULL,
	EmployeeID INT NOT NULL,
	FOREIGN KEY (HolidayID) REFERENCES Holiday(HolidayID),
	FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);



