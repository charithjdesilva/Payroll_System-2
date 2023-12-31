USE [master]
GO
/****** Object:  Database [GryfindoSystemV2]    Script Date: 19-07-2023 01:31:12 ******/
CREATE DATABASE [GryfindoSystemV2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GryfindoSystemV2', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GryfindoSystemV2.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GryfindoSystemV2_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GryfindoSystemV2_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GryfindoSystemV2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GryfindoSystemV2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GryfindoSystemV2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET ARITHABORT OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GryfindoSystemV2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GryfindoSystemV2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GryfindoSystemV2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GryfindoSystemV2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GryfindoSystemV2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GryfindoSystemV2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GryfindoSystemV2] SET  MULTI_USER 
GO
ALTER DATABASE [GryfindoSystemV2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GryfindoSystemV2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GryfindoSystemV2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GryfindoSystemV2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GryfindoSystemV2]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] NOT NULL,
	[FacultyID] [int] NOT NULL,
	[DepartmentStartedDate] [date] NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmpDependent]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[EmpDependent](
	[DependentID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Dep_Name] [varchar](100) NOT NULL,
	[Dep_dob] [date] NOT NULL,
	[Dep_gender] [varchar](6) NOT NULL,
	[Dep_phone] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DependentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] NOT NULL,
	[Emp_name] [varchar](100) NOT NULL,
	[Emp_dob] [date] NOT NULL,
	[Emp_gender] [varchar](6) NOT NULL,
	[Emp_phone] [varchar](10) NOT NULL,
	[Emp_address] [varchar](200) NOT NULL,
	[monthlySalary] [decimal](14, 2) NULL,
	[otRates_hourly] [decimal](10, 2) NULL,
	[allowances] [decimal](14, 2) NULL,
	[DepartmentID] [int] NOT NULL,
	[username] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeHoliday]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeHoliday](
	[EmployeeHolidayID] [int] NOT NULL,
	[HolidayID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeHolidayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Faculty]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Faculty](
	[FacultyID] [int] NOT NULL,
	[FacultyStartedDate] [date] NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FacultyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Holiday]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Holiday](
	[HolidayID] [int] NOT NULL,
	[No_of_days] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[HolidayStartDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HolidayID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Leave]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Leave](
	[LeaveID] [int] NOT NULL,
	[No_of_days] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[LeaveStartDate] [date] NOT NULL,
	[LeaveType] [varchar](100) NOT NULL,
	[EmployeeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LeaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[SalaryID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[BasePay] [decimal](14, 2) NULL,
	[NoPay] [decimal](14, 2) NULL,
	[GrossPay] [decimal](14, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[SalaryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Settings]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Settings](
	[salCycleBeginDate] [date] NOT NULL,
	[salCycleEndDate] [date] NOT NULL,
	[dateRange] [int] NOT NULL,
	[noOfLeaves] [decimal](3, 0) NOT NULL,
	[username] [varchar](20) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SysAdmin]    Script Date: 19-07-2023 01:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SysAdmin](
	[username] [varchar](20) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[password] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (1, 1, CAST(0x90400B00 AS Date), N'Mechanical Engineering')
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (2, 1, CAST(0x90400B00 AS Date), N'Electrical Engineering')
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (3, 2, CAST(0x47420B00 AS Date), N'Marketing')
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (4, 2, CAST(0x47420B00 AS Date), N'Finance')
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (5, 3, CAST(0xC33F0B00 AS Date), N'Painting')
INSERT [dbo].[Department] ([DepartmentID], [FacultyID], [DepartmentStartedDate], [Name]) VALUES (6, 3, CAST(0xC33F0B00 AS Date), N'Sculpture')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (1, 1001, N'Sarah Smith', CAST(0xA31D0B00 AS Date), N'Female', N'0712345678')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (2, 1001, N'Tom Smith', CAST(0x80210B00 AS Date), N'Male', N'0712345678')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (3, 1002, N'Emily Doe', CAST(0xB61C0B00 AS Date), N'Female', N'0776543210')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (4, 1003, N'Alex Johnson', CAST(0x2A240B00 AS Date), N'Male', N'0769876543')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (5, 1001, N'Chloe Smith', CAST(0x502D0B00 AS Date), N'Female', N'0714547566')
INSERT [dbo].[EmpDependent] ([DependentID], [EmployeeID], [Dep_Name], [Dep_dob], [Dep_gender], [Dep_phone]) VALUES (6, 1001, N'Sonya Smith', CAST(0x41270B00 AS Date), N'Female', N'0766527856')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1001, N'Kamal Fernando', CAST(0x46160B00 AS Date), N'Male', N'0712345678', N'No. 123, Main Street', CAST(50000.00 AS Decimal(14, 2)), CAST(1000.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(14, 2)), 1, N'admin1')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1002, N'Nuwan jayasinghe', CAST(0x86190B00 AS Date), N'Female', N'0776543210', N'No. 456, Park Avenue', CAST(60000.00 AS Decimal(14, 2)), CAST(1200.00 AS Decimal(10, 2)), CAST(6000.00 AS Decimal(14, 2)), 2, N'admin2')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1003, N'Ruwan Perera', CAST(0xEC0E0B00 AS Date), N'Male', N'0769876543', N'No. 789, Elm Street', CAST(70000.00 AS Decimal(14, 2)), CAST(1400.00 AS Decimal(10, 2)), CAST(7000.00 AS Decimal(14, 2)), 3, N'admin3')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1004, N'Ananda Silva', CAST(0x7B180B00 AS Date), N'Male', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(80000.00 AS Decimal(14, 2)), CAST(1600.00 AS Decimal(10, 2)), CAST(8000.00 AS Decimal(14, 2)), 4, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1005, N'Kamala Rajapaksa', CAST(0x86130B00 AS Date), N'Female', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(90000.00 AS Decimal(14, 2)), CAST(1800.00 AS Decimal(10, 2)), CAST(9000.00 AS Decimal(14, 2)), 5, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1006, N'Priyantha Jayasena', CAST(0x381A0B00 AS Date), N'Male', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(55000.00 AS Decimal(14, 2)), CAST(1100.00 AS Decimal(10, 2)), CAST(5500.00 AS Decimal(14, 2)), 1, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1007, N'Lakshmi Gunaratne', CAST(0xAF1D0B00 AS Date), N'Female', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(65000.00 AS Decimal(14, 2)), CAST(1300.00 AS Decimal(10, 2)), CAST(6500.00 AS Decimal(14, 2)), 2, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1008, N'Sarath Perera', CAST(0x64110B00 AS Date), N'Male', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(75000.00 AS Decimal(14, 2)), CAST(1500.00 AS Decimal(10, 2)), CAST(7500.00 AS Decimal(14, 2)), 3, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1009, N'Malini Silva', CAST(0x7C1C0B00 AS Date), N'Female', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(85000.00 AS Decimal(14, 2)), CAST(1700.00 AS Decimal(10, 2)), CAST(8500.00 AS Decimal(14, 2)), 4, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1010, N'Ranjith Jayawardena', CAST(0x35160B00 AS Date), N'Male', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(95000.00 AS Decimal(14, 2)), CAST(1900.00 AS Decimal(10, 2)), CAST(9500.00 AS Decimal(14, 2)), 5, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1011, N'Kanthi Rajapaksa', CAST(0x7C110B00 AS Date), N'Female', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(52000.00 AS Decimal(14, 2)), CAST(1040.00 AS Decimal(10, 2)), CAST(5200.00 AS Decimal(14, 2)), 1, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1012, N'Jayasiri Silva', CAST(0xAB1A0B00 AS Date), N'Male', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(62000.00 AS Decimal(14, 2)), CAST(1240.00 AS Decimal(10, 2)), CAST(6200.00 AS Decimal(14, 2)), 2, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1013, N'Priyani Gunaratne', CAST(0x29140B00 AS Date), N'Female', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(72000.00 AS Decimal(14, 2)), CAST(1440.00 AS Decimal(10, 2)), CAST(7200.00 AS Decimal(14, 2)), 3, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1014, N'Dinesh Perera', CAST(0x13190B00 AS Date), N'Male', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(82000.00 AS Decimal(14, 2)), CAST(1640.00 AS Decimal(10, 2)), CAST(8200.00 AS Decimal(14, 2)), 4, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1015, N'Anusha Jayasena', CAST(0x4F150B00 AS Date), N'Female', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(92000.00 AS Decimal(14, 2)), CAST(1840.00 AS Decimal(10, 2)), CAST(9200.00 AS Decimal(14, 2)), 5, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1016, N'Nimal Fernando', CAST(0xC11B0B00 AS Date), N'Male', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(57000.00 AS Decimal(14, 2)), CAST(1140.00 AS Decimal(10, 2)), CAST(5700.00 AS Decimal(14, 2)), 1, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1017, N'Kumari Perera', CAST(0x3D1F0B00 AS Date), N'Female', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(67000.00 AS Decimal(14, 2)), CAST(1340.00 AS Decimal(10, 2)), CAST(6700.00 AS Decimal(14, 2)), 2, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1018, N'Saman Fernando', CAST(0x84110B00 AS Date), N'Male', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(77000.00 AS Decimal(14, 2)), CAST(1540.00 AS Decimal(10, 2)), CAST(7700.00 AS Decimal(14, 2)), 3, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1019, N'Nilmini Silva', CAST(0x8E1D0B00 AS Date), N'Female', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(87000.00 AS Decimal(14, 2)), CAST(1740.00 AS Decimal(10, 2)), CAST(8700.00 AS Decimal(14, 2)), 4, N'admin')
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances], [DepartmentID], [username]) VALUES (1020, N'Chaminda Jayawardena', CAST(0x84170B00 AS Date), N'Male', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(97000.00 AS Decimal(14, 2)), CAST(1940.00 AS Decimal(10, 2)), CAST(9700.00 AS Decimal(14, 2)), 5, N'admin')
INSERT [dbo].[EmployeeHoliday] ([EmployeeHolidayID], [HolidayID], [EmployeeID]) VALUES (1, 1, 1001)
INSERT [dbo].[EmployeeHoliday] ([EmployeeHolidayID], [HolidayID], [EmployeeID]) VALUES (2, 2, 1002)
INSERT [dbo].[EmployeeHoliday] ([EmployeeHolidayID], [HolidayID], [EmployeeID]) VALUES (3, 3, 1003)
INSERT [dbo].[Faculty] ([FacultyID], [FacultyStartedDate], [Name]) VALUES (1, CAST(0x90400B00 AS Date), N'Engineering')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyStartedDate], [Name]) VALUES (2, CAST(0x47420B00 AS Date), N'Business Administration')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyStartedDate], [Name]) VALUES (3, CAST(0xC33F0B00 AS Date), N'Fine Arts')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyStartedDate], [Name]) VALUES (4, CAST(0x28410B00 AS Date), N'Marketing')
INSERT [dbo].[Faculty] ([FacultyID], [FacultyStartedDate], [Name]) VALUES (5, CAST(0xE5430B00 AS Date), N'Research and Develepoment')
INSERT [dbo].[Holiday] ([HolidayID], [No_of_days], [Name], [HolidayStartDate]) VALUES (1, 3, N'New Year', CAST(0xD8440B00 AS Date))
INSERT [dbo].[Holiday] ([HolidayID], [No_of_days], [Name], [HolidayStartDate]) VALUES (2, 2, N'Christmas', CAST(0x3E460B00 AS Date))
INSERT [dbo].[Holiday] ([HolidayID], [No_of_days], [Name], [HolidayStartDate]) VALUES (3, 1, N'Easter', CAST(0x41450B00 AS Date))
INSERT [dbo].[Holiday] ([HolidayID], [No_of_days], [Name], [HolidayStartDate]) VALUES (4, 1, N'Independence Day', CAST(0xFA440B00 AS Date))
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (1, 10, N'Sick Leave', CAST(0xE1440B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (2, 1, N'Vacation with the family', CAST(0x82450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (3, 3, N'Family medical emergency Leave', CAST(0xCF450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (4, 3, N'Sick Leave', CAST(0x0F450B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (5, 1, N'Vacation', CAST(0x87450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (6, 2, N'Personal Leave', CAST(0x96450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (7, 2, N'Sick Leave', CAST(0x05450B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (8, 4, N'Vacation', CAST(0x91450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (9, 1, N'Personal Leave', CAST(0xD4450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (10, 3, N'Sick Leave', CAST(0x13450B00 AS Date), N'Sick', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (11, 1, N'Vacation', CAST(0xBA450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (12, 2, N'Personal Leave', CAST(0xD9450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (13, 1, N'Sick Leave', CAST(0x1C450B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (14, 3, N'Vacation', CAST(0xBF450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (15, 2, N'Personal Leave', CAST(0xE9450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (16, 2, N'Sick Leave', CAST(0x36450B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (17, 2, N'Vacation', CAST(0xCF450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (18, 1, N'Personal Leave', CAST(0xF2450B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (19, 1, N'Sick Leave', CAST(0x5E450B00 AS Date), N'Sick', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (20, 4, N'Vacation', CAST(0xD4450B00 AS Date), N'Vacation', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (21, 2, N'Personal Leave', CAST(0x0C460B00 AS Date), N'Personal', 1003)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (22, 2, N'Sick Leave', CAST(0x78450B00 AS Date), N'Medical Leave', 1001)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (23, 3, N'Vacation', CAST(0x82450B00 AS Date), N'Personal Leave', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (24, 1, N'Alms giving at the home', CAST(0xFB440B00 AS Date), N'Personal Leave', 1002)
INSERT [dbo].[Leave] ([LeaveID], [No_of_days], [Name], [LeaveStartDate], [LeaveType], [EmployeeID]) VALUES (25, 2, N'asfas', CAST(0xDA440B00 AS Date), N'Personal Leave', 1004)
INSERT [dbo].[Salary] ([SalaryID], [EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (1, 1001, CAST(45000.00 AS Decimal(14, 2)), CAST(0.00 AS Decimal(14, 2)), CAST(45000.00 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([SalaryID], [EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (2, 1002, CAST(55000.00 AS Decimal(14, 2)), CAST(1000.00 AS Decimal(14, 2)), CAST(54000.00 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([SalaryID], [EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (3, 1003, CAST(65000.00 AS Decimal(14, 2)), CAST(2000.00 AS Decimal(14, 2)), CAST(63000.00 AS Decimal(14, 2)))
INSERT [dbo].[Settings] ([salCycleBeginDate], [salCycleEndDate], [dateRange], [noOfLeaves], [username]) VALUES (CAST(0xD8440B00 AS Date), CAST(0xF6440B00 AS Date), 31, CAST(5 AS Decimal(3, 0)), N'admin')
INSERT [dbo].[SysAdmin] ([username], [name], [password]) VALUES (N'admin', N'System Administrator', N'12345678')
INSERT [dbo].[SysAdmin] ([username], [name], [password]) VALUES (N'admin1', N'John Doe', N'password1')
INSERT [dbo].[SysAdmin] ([username], [name], [password]) VALUES (N'admin2', N'Jane Smith', N'password2')
INSERT [dbo].[SysAdmin] ([username], [name], [password]) VALUES (N'admin3', N'Mike Johnson', N'password3')
ALTER TABLE [dbo].[Department]  WITH CHECK ADD FOREIGN KEY([FacultyID])
REFERENCES [dbo].[Faculty] ([FacultyID])
GO
ALTER TABLE [dbo].[EmpDependent]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DepartmentID])
REFERENCES [dbo].[Department] ([DepartmentID])
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[SysAdmin] ([username])
GO
ALTER TABLE [dbo].[EmployeeHoliday]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[EmployeeHoliday]  WITH CHECK ADD FOREIGN KEY([HolidayID])
REFERENCES [dbo].[Holiday] ([HolidayID])
GO
ALTER TABLE [dbo].[Leave]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Salary]  WITH CHECK ADD FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([EmployeeID])
GO
ALTER TABLE [dbo].[Settings]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[SysAdmin] ([username])
GO
ALTER TABLE [dbo].[EmpDependent]  WITH CHECK ADD  CONSTRAINT [genderCheckDep] CHECK  (([Dep_gender]='Female' OR [Dep_gender]='Male'))
GO
ALTER TABLE [dbo].[EmpDependent] CHECK CONSTRAINT [genderCheckDep]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [genderCheck] CHECK  (([Emp_gender]='Female' OR [Emp_gender]='Male'))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [genderCheck]
GO
USE [master]
GO
ALTER DATABASE [GryfindoSystemV2] SET  READ_WRITE 
GO
