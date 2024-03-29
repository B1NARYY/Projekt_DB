USE [master]
GO
/****** Object:  Database [holy2]    Script Date: 10/03/2024 17:41:57 ******/
CREATE DATABASE [holy2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'holy2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\holy2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'holy2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS2019\MSSQL\DATA\holy2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [holy2] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [holy2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [holy2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [holy2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [holy2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [holy2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [holy2] SET ARITHABORT OFF 
GO
ALTER DATABASE [holy2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [holy2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [holy2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [holy2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [holy2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [holy2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [holy2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [holy2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [holy2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [holy2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [holy2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [holy2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [holy2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [holy2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [holy2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [holy2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [holy2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [holy2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [holy2] SET  MULTI_USER 
GO
ALTER DATABASE [holy2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [holy2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [holy2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [holy2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [holy2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [holy2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [holy2] SET QUERY_STORE = OFF
GO
USE [holy2]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/03/2024 17:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[email] [varchar](100) NULL,
	[phone_number] [varchar](20) NULL,
	[address] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Items]    Script Date: 10/03/2024 17:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Items](
	[order_item_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[product_id] [int] NULL,
	[quantity] [int] NULL,
	[total_price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[order_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/03/2024 17:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NULL,
	[order_date] [datetime] NULL,
	[order_status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 10/03/2024 17:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NULL,
	[price] [float] NULL,
	[availability] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shipping_Details]    Script Date: 10/03/2024 17:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipping_Details](
	[shipping_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[shipping_address] [varchar](255) NULL,
	[shipping_method] [varchar](100) NULL,
	[delivery_status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[shipping_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (1, N'Jan Novak', N'jan.novak@gmail.com', N'123456789', N'Hlavni 123')
INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (2, N'Petr Svoboda', N'petr.svoboda@gmail.com', N'987654321', N'Druha 456')
INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (3, N'Jana Prochazka', N'jana.prochazka@gmail.com', N'555555555', N'Treti 789')
INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (4, N'Marie Dvorak', N'marie.dvorak@gmail.com', N'999888777', N'Ctvrti 321')
INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (5, N'Pavel Benes', N'pavel.benes@gmail.com', N'444333222', N'Pata 654')
INSERT [dbo].[Customers] ([customer_id], [name], [email], [phone_number], [address]) VALUES (6, N'Petr', N'petr@com', N'69696969', N'Praha')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_Items] ON 

INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [product_id], [quantity], [total_price]) VALUES (3, 2, 3, 3, 29.97)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [product_id], [quantity], [total_price]) VALUES (4, 3, 4, 1, 39.99)
INSERT [dbo].[Order_Items] ([order_item_id], [order_id], [product_id], [quantity], [total_price]) VALUES (5, 4, 5, 2, 29.98)
SET IDENTITY_INSERT [dbo].[Order_Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([order_id], [customer_id], [order_date], [order_status]) VALUES (1, 1, CAST(N'2024-03-09T08:00:00.000' AS DateTime), N'Čeká na zpracování')
INSERT [dbo].[Orders] ([order_id], [customer_id], [order_date], [order_status]) VALUES (2, 2, CAST(N'2024-03-09T09:00:00.000' AS DateTime), N'Odesláno')
INSERT [dbo].[Orders] ([order_id], [customer_id], [order_date], [order_status]) VALUES (3, 3, CAST(N'2024-03-10T10:00:00.000' AS DateTime), N'Čeká na zpracování')
INSERT [dbo].[Orders] ([order_id], [customer_id], [order_date], [order_status]) VALUES (4, 4, CAST(N'2024-03-10T11:00:00.000' AS DateTime), N'Odesláno')
INSERT [dbo].[Orders] ([order_id], [customer_id], [order_date], [order_status]) VALUES (5, 5, CAST(N'2024-03-11T12:00:00.000' AS DateTime), N'Čeká na zpracování')
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([product_id], [name], [price], [availability]) VALUES (1, N'Produkt A', 19.99, 1)
INSERT [dbo].[Products] ([product_id], [name], [price], [availability]) VALUES (2, N'Produkt B', 29.99, 1)
INSERT [dbo].[Products] ([product_id], [name], [price], [availability]) VALUES (3, N'Produkt C', 9.99, 0)
INSERT [dbo].[Products] ([product_id], [name], [price], [availability]) VALUES (4, N'Produkt D', 39.99, 1)
INSERT [dbo].[Products] ([product_id], [name], [price], [availability]) VALUES (5, N'Produkt E', 14.99, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Shipping_Details] ON 

INSERT [dbo].[Shipping_Details] ([shipping_id], [order_id], [shipping_address], [shipping_method], [delivery_status]) VALUES (1, 1, N'Hlavní 123', N'Standardní', N'V doručení')
INSERT [dbo].[Shipping_Details] ([shipping_id], [order_id], [shipping_address], [shipping_method], [delivery_status]) VALUES (2, 2, N'Druhá 456', N'Expresní', N'Doručeno')
INSERT [dbo].[Shipping_Details] ([shipping_id], [order_id], [shipping_address], [shipping_method], [delivery_status]) VALUES (3, 3, N'Třetí 789', N'Standardní', N'V doručení')
INSERT [dbo].[Shipping_Details] ([shipping_id], [order_id], [shipping_address], [shipping_method], [delivery_status]) VALUES (4, 4, N'Čtvrtá 321', N'Expresní', N'Doručeno')
INSERT [dbo].[Shipping_Details] ([shipping_id], [order_id], [shipping_address], [shipping_method], [delivery_status]) VALUES (5, 5, N'Pátá 654', N'Standardní', N'V doručení')
SET IDENTITY_INSERT [dbo].[Shipping_Details] OFF
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([order_id])
GO
ALTER TABLE [dbo].[Order_Items]  WITH CHECK ADD FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([product_id])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([customer_id])
REFERENCES [dbo].[Customers] ([customer_id])
GO
ALTER TABLE [dbo].[Shipping_Details]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[Orders] ([order_id])
GO
USE [master]
GO
ALTER DATABASE [holy2] SET  READ_WRITE 
GO
