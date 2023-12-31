USE [master]
GO
/****** Object:  Database [GrifindoToys]    Script Date: 13-07-2023 21:46:16 ******/
CREATE DATABASE [GrifindoToys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GrifindoToys', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GrifindoToys.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GrifindoToys_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GrifindoToys_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GrifindoToys] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GrifindoToys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GrifindoToys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GrifindoToys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GrifindoToys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GrifindoToys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GrifindoToys] SET ARITHABORT OFF 
GO
ALTER DATABASE [GrifindoToys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GrifindoToys] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GrifindoToys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GrifindoToys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GrifindoToys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GrifindoToys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GrifindoToys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GrifindoToys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GrifindoToys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GrifindoToys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GrifindoToys] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GrifindoToys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GrifindoToys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GrifindoToys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GrifindoToys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GrifindoToys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GrifindoToys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GrifindoToys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GrifindoToys] SET RECOVERY FULL 
GO
ALTER DATABASE [GrifindoToys] SET  MULTI_USER 
GO
ALTER DATABASE [GrifindoToys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GrifindoToys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GrifindoToys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GrifindoToys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [GrifindoToys]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 13-07-2023 21:46:16 ******/
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
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 13-07-2023 21:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[EmployeeID] [int] NOT NULL,
	[BasePay] [decimal](14, 2) NULL,
	[NoPay] [decimal](14, 2) NULL,
	[GrossPay] [decimal](14, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Settings]    Script Date: 13-07-2023 21:46:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Settings](
	[dateRange] [decimal](2, 0) NOT NULL,
	[salCycleBeginDate] [date] NOT NULL,
	[salCycleEndDate] [date] NOT NULL,
	[noOfLeaves] [decimal](3, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SysAdmin]    Script Date: 13-07-2023 21:46:16 ******/
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
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1001, N'Kamal Fernando', CAST(0x46160B00 AS Date), N'Male', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(50000.00 AS Decimal(14, 2)), CAST(1000.00 AS Decimal(10, 2)), CAST(5000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1002, N'Sunil Perera', CAST(0x86190B00 AS Date), N'Male', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(60000.00 AS Decimal(14, 2)), CAST(1200.00 AS Decimal(10, 2)), CAST(6000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1003, N'Kumari Jayawardena', CAST(0xEC0E0B00 AS Date), N'Female', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(70000.00 AS Decimal(14, 2)), CAST(1400.00 AS Decimal(10, 2)), CAST(7000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1004, N'Ananda Silva', CAST(0x7B180B00 AS Date), N'Male', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(80000.00 AS Decimal(14, 2)), CAST(1600.00 AS Decimal(10, 2)), CAST(8000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1005, N'Kamala Rajapaksa', CAST(0x86130B00 AS Date), N'Female', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(90000.00 AS Decimal(14, 2)), CAST(1800.00 AS Decimal(10, 2)), CAST(9000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1006, N'Priyantha Jayasena', CAST(0x381A0B00 AS Date), N'Male', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(55000.00 AS Decimal(14, 2)), CAST(1100.00 AS Decimal(10, 2)), CAST(5500.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1007, N'Lakshmi Gunaratne', CAST(0xAF1D0B00 AS Date), N'Female', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(65000.00 AS Decimal(14, 2)), CAST(1300.00 AS Decimal(10, 2)), CAST(6500.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1008, N'Sarath Perera', CAST(0x64110B00 AS Date), N'Male', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(75000.00 AS Decimal(14, 2)), CAST(1500.00 AS Decimal(10, 2)), CAST(7500.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1009, N'Malini Silva', CAST(0x7C1C0B00 AS Date), N'Female', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(85000.00 AS Decimal(14, 2)), CAST(1700.00 AS Decimal(10, 2)), CAST(8500.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1010, N'Ranjith Jayawardena', CAST(0x35160B00 AS Date), N'Male', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(95000.00 AS Decimal(14, 2)), CAST(1900.00 AS Decimal(10, 2)), CAST(9500.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1011, N'Kanthi Rajapaksa', CAST(0x7C110B00 AS Date), N'Female', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(52000.00 AS Decimal(14, 2)), CAST(1040.00 AS Decimal(10, 2)), CAST(5200.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1012, N'Jayasiri Silva', CAST(0xAB1A0B00 AS Date), N'Male', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(62000.00 AS Decimal(14, 2)), CAST(1240.00 AS Decimal(10, 2)), CAST(6200.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1013, N'Priyani Gunaratne', CAST(0x29140B00 AS Date), N'Female', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(72000.00 AS Decimal(14, 2)), CAST(1440.00 AS Decimal(10, 2)), CAST(7200.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1014, N'Dinesh Perera', CAST(0x13190B00 AS Date), N'Male', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(82000.00 AS Decimal(14, 2)), CAST(1640.00 AS Decimal(10, 2)), CAST(8200.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1015, N'Anusha Jayasena', CAST(0x4F150B00 AS Date), N'Female', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(92000.00 AS Decimal(14, 2)), CAST(1840.00 AS Decimal(10, 2)), CAST(9200.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1016, N'Nimal Fernando', CAST(0xC11B0B00 AS Date), N'Male', N'0712345678', N'No. 123, Galle Road, Colombo', CAST(57000.00 AS Decimal(14, 2)), CAST(1140.00 AS Decimal(10, 2)), CAST(5700.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1017, N'Kumari Perera', CAST(0x3D1F0B00 AS Date), N'Female', N'0776543210', N'No. 456, Kandy Road, Gampaha', CAST(67000.00 AS Decimal(14, 2)), CAST(1340.00 AS Decimal(10, 2)), CAST(6700.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1018, N'Saman Fernando', CAST(0x84110B00 AS Date), N'Male', N'0769876543', N'No. 789, Negombo Road, Negombo', CAST(77000.00 AS Decimal(14, 2)), CAST(1540.00 AS Decimal(10, 2)), CAST(7700.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1019, N'Nilmini Silva', CAST(0x8E1D0B00 AS Date), N'Female', N'0723456789', N'No. 321, Galle Road, Moratuwa', CAST(87000.00 AS Decimal(14, 2)), CAST(1740.00 AS Decimal(10, 2)), CAST(8700.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1020, N'Chaminda Jayawardena', CAST(0x84170B00 AS Date), N'Male', N'0787654321', N'No. 654, Kandy Road, Kurunegala', CAST(97000.00 AS Decimal(14, 2)), CAST(1940.00 AS Decimal(10, 2)), CAST(9700.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1021, N'Samantha Bradda', CAST(0x98450B00 AS Date), N'Male', N'0747523666', N'No. 124, Nil Katarolu,
Umandawa', CAST(100000.00 AS Decimal(14, 2)), CAST(2000.00 AS Decimal(10, 2)), CAST(16000.00 AS Decimal(14, 2)))
INSERT [dbo].[Employee] ([EmployeeID], [Emp_name], [Emp_dob], [Emp_gender], [Emp_phone], [Emp_address], [monthlySalary], [otRates_hourly], [allowances]) VALUES (1022, N'Santhi Rajapaksha', CAST(0xCD1E0B00 AS Date), N'Female', N'0745235512', N'No.135,
Colombo 07', CAST(80000.00 AS Decimal(14, 2)), CAST(1500.00 AS Decimal(10, 2)), CAST(6000.00 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (1003, CAST(91000.00 AS Decimal(14, 2)), CAST(9032.26 AS Decimal(14, 2)), CAST(54667.74 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (1007, CAST(84500.00 AS Decimal(14, 2)), CAST(6290.32 AS Decimal(14, 2)), CAST(52859.68 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (1009, CAST(119000.00 AS Decimal(14, 2)), CAST(16451.61 AS Decimal(14, 2)), CAST(66848.39 AS Decimal(14, 2)))
INSERT [dbo].[Salary] ([EmployeeID], [BasePay], [NoPay], [GrossPay]) VALUES (1011, CAST(71760.00 AS Decimal(14, 2)), CAST(6709.68 AS Decimal(14, 2)), CAST(43522.32 AS Decimal(14, 2)))
INSERT [dbo].[Settings] ([dateRange], [salCycleBeginDate], [salCycleEndDate], [noOfLeaves]) VALUES (CAST(31 AS Decimal(2, 0)), CAST(0x8D450B00 AS Date), CAST(0xAB450B00 AS Date), CAST(8 AS Decimal(3, 0)))
INSERT [dbo].[SysAdmin] ([username], [name], [password]) VALUES (N'admin', N'System Administrator', N'12345678')
USE [master]
GO
ALTER DATABASE [GrifindoToys] SET  READ_WRITE 
GO
