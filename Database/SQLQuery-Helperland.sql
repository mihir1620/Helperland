USE [master]
GO
/****** Object:  Database [Helperland]    Script Date: 30-03-2022 14:09:05 ******/
CREATE DATABASE [Helperland]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Helperland', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Helperland.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Helperland_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Helperland_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Helperland].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Helperland] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Helperland] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Helperland] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Helperland] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Helperland] SET ARITHABORT OFF 
GO
ALTER DATABASE [Helperland] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Helperland] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Helperland] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Helperland] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Helperland] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Helperland] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Helperland] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Helperland] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Helperland] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Helperland] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Helperland] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Helperland] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Helperland] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Helperland] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Helperland] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Helperland] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Helperland] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Helperland] SET RECOVERY FULL 
GO
ALTER DATABASE [Helperland] SET  MULTI_USER 
GO
ALTER DATABASE [Helperland] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Helperland] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Helperland] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Helperland] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Helperland] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Helperland', N'ON'
GO
ALTER DATABASE [Helperland] SET QUERY_STORE = OFF
GO
USE [Helperland]
GO
/****** Object:  Table [dbo].[City]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NOT NULL,
	[StateId] [int] NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[ContactUsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](200) NOT NULL,
	[Subject] [nvarchar](500) NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[UploadFileName] [nvarchar](100) NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[FileName] [varchar](500) NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[ContactUsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FavoriteAndBlocked]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FavoriteAndBlocked](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[TargetUserId] [int] NOT NULL,
	[IsFavorite] [bit] NOT NULL,
	[IsBlocked] [bit] NOT NULL,
 CONSTRAINT [PK_FavoriteAndBlocked] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceRequestId] [int] NOT NULL,
	[RatingFrom] [int] NOT NULL,
	[RatingTo] [int] NOT NULL,
	[Ratings] [decimal](2, 1) NOT NULL,
	[Comments] [nvarchar](2000) NULL,
	[RatingDate] [datetime] NOT NULL,
	[OnTimeArrival] [decimal](2, 1) NOT NULL,
	[Friendly] [decimal](2, 1) NOT NULL,
	[QualityOfService] [decimal](2, 1) NOT NULL,
 CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED 
(
	[RatingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceRequest]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceRequest](
	[ServiceRequestId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[ServiceId] [int] NOT NULL,
	[ServiceStartDate] [datetime] NOT NULL,
	[ZipCode] [nvarchar](10) NOT NULL,
	[ServiceHourlyRate] [decimal](8, 2) NULL,
	[ServiceHours] [float] NOT NULL,
	[ExtraHours] [float] NULL,
	[SubTotal] [decimal](8, 2) NOT NULL,
	[Discount] [decimal](8, 2) NULL,
	[TotalCost] [decimal](8, 2) NOT NULL,
	[Comments] [nvarchar](500) NULL,
	[PaymentTransactionRefNo] [nvarchar](50) NULL,
	[PaymentDue] [bit] NOT NULL,
	[ServiceProviderId] [int] NULL,
	[SPAcceptedDate] [datetime] NULL,
	[HasPets] [bit] NOT NULL,
	[Status] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NULL,
	[RefundedAmount] [decimal](8, 2) NULL,
	[Distance] [decimal](18, 2) NOT NULL,
	[HasIssue] [bit] NULL,
	[PaymentDone] [bit] NULL,
	[RecordVersion] [uniqueidentifier] NULL,
 CONSTRAINT [PK_ServiceRequest] PRIMARY KEY CLUSTERED 
(
	[ServiceRequestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceRequestAddress]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceRequestAddress](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceRequestId] [int] NULL,
	[AddressLine1] [nvarchar](200) NULL,
	[AddressLine2] [nvarchar](200) NULL,
	[City] [nvarchar](50) NULL,
	[State] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](20) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_ServiceRequestAddress] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceRequestExtra]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceRequestExtra](
	[ServiceRequestExtraId] [int] IDENTITY(1,1) NOT NULL,
	[ServiceRequestId] [int] NOT NULL,
	[ServiceExtraId] [int] NOT NULL,
 CONSTRAINT [PK_ServiceRequestExtra] PRIMARY KEY CLUSTERED 
(
	[ServiceRequestExtraId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Test]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Test](
	[TestId] [int] NOT NULL,
	[TestName] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NULL,
	[Mobile] [nvarchar](20) NOT NULL,
	[UserTypeId] [int] NOT NULL,
	[Gender] [int] NULL,
	[DateOfBirth] [datetime] NULL,
	[UserProfilePicture] [nvarchar](200) NULL,
	[IsRegisteredUser] [bit] NOT NULL,
	[PaymentGatewayUserRef] [nvarchar](200) NULL,
	[ZipCode] [nvarchar](20) NULL,
	[WorksWithPets] [bit] NOT NULL,
	[LanguageId] [int] NULL,
	[NationalityId] [int] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[IsApproved] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Status] [int] NULL,
	[BankTokenId] [nvarchar](100) NULL,
	[TaxNo] [nvarchar](50) NULL,
	[ReserPasswordLink] [nchar](100) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAddress]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAddress](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[AddressLine1] [nvarchar](200) NOT NULL,
	[AddressLine2] [nvarchar](200) NULL,
	[City] [nvarchar](50) NOT NULL,
	[State] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](20) NOT NULL,
	[IsDefault] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[Mobile] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK_UserAddresses] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zipcode]    Script Date: 30-03-2022 14:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zipcode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ZipcodeValue] [nvarchar](50) NOT NULL,
	[CityId] [int] NOT NULL,
 CONSTRAINT [PK_Zipcode] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([Id], [CityName], [StateId]) VALUES (1, N'Ahmedabad', 1)
INSERT [dbo].[City] ([Id], [CityName], [StateId]) VALUES (2, N'Bhavnagar', 1)
INSERT [dbo].[City] ([Id], [CityName], [StateId]) VALUES (3, N'Surat', 1)
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[ContactUs] ON 

INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (11, N'Success', N'mihirrathod1678@gmail.com', N'Contact', N'1234567890', N'Hello', NULL, CAST(N'2022-01-28T18:35:39.717' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (12, N'Deven', N'test@gmail.com', N'Contact', N'8974563214', N'Last name', NULL, CAST(N'2022-01-28T18:43:38.400' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (13, N'Test', N'mihirrathod1678@gmail.com', N'Service', N'7856212345', N'sssssssssss', NULL, CAST(N'2022-01-28T18:48:23.610' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (14, N'Mihir', N'mihirrathod1612@gmail.com', N'Contact', N'6354285051', N'Query regarding Contact us page', NULL, CAST(N'2022-01-29T11:40:01.997' AS DateTime), NULL, N'f95630a2-d699-49e1-adf6-afb24cbaa1eb_book.txt')
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (15, N'Test', N'mihirrathod1678@gmail.com', N'Service', N'7856212345', N'hhhhhhhhhhh', NULL, CAST(N'2022-01-29T12:03:09.020' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (16, N'Test', N'mihirrathod1678@gmail.com', N'Service', N'7856212345', N'yyyyyyyyyyyyyyyyyyyyy', NULL, CAST(N'2022-01-29T12:12:56.697' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (17, N'FinalTest', N'final@gmail.com', N'Service', N'1111111', N'Hello', NULL, CAST(N'2022-01-29T16:35:57.333' AS DateTime), NULL, N'29c95fa6-c077-4ad2-96fb-dc247a50f440_book.txt')
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (18, N'TestRest', N'mihirrathod1678@gmail.com', NULL, N'7856212345', N'j', NULL, CAST(N'2022-01-30T09:40:44.077' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (19, N'TestRest', N'mihirrathod1678@gmail.com', N'Contact', N'7856212345', N'hello', NULL, CAST(N'2022-01-31T16:57:54.577' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (20, N'HelloTHis', N'mihirrathod1612@gmail.com', N'Contact', N'7894561230', N'zzzzz', NULL, CAST(N'2022-01-31T18:03:47.840' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (21, N'MihirRathod', N'mr@gmail.com', N'Inquiry', N'1234567890', N'Inquiry', NULL, CAST(N'2022-02-01T09:50:10.647' AS DateTime), NULL, N'1bab1fe2-f280-4f4e-a0af-291ff85d375d_scaffold.txt')
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (22, N'TestRest', N'mihirrathod1678@gmail.com', NULL, N'7856212345', N'Hello', NULL, CAST(N'2022-02-01T11:13:32.430' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (23, N'TestRest', N'mihirrathod1678@gmail.com', NULL, N'7856212345', N'f', NULL, CAST(N'2022-02-01T11:15:55.293' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (24, N'MihirRathod', N'mihirrathod1612@gmail.com', N'Service', N'6354285051', N'Hello', NULL, CAST(N'2022-02-01T12:07:18.897' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (25, N'MihirRathod', N'mihirrathod1612@gmail.com', N'Inquiry', N'6354285051', N'Hello', NULL, CAST(N'2022-02-01T19:19:31.673' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (26, N'FinalTest', N'final@gmail.com', N'Contact', N'1111111111', N'Inquiry2', NULL, CAST(N'2022-02-02T09:31:27.967' AS DateTime), NULL, N'd4bbcc85-2257-4491-85ab-aa318a72d6ed_favicon_img.png')
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (27, N'TestRest', N'mihirrathod1678@gmail.com', N'Contact', N'7856212345', N'8', NULL, CAST(N'2022-02-02T09:51:08.977' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (28, N'MihirRathod', N'mr@gmail.com', N'Inquiry', N'1234567890', N'Retest', NULL, CAST(N'2022-02-04T14:59:51.410' AS DateTime), NULL, N'9bb9f0f4-798a-467f-ac60-34a1018686f9_m.txt')
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (29, N'TestingEmailInContact', N'login@gmail.com', N'Contact', N'4567891320', N'Contact', NULL, CAST(N'2022-03-25T17:18:16.373' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (30, N'DavidHolk', N'login@gmail.com', N'Contact', N'8945632120', N'COntact', NULL, CAST(N'2022-03-25T17:24:20.667' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (31, N'NewInqury', N'test@gmail.com', N'Inquiry', N'8975642310', N'Inquiry', NULL, CAST(N'2022-03-25T17:26:37.127' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (32, N'LatestInquiry', N'login@gmail.com', N'Contact', N'7894561230', N'Message', NULL, CAST(N'2022-03-25T17:28:43.157' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (33, N'LoginLname', N'login@yopmail.com', N'Service', N'8945612317', N'Service', NULL, CAST(N'2022-03-25T17:35:52.247' AS DateTime), NULL, NULL)
INSERT [dbo].[ContactUs] ([ContactUsId], [Name], [Email], [Subject], [PhoneNumber], [Message], [UploadFileName], [CreatedOn], [CreatedBy], [FileName]) VALUES (34, N'ABCDEF', N'login@yopmail.com', N'Contact', N'7896541230', N'Login', NULL, CAST(N'2022-03-25T17:46:52.977' AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[ContactUs] OFF
GO
SET IDENTITY_INSERT [dbo].[FavoriteAndBlocked] ON 

INSERT [dbo].[FavoriteAndBlocked] ([Id], [UserId], [TargetUserId], [IsFavorite], [IsBlocked]) VALUES (1, 33, 28, 0, 1)
SET IDENTITY_INSERT [dbo].[FavoriteAndBlocked] OFF
GO
SET IDENTITY_INSERT [dbo].[Rating] ON 

INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (1, 97, 28, 33, CAST(4.0 AS Decimal(2, 1)), N'None', CAST(N'2022-03-15T10:49:52.517' AS DateTime), CAST(3.0 AS Decimal(2, 1)), CAST(4.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (2, 97, 28, 33, CAST(1.0 AS Decimal(2, 1)), N'101', CAST(N'2022-03-15T10:52:13.970' AS DateTime), CAST(1.0 AS Decimal(2, 1)), CAST(1.0 AS Decimal(2, 1)), CAST(1.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (6, 97, 28, 33, CAST(4.0 AS Decimal(2, 1)), N'148', CAST(N'2022-03-15T11:03:28.543' AS DateTime), CAST(3.0 AS Decimal(2, 1)), CAST(4.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (7, 148, 28, 33, CAST(0.0 AS Decimal(2, 1)), NULL, CAST(N'2022-03-15T17:57:26.997' AS DateTime), CAST(0.0 AS Decimal(2, 1)), CAST(0.0 AS Decimal(2, 1)), CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (9, 135, 28, 33, CAST(0.0 AS Decimal(2, 1)), NULL, CAST(N'2022-03-15T17:41:06.713' AS DateTime), CAST(0.0 AS Decimal(2, 1)), CAST(0.0 AS Decimal(2, 1)), CAST(0.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (10, 151, 28, 33, CAST(3.0 AS Decimal(2, 1)), N'151', CAST(N'2022-03-16T18:15:55.843' AS DateTime), CAST(4.0 AS Decimal(2, 1)), CAST(3.0 AS Decimal(2, 1)), CAST(4.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (13, 160, 28, 33, CAST(5.0 AS Decimal(2, 1)), N'160', CAST(N'2022-03-21T12:52:50.620' AS DateTime), CAST(5.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (22, 162, 28, 33, CAST(5.0 AS Decimal(2, 1)), N'5', CAST(N'2022-03-21T12:52:08.527' AS DateTime), CAST(5.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (33, 159, 28, 33, CAST(3.0 AS Decimal(2, 1)), N'159', CAST(N'2022-03-21T13:04:49.353' AS DateTime), CAST(3.0 AS Decimal(2, 1)), CAST(3.0 AS Decimal(2, 1)), CAST(3.0 AS Decimal(2, 1)))
INSERT [dbo].[Rating] ([RatingId], [ServiceRequestId], [RatingFrom], [RatingTo], [Ratings], [Comments], [RatingDate], [OnTimeArrival], [Friendly], [QualityOfService]) VALUES (34, 117, 28, 33, CAST(4.0 AS Decimal(2, 1)), N'117', CAST(N'2022-03-26T18:25:07.320' AS DateTime), CAST(3.0 AS Decimal(2, 1)), CAST(4.0 AS Decimal(2, 1)), CAST(5.0 AS Decimal(2, 1)))
SET IDENTITY_INSERT [dbo].[Rating] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceRequest] ON 

INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (51, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:11:18.497' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (52, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:11:18.580' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (53, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:11:59.093' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (54, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:12:49.323' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (55, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:13:00.947' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (56, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:23:29.403' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (57, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, 33, NULL, 1, NULL, CAST(N'2022-02-14T11:24:42.720' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (58, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, NULL, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:25:41.683' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (59, 15, 0, CAST(N'2022-02-19T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, NULL, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Q', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:25:46.650' AS DateTime), CAST(N'2022-02-19T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (60, 15, 0, CAST(N'2022-02-24T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 5, 4, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'Q', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:26:01.753' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (61, 15, 0, CAST(N'2022-02-17T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 5.5, 2, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'Q', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:26:34.073' AS DateTime), CAST(N'2022-02-17T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (62, 15, 0, CAST(N'2022-02-17T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 5.5, 1, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'Q', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:27:45.053' AS DateTime), CAST(N'2022-02-17T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (63, 15, 0, CAST(N'2022-02-14T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 6, 3, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(120.00 AS Decimal(8, 2)), N'3', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:29:23.273' AS DateTime), CAST(N'2022-02-14T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (64, 15, 0, CAST(N'2022-02-14T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 6, 3, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(120.00 AS Decimal(8, 2)), N'3', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:32:58.060' AS DateTime), CAST(N'2022-02-14T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (65, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 2, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'2', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:33:15.457' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (66, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'2', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:34:00.120' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (67, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(0.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'1.5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:34:12.757' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (68, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'1.5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:41:47.327' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (69, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'1.5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:42:20.477' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (70, 15, 0, CAST(N'2022-02-16T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'1.5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:42:20.477' AS DateTime), CAST(N'2022-02-16T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (71, 15, 0, CAST(N'2022-02-28T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'100 ₹', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T11:45:18.263' AS DateTime), CAST(N'2022-02-28T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (72, 15, 0, CAST(N'2022-02-28T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'100 ₹', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-14T14:16:21.337' AS DateTime), CAST(N'2022-02-28T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (73, 15, 0, CAST(N'2022-02-23T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'90', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-15T18:30:44.223' AS DateTime), CAST(N'2022-02-23T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (74, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:33:39.220' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (75, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:40:59.107' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (76, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:43:28.263' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (77, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:49:49.703' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (78, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:50:26.047' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (79, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:51:47.223' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (80, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:53:11.457' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (81, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:53:24.160' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (82, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:53:52.577' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (83, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T10:55:34.663' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (84, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:00:52.307' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (85, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:06:16.733' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (86, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:06:38.040' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (87, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:07:02.260' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (88, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:08:27.990' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (89, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:09:07.100' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (90, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:11:38.333' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (91, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:11:48.093' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (92, 15, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'NEW', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-16T11:12:08.840' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (93, 15, 0, CAST(N'2022-02-27T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 0.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(90.00 AS Decimal(8, 2)), N'85 ₹', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-18T12:31:44.617' AS DateTime), CAST(N'2022-02-27T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (97, 28, 0, CAST(N'2022-02-24T00:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 5, 1.5, CAST(100.00 AS Decimal(8, 2)), NULL, CAST(130.00 AS Decimal(8, 2)), N'New', NULL, 0, 33, NULL, 1, 0, CAST(N'2022-02-18T15:13:43.487' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (101, 28, 0, CAST(N'2022-02-23T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'100', NULL, 0, 33, CAST(N'2022-03-26T10:55:23.797' AS DateTime), 0, 1, CAST(N'2022-02-21T10:54:03.923' AS DateTime), CAST(N'2022-03-24T17:12:13.663' AS DateTime), 0, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (102, 28, 0, CAST(N'2022-02-24T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'None', NULL, 0, 19, CAST(N'2022-03-26T17:59:59.157' AS DateTime), 0, 1, CAST(N'2022-02-21T10:58:38.467' AS DateTime), CAST(N'2022-03-28T15:57:47.113' AS DateTime), 35, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (103, 28, 0, CAST(N'2022-04-01T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(110.00 AS Decimal(8, 2)), N'ABCD', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-21T12:18:23.900' AS DateTime), CAST(N'2022-02-25T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (104, 28, 0, CAST(N'2022-02-26T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), NULL, NULL, 0, NULL, NULL, 0, NULL, CAST(N'2022-02-25T18:49:39.060' AS DateTime), CAST(N'2022-02-26T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (105, 28, 0, CAST(N'2022-03-01T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 0, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'New Service', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-26T18:37:21.293' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (106, 28, 0, CAST(N'2022-03-31T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 2.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(130.00 AS Decimal(8, 2)), N'New Service', NULL, 0, 33, CAST(N'2022-03-24T09:29:17.357' AS DateTime), 1, 0, CAST(N'2022-02-26T18:38:28.310' AS DateTime), CAST(N'2022-03-26T18:18:14.077' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (117, 28, 0, CAST(N'2022-03-09T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 11.5, 1, CAST(230.00 AS Decimal(8, 2)), NULL, CAST(250.00 AS Decimal(8, 2)), N'aa', NULL, 0, 33, CAST(N'2022-03-26T10:33:21.253' AS DateTime), 0, 2, CAST(N'2022-02-28T10:48:52.237' AS DateTime), CAST(N'2022-03-26T18:20:44.620' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (120, 28, 0, CAST(N'2022-03-05T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 0.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(90.00 AS Decimal(8, 2)), N'4.5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-28T11:05:22.620' AS DateTime), CAST(N'2022-03-05T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (122, 28, 0, CAST(N'2022-02-24T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3.5, 0.5, CAST(70.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'4', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-28T11:31:28.723' AS DateTime), CAST(N'2022-02-24T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (124, 28, 0, CAST(N'2022-03-02T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'5', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T11:38:14.567' AS DateTime), CAST(N'2022-03-28T15:23:42.467' AS DateTime), 35, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (125, 28, 0, CAST(N'2022-04-10T14:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 2, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(120.00 AS Decimal(8, 2)), N'5', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-02-28T11:41:40.947' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (126, 28, 0, CAST(N'2022-03-02T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'5', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T14:45:47.660' AS DateTime), CAST(N'2022-03-02T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (127, 28, 0, CAST(N'2022-04-02T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'5', NULL, 0, 33, CAST(N'2022-03-24T09:22:23.190' AS DateTime), 1, 0, CAST(N'2022-02-28T14:47:36.207' AS DateTime), CAST(N'2022-03-26T18:18:17.490' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (128, 28, 0, CAST(N'2022-03-04T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'80₹', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T14:58:58.100' AS DateTime), CAST(N'2022-03-04T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (129, 28, 0, CAST(N'2022-03-09T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'70', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T15:02:57.110' AS DateTime), CAST(N'2022-03-09T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (130, 28, 0, CAST(N'2022-03-06T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'80₹', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T15:15:15.463' AS DateTime), CAST(N'2022-03-29T14:59:26.867' AS DateTime), 0, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (131, 28, 0, CAST(N'2022-03-10T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 10, 0.5, CAST(200.00 AS Decimal(8, 2)), NULL, CAST(210.00 AS Decimal(8, 2)), N'210₹', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T15:18:32.997' AS DateTime), CAST(N'2022-03-28T15:22:17.177' AS DateTime), 35, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (132, 28, 0, CAST(N'2022-03-23T12:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'3 and half', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-02-28T15:42:35.957' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (133, 28, 0, CAST(N'2022-03-24T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'pets', NULL, 0, 33, NULL, 0, 0, CAST(N'2022-02-28T15:54:46.140' AS DateTime), CAST(N'2022-03-10T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (134, 28, 0, CAST(N'2022-03-13T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'3.5', NULL, 0, 33, NULL, 1, 0, CAST(N'2022-02-28T15:58:01.940' AS DateTime), CAST(N'2022-03-13T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (135, 28, 0, CAST(N'2022-03-30T13:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'Maha Shivratri', NULL, 0, NULL, NULL, 1, 0, CAST(N'2022-03-01T09:24:08.833' AS DateTime), CAST(N'2022-03-01T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (136, 28, 0, CAST(N'2022-03-18T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N't', NULL, 0, NULL, NULL, 0, NULL, CAST(N'2022-03-01T09:33:14.083' AS DateTime), CAST(N'2022-03-18T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (141, 28, 0, CAST(N'2022-04-13T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N't3', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-03-01T09:35:20.833' AS DateTime), CAST(N'2022-03-21T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (142, 28, 0, CAST(N'2022-04-01T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'2', NULL, 0, 33, CAST(N'2022-03-26T10:54:32.133' AS DateTime), 0, 1, CAST(N'2022-03-01T09:40:58.787' AS DateTime), CAST(N'2022-03-03T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (143, 28, 0, CAST(N'2022-04-07T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N't3', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-03-01T09:47:32.040' AS DateTime), CAST(N'2022-04-07T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (144, 28, 0, CAST(N'2023-01-08T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'1', NULL, 0, 33, NULL, 0, 1, CAST(N'2022-03-01T09:56:59.250' AS DateTime), CAST(N'2022-03-28T16:28:52.667' AS DateTime), 35, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (145, 28, 0, CAST(N'2022-03-31T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'4', NULL, 0, NULL, NULL, 0, 2, CAST(N'2022-03-01T10:17:26.517' AS DateTime), CAST(N'2022-03-31T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (146, 28, 0, CAST(N'2022-03-24T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(60.00 AS Decimal(8, 2)), N'y', NULL, 0, 33, NULL, 1, 1, CAST(N'2022-03-01T10:20:38.900' AS DateTime), CAST(N'2022-03-30T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (147, 28, 0, CAST(N'2022-03-09T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'None', NULL, 0, 33, NULL, 1, 1, CAST(N'2022-03-01T10:24:47.150' AS DateTime), CAST(N'2022-03-23T17:48:25.427' AS DateTime), 0, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (148, 28, 0, CAST(N'2022-04-06T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(60.00 AS Decimal(8, 2)), N'modal', NULL, 0, 33, NULL, 0, 2, CAST(N'2022-03-01T10:36:11.640' AS DateTime), CAST(N'2022-04-06T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (149, 28, 0, CAST(N'2022-05-07T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 0.5, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(70.00 AS Decimal(8, 2)), N'1', NULL, 0, NULL, NULL, 1, 1, CAST(N'2022-03-01T10:51:16.533' AS DateTime), CAST(N'2022-03-28T15:39:28.607' AS DateTime), 35, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (150, 28, 0, CAST(N'2022-03-19T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'no', NULL, 0, 33, NULL, 0, 2, CAST(N'2022-03-01T10:53:07.183' AS DateTime), CAST(N'2022-04-09T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (151, 28, 0, CAST(N'2022-03-16T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 0.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(90.00 AS Decimal(8, 2)), N'date time', NULL, 0, 33, NULL, 1, 1, CAST(N'2022-03-02T09:56:30.130' AS DateTime), CAST(N'2022-03-24T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (152, 28, 0, CAST(N'2022-03-25T00:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 0.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(90.00 AS Decimal(8, 2)), N'date', NULL, 0, 33, NULL, 0, 0, CAST(N'2022-03-02T09:58:15.977' AS DateTime), CAST(N'2022-03-23T09:14:58.213' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (153, 28, 0, CAST(N'2022-03-30T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'31', NULL, 0, NULL, NULL, 0, 0, CAST(N'2022-03-02T10:03:32.433' AS DateTime), CAST(N'2022-03-31T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (156, 28, 0, CAST(N'2022-03-01T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'merge date-time', NULL, 0, NULL, NULL, 0, 1, CAST(N'2022-03-02T15:01:10.290' AS DateTime), CAST(N'2022-03-23T17:50:53.137' AS DateTime), 0, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (157, 28, 0, CAST(N'2022-03-11T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 0.5, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(90.00 AS Decimal(8, 2)), N'testing', NULL, 0, 33, CAST(N'2022-03-26T10:52:30.577' AS DateTime), 1, 1, CAST(N'2022-03-02T16:00:44.890' AS DateTime), CAST(N'2022-03-23T17:52:22.280' AS DateTime), 0, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (158, 28, 0, CAST(N'2022-03-17T09:00:00.000' AS DateTime), N'364001', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'364001', NULL, 0, 33, NULL, 0, 2, CAST(N'2022-03-06T17:56:00.847' AS DateTime), CAST(N'2022-03-24T09:18:19.767' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (159, 28, 0, CAST(N'2022-03-02T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'14', NULL, 0, 33, CAST(N'2022-03-12T16:41:26.307' AS DateTime), 0, 2, CAST(N'2022-03-12T14:48:13.830' AS DateTime), CAST(N'2022-03-14T17:18:29.130' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (160, 28, 0, CAST(N'2022-03-26T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 3, 1, CAST(60.00 AS Decimal(8, 2)), NULL, CAST(80.00 AS Decimal(8, 2)), N'14', NULL, 0, 33, CAST(N'2022-03-12T16:34:48.757' AS DateTime), 0, 2, CAST(N'2022-03-12T14:49:59.973' AS DateTime), CAST(N'2022-03-26T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (161, 28, 0, CAST(N'2022-03-11T09:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'New service', NULL, 0, NULL, NULL, 1, NULL, CAST(N'2022-03-16T12:14:10.540' AS DateTime), CAST(N'2022-03-24T09:17:25.943' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (162, 28, 0, CAST(N'2022-03-16T10:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 5, 1, CAST(100.00 AS Decimal(8, 2)), NULL, CAST(120.00 AS Decimal(8, 2)), N'New Service ', NULL, 0, 33, CAST(N'2022-03-19T11:07:59.633' AS DateTime), 1, 2, CAST(N'2022-03-19T11:06:33.993' AS DateTime), CAST(N'2022-03-19T11:12:49.067' AS DateTime), 33, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
INSERT [dbo].[ServiceRequest] ([ServiceRequestId], [UserId], [ServiceId], [ServiceStartDate], [ZipCode], [ServiceHourlyRate], [ServiceHours], [ExtraHours], [SubTotal], [Discount], [TotalCost], [Comments], [PaymentTransactionRefNo], [PaymentDue], [ServiceProviderId], [SPAcceptedDate], [HasPets], [Status], [CreatedDate], [ModifiedDate], [ModifiedBy], [RefundedAmount], [Distance], [HasIssue], [PaymentDone], [RecordVersion]) VALUES (163, 28, 0, CAST(N'2022-03-31T08:00:00.000' AS DateTime), N'460002', CAST(20.00 AS Decimal(8, 2)), 4, 1, CAST(80.00 AS Decimal(8, 2)), NULL, CAST(100.00 AS Decimal(8, 2)), N'New Service', NULL, 0, NULL, NULL, 0, NULL, CAST(N'2022-03-29T13:00:10.817' AS DateTime), CAST(N'2022-03-31T00:00:00.000' AS DateTime), NULL, NULL, CAST(1.00 AS Decimal(18, 2)), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[ServiceRequest] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceRequestAddress] ON 

INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (1, 51, N'CVB', N'555', N'Q', NULL, N'890002', N'8956231470', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (2, 51, N'CVB', N'555', N'Q', NULL, N'890002', N'8956231470', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (3, 51, N'NEW', N'123', N'Bhavnagar', NULL, N'364001', N'6354285051', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (19, 97, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (20, 97, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (22, 97, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (23, 97, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (26, 102, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (27, 103, N'ABCABCD', N'1112', N'XYZ', NULL, N'42001', N'7896352140', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (28, 104, N'NEW', N'123', N'Bhavnagar', NULL, N'364001', N'6354285051', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (29, 106, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (30, 130, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (31, 131, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (32, 131, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (33, 132, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (34, 134, N'New Address', N'Baker Street', N'Brentford', NULL, N'123456', N'7856212345', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (35, 135, N'newest', N'address', N'andres', NULL, N'789001', N'1236540789', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (36, 144, N'newest', N'address', N'andres', NULL, N'789001', N'1236540789', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (37, 145, N'ABC', N'DEF', N'Bhavnagar', NULL, N'364001', N'0123456789', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (38, 146, N'NEW', N'123', N'Bhavnagar', NULL, N'456000', N'6354285051', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (39, 147, N'ABC', N'DEF', N'Bhavnagar', NULL, N'364001', N'0123456789', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (40, 148, N'NEW', N'123', N'Bhavnagar', NULL, N'364001', N'6354285051', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (41, 149, N'Baker Street', N'221B', N'Brentford', NULL, N'456321', N'7856212345', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (42, 150, N'New', N'Address', N'Abad', NULL, N'460002', N'7894563210', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (43, 156, N'NEW', N'123', N'Bhavnagar', NULL, N'364001', N'6354285051', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (44, 157, N'NewABC', N'NewDEF', N'NewBhavnagar', NULL, N'New364001', N'0123456789', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (45, 159, N'ABC', N'1112', N'XYZ', NULL, N'42001', N'7896352140', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (46, 160, N'ABC', N'1112', N'XYZ', NULL, N'42001', N'7896352140', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (47, 161, N'Baker Street', N'21', N'Brentford', NULL, N'456321', N'7896352140', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (48, 162, N'Baker Street', N'21', N'Brentford', NULL, N'456321', N'7896352140', NULL)
INSERT [dbo].[ServiceRequestAddress] ([Id], [ServiceRequestId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [Mobile], [Email]) VALUES (49, 163, N'Latest_new', N'12', N'XYZ', NULL, N'987600', N'2365478912', NULL)
SET IDENTITY_INSERT [dbo].[ServiceRequestAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[State] ON 

INSERT [dbo].[State] ([Id], [StateName]) VALUES (1, N'Gujarat')
SET IDENTITY_INSERT [dbo].[State] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (15, N'David', N'Gadot', N'david123@gmail.com', N'Hello@123', N'7891236540', 2, NULL, NULL, NULL, 0, NULL, N'123456', 0, NULL, NULL, CAST(N'2022-02-04T10:07:58.567' AS DateTime), CAST(N'2022-03-28T12:43:51.260' AS DateTime), 35, 1, 0, 0, NULL, NULL, NULL, N'                                                                                                    ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (16, N'David', N'Gadot', N'david123@gmail.com', N'Hello@123', N'7891236540', 1, NULL, NULL, NULL, 0, NULL, N'364001', 0, NULL, NULL, CAST(N'2022-02-04T10:10:22.470' AS DateTime), CAST(N'2022-02-04T10:10:22.473' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, N'                                                                                                    ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (17, N'Mihir', N'Rathod', N'mihirrathod1612@gmail.com', N'Hello@123', N'6354285051', 1, NULL, NULL, NULL, 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-02-04T16:11:57.703' AS DateTime), CAST(N'2022-03-24T15:27:06.943' AS DateTime), 0, 0, 1, 0, NULL, NULL, NULL, N'004f225d-672d-4393-b047-4c356da894c2                                                                ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (18, N'Login1', N'test', N'login456@gmail.com', N'Oldpass@123', N'7895463210', 1, NULL, NULL, NULL, 0, NULL, N'410003', 0, NULL, NULL, CAST(N'2022-02-07T09:52:54.603' AS DateTime), CAST(N'2022-03-24T17:21:07.570' AS DateTime), 0, 0, 0, 0, NULL, NULL, NULL, N'                                                                                                    ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (19, N'User1', N'Surname1', N'user1@gmail.com', N'S/2uw22Xsa0XUNXhPUmGI43Xuy5vBGtjuzcrdU4JsOQ=', N'7856212345', 2, 1, NULL, N'hat', 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-02-07T11:04:19.140' AS DateTime), CAST(N'2022-03-28T12:52:31.193' AS DateTime), 0, 1, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (20, N'Admin', N'Gadot', N'david123@yopmail.com', N'T//Qf1+0h7DYcphy129AAKfFoaPotfDhpjp0/lAOgwg=', N'7891236540', 1, NULL, NULL, NULL, 0, NULL, N'364001', 0, NULL, NULL, CAST(N'2022-02-07T11:08:05.433' AS DateTime), CAST(N'2022-02-07T11:08:05.437' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (21, N'abc', N'efg', N'abc@gmail.com', N'Abc@1234', N'7856212345', 1, NULL, NULL, NULL, 0, NULL, N'894001', 0, NULL, NULL, CAST(N'2022-02-07T11:10:01.850' AS DateTime), CAST(N'2022-02-07T11:10:01.850' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (22, N'User1', N'Surname1', N'user1@gmail.com', N'S/2uw22Xsa0XUNXhPUmGI43Xuy5vBGtjuzcrdU4JsOQ=', N'7856212345', 2, NULL, NULL, N'car', 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-02-07T11:20:09.023' AS DateTime), CAST(N'2022-02-07T11:20:09.023' AS DateTime), 2, 1, 1, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (23, N'User1', N'Surname1', N'user1@gmail.com', N'User@123', N'7856212345', 1, NULL, NULL, NULL, 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-02-07T11:24:25.887' AS DateTime), CAST(N'2022-02-07T11:24:25.887' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (24, N'Password', N'Encrypt', N'encrypt@gmail.com', N'AIPwzfgQjnp4lrfPiR+1osOO6uzm4M/nfOF+D5iJjQUUtQH8BRwrn45zlfpCgoCnPA==', N'0001117891', 1, NULL, NULL, NULL, 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-02-08T16:45:12.503' AS DateTime), CAST(N'2022-02-08T16:45:12.503' AS DateTime), 2, 1, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (25, N'pswd', N'test', N'encrypt1@gmail.com', N'B6BC7B58510319A151D168BA3D5AECB3AC0A9708D06DD930F37FBC89B6CDC697', N'7856856490', 1, NULL, NULL, NULL, 0, NULL, N'460005', 0, NULL, NULL, CAST(N'2022-02-08T17:10:10.473' AS DateTime), CAST(N'2022-02-08T17:10:10.473' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (26, N'New', N'User', N'newu@gmail.com', N'1A3nWZBAl0oCBK40kKkfnPabrhvEoy3wBaRlObXUTUk=', N'7896352140', 1, NULL, NULL, NULL, 0, NULL, N'364001', 0, NULL, NULL, CAST(N'2022-02-08T17:38:45.317' AS DateTime), CAST(N'2022-03-28T12:41:00.540' AS DateTime), 35, 0, 0, 0, NULL, NULL, NULL, NULL)
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (28, N'Login', N'Login Last Name', N'login@yopmail.com', N'T//Qf1+0h7DYcphy129AAKfFoaPotfDhpjp0/lAOgwg=', N'7894563210', 1, NULL, CAST(N'2006-07-06T00:00:00.000' AS DateTime), NULL, 0, NULL, N'46002', 0, NULL, NULL, CAST(N'2022-02-18T15:12:01.507' AS DateTime), CAST(N'2022-03-24T15:45:27.210' AS DateTime), 0, 0, 1, 0, NULL, NULL, NULL, N'e50c438d-7dab-4fa7-bd79-c1572ca489d0                                                                ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (33, N'Service1', N'Provider', N'serviceprovider123@yopmail.com', N'zOGDFS/IUwwnMv130CYzo2ibRD48XPcyoyJg1OQ9gJU=', N'7896541230', 2, 1, CAST(N'1995-01-01T00:00:00.000' AS DateTime), N'car', 0, NULL, N'460002', 0, NULL, NULL, CAST(N'2022-03-08T10:50:25.353' AS DateTime), CAST(N'2022-03-25T10:20:10.537' AS DateTime), 35, 1, 1, 0, NULL, NULL, NULL, N'11908700-7577-4b5d-8a6d-90061f96f10f                                                                ')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [Mobile], [UserTypeId], [Gender], [DateOfBirth], [UserProfilePicture], [IsRegisteredUser], [PaymentGatewayUserRef], [ZipCode], [WorksWithPets], [LanguageId], [NationalityId], [CreatedDate], [ModifiedDate], [ModifiedBy], [IsApproved], [IsActive], [IsDeleted], [Status], [BankTokenId], [TaxNo], [ReserPasswordLink]) VALUES (35, N'Admin', N'newAdmin', N'admin_tatva@yopmail.com', N'cHM7cJHXD5DXsj38ihuDeapiirSQMl+o+aI6QtJiCJ0=', N'1456987310', 0, NULL, NULL, NULL, 0, NULL, NULL, 0, NULL, NULL, CAST(N'2022-03-24T10:33:49.673' AS DateTime), CAST(N'2022-03-24T10:33:49.673' AS DateTime), 2, 0, 0, 0, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[UserAddress] ON 

INSERT [dbo].[UserAddress] ([AddressId], [UserId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [IsDefault], [IsDeleted], [Mobile], [Email]) VALUES (90, 28, N'Baker Street', N'21', N'Brentford', NULL, N'456321', 1, 1, N'7896352140', NULL)
INSERT [dbo].[UserAddress] ([AddressId], [UserId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [IsDefault], [IsDeleted], [Mobile], [Email]) VALUES (95, 33, N'SPAddress123', N'12', N'XYZ', NULL, N'460002', 1, 1, NULL, N'serviceprovider123@yopmail.com')
INSERT [dbo].[UserAddress] ([AddressId], [UserId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [IsDefault], [IsDeleted], [Mobile], [Email]) VALUES (97, 28, N'Latest_new', N'12', N'XYZ', NULL, N'987600', 1, 1, N'2365478912', NULL)
INSERT [dbo].[UserAddress] ([AddressId], [UserId], [AddressLine1], [AddressLine2], [City], [State], [PostalCode], [IsDefault], [IsDeleted], [Mobile], [Email]) VALUES (109, 19, N'ABC', N'DEF', N'XYZ', NULL, N'460002', 0, 0, NULL, N'user1@gmail.com')
SET IDENTITY_INSERT [dbo].[UserAddress] OFF
GO
SET IDENTITY_INSERT [dbo].[Zipcode] ON 

INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (1, N'380001', 1)
INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (2, N'380002', 1)
INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (3, N'380003', 1)
INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (4, N'364001', 2)
INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (5, N'364002', 2)
INSERT [dbo].[Zipcode] ([Id], [ZipcodeValue], [CityId]) VALUES (6, N'364003', 2)
SET IDENTITY_INSERT [dbo].[Zipcode] OFF
GO
ALTER TABLE [dbo].[Rating] ADD  CONSTRAINT [DF_Rating_OnTimeArrival]  DEFAULT ((0)) FOR [OnTimeArrival]
GO
ALTER TABLE [dbo].[Rating] ADD  CONSTRAINT [DF_Rating_Friendly]  DEFAULT ((0)) FOR [Friendly]
GO
ALTER TABLE [dbo].[Rating] ADD  CONSTRAINT [DF_Rating_QualityOfService]  DEFAULT ((0)) FOR [QualityOfService]
GO
ALTER TABLE [dbo].[ServiceRequest] ADD  CONSTRAINT [DF_ServiceRequest_PaymentDue]  DEFAULT ((0)) FOR [PaymentDue]
GO
ALTER TABLE [dbo].[ServiceRequest] ADD  CONSTRAINT [DF_ServiceRequest_IsPet]  DEFAULT ((0)) FOR [HasPets]
GO
ALTER TABLE [dbo].[ServiceRequest] ADD  CONSTRAINT [DF_ServiceRequest_CreatedDate]  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[ServiceRequest] ADD  CONSTRAINT [DF_ServiceRequest_ModifiedDate]  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[ServiceRequest] ADD  CONSTRAINT [DF_ServiceRequest_Distance]  DEFAULT ((0)) FOR [Distance]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsRegisteredUser]  DEFAULT ((0)) FOR [IsRegisteredUser]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_WorksWithPets]  DEFAULT ((0)) FOR [WorksWithPets]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UserAddress] ADD  CONSTRAINT [DF_UserAddresses_IsDefault]  DEFAULT ((0)) FOR [IsDefault]
GO
ALTER TABLE [dbo].[UserAddress] ADD  CONSTRAINT [DF_UserAddresses_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[City]  WITH CHECK ADD  CONSTRAINT [FK_City_State] FOREIGN KEY([StateId])
REFERENCES [dbo].[State] ([Id])
GO
ALTER TABLE [dbo].[City] CHECK CONSTRAINT [FK_City_State]
GO
ALTER TABLE [dbo].[FavoriteAndBlocked]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteAndBlocked_FavoriteAndBlocked] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[FavoriteAndBlocked] CHECK CONSTRAINT [FK_FavoriteAndBlocked_FavoriteAndBlocked]
GO
ALTER TABLE [dbo].[FavoriteAndBlocked]  WITH CHECK ADD  CONSTRAINT [FK_FavoriteAndBlocked_User] FOREIGN KEY([TargetUserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[FavoriteAndBlocked] CHECK CONSTRAINT [FK_FavoriteAndBlocked_User]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_ServiceRequest] FOREIGN KEY([ServiceRequestId])
REFERENCES [dbo].[ServiceRequest] ([ServiceRequestId])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_ServiceRequest]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_User] FOREIGN KEY([RatingFrom])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_User]
GO
ALTER TABLE [dbo].[Rating]  WITH CHECK ADD  CONSTRAINT [FK_Rating_User1] FOREIGN KEY([RatingTo])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Rating] CHECK CONSTRAINT [FK_Rating_User1]
GO
ALTER TABLE [dbo].[ServiceRequest]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequest_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ServiceRequest] CHECK CONSTRAINT [FK_ServiceRequest_User]
GO
ALTER TABLE [dbo].[ServiceRequest]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequest_User1] FOREIGN KEY([ServiceProviderId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[ServiceRequest] CHECK CONSTRAINT [FK_ServiceRequest_User1]
GO
ALTER TABLE [dbo].[ServiceRequestAddress]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequestAddress_ServiceRequest] FOREIGN KEY([ServiceRequestId])
REFERENCES [dbo].[ServiceRequest] ([ServiceRequestId])
GO
ALTER TABLE [dbo].[ServiceRequestAddress] CHECK CONSTRAINT [FK_ServiceRequestAddress_ServiceRequest]
GO
ALTER TABLE [dbo].[ServiceRequestExtra]  WITH CHECK ADD  CONSTRAINT [FK_ServiceRequestExtra_ServiceRequest] FOREIGN KEY([ServiceRequestId])
REFERENCES [dbo].[ServiceRequest] ([ServiceRequestId])
GO
ALTER TABLE [dbo].[ServiceRequestExtra] CHECK CONSTRAINT [FK_ServiceRequestExtra_ServiceRequest]
GO
ALTER TABLE [dbo].[UserAddress]  WITH CHECK ADD  CONSTRAINT [FK_UserAddresses_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[UserAddress] CHECK CONSTRAINT [FK_UserAddresses_User]
GO
ALTER TABLE [dbo].[Zipcode]  WITH CHECK ADD  CONSTRAINT [FK_Zipcode_City] FOREIGN KEY([CityId])
REFERENCES [dbo].[City] ([Id])
GO
ALTER TABLE [dbo].[Zipcode] CHECK CONSTRAINT [FK_Zipcode_City]
GO
USE [master]
GO
ALTER DATABASE [Helperland] SET  READ_WRITE 
GO
