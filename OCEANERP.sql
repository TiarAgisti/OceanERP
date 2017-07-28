USE [master]
GO
/****** Object:  Database [OCEANERP]    Script Date: 2017-07-27 09:32:57 ******/
CREATE DATABASE [OCEANERP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OCEANERP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OCEANERP.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'OCEANERP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\OCEANERP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [OCEANERP] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OCEANERP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OCEANERP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OCEANERP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OCEANERP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OCEANERP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OCEANERP] SET ARITHABORT OFF 
GO
ALTER DATABASE [OCEANERP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OCEANERP] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [OCEANERP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OCEANERP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OCEANERP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OCEANERP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OCEANERP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OCEANERP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OCEANERP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OCEANERP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OCEANERP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OCEANERP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OCEANERP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OCEANERP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OCEANERP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OCEANERP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OCEANERP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OCEANERP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OCEANERP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OCEANERP] SET  MULTI_USER 
GO
ALTER DATABASE [OCEANERP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OCEANERP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OCEANERP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OCEANERP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [OCEANERP]
GO
/****** Object:  Table [dbo].[Bank]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bank](
	[BankID] [int] NOT NULL,
	[BankCode] [varchar](15) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[SwiftCode] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BankAccount]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BankAccount](
	[BankAccountID] [int] NOT NULL,
	[BankAccountCode] [varchar](15) NOT NULL,
	[BankID] [int] NOT NULL,
	[VendorID] [int] NOT NULL,
	[CurrencyID] [int] NOT NULL,
	[AccountName] [varchar](150) NOT NULL,
	[AccountNumber] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_BankAccount] PRIMARY KEY CLUSTERED 
(
	[BankAccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Brand](
	[BrandID] [int] NOT NULL,
	[BrandCode] [varchar](15) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Description] [varchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BrandYarn]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BrandYarn](
	[BrandYarnID] [int] NOT NULL,
	[BrandYarnName] [varchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MerkBenang] PRIMARY KEY CLUSTERED 
(
	[BrandYarnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[COA]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[COA](
	[CoaID] [int] NOT NULL,
	[CoaCode] [varchar](15) NOT NULL,
	[CoaName] [varchar](150) NOT NULL,
	[CostCenter] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_COA] PRIMARY KEY CLUSTERED 
(
	[CoaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Colors]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Colors](
	[ColorID] [int] NOT NULL,
	[ColorCode] [varchar](15) NOT NULL,
	[ColorName] [varchar](150) NOT NULL,
	[Description] [varchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Colors] PRIMARY KEY CLUSTERED 
(
	[ColorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Currency](
	[CurrencyID] [int] NOT NULL,
	[CurrencyCode] [varchar](15) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CurrencyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentID] [int] NOT NULL,
	[DepartmentCode] [varchar](15) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[SBU] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Destination]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Destination](
	[DestinationID] [int] NOT NULL,
	[DestinationCode] [varchar](15) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Status] [char](1) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[DestinationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fabric]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fabric](
	[FabricID] [int] NOT NULL,
	[FabricCode] [varchar](15) NOT NULL,
	[FabricName] [varchar](255) NOT NULL,
	[Composition] [varchar](150) NOT NULL,
	[Specification] [varchar](150) NOT NULL,
	[VendorID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Fabric] PRIMARY KEY CLUSTERED 
(
	[FabricID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GroupSales]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GroupSales](
	[GroupSalesID] [int] NOT NULL,
	[GroupSalesCode] [varchar](15) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_GroupSales] PRIMARY KEY CLUSTERED 
(
	[GroupSalesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogHistory]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogHistory](
	[LogID] [bigint] NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[UserID] [int] NOT NULL,
	[IP] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LogHistory] PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuID] [int] NOT NULL,
	[MenuDescription] [varchar](50) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIColorDetail]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PIColorDetail](
	[PIHeaderID] [bigint] NOT NULL,
	[PIColorDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[ColorID] [int] NOT NULL,
	[ColorType] [varchar](150) NULL,
	[ColorLabNumber] [varchar](150) NULL,
	[QtyOrder] [float] NULL,
	[PurchSizeID] [int] NULL,
	[Price] [float] NULL,
	[QtySample] [float] NULL,
	[DelDate] [date] NULL,
	[Note] [varchar](max) NULL,
 CONSTRAINT [PK_PIColorDetail] PRIMARY KEY CLUSTERED 
(
	[PIHeaderID] ASC,
	[PIColorDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIDetail]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PIDetail](
	[PIHeaderID] [bigint] NOT NULL,
	[PIDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[FabricID] [int] NOT NULL,
	[DateDetail] [date] NOT NULL,
	[ColorID] [int] NOT NULL,
	[PPSample] [varchar](50) NOT NULL,
	[QtyCuttable] [decimal](18, 2) NOT NULL,
	[QtyWeight] [decimal](18, 2) NOT NULL,
	[Qty] [decimal](18, 2) NOT NULL,
	[UnitID] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[CurrencyID] [int] NOT NULL,
 CONSTRAINT [PK_PIDetail] PRIMARY KEY CLUSTERED 
(
	[PIHeaderID] ASC,
	[PIDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIHeader]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PIHeader](
	[PIHeaderID] [bigint] NOT NULL,
	[PIDate] [date] NOT NULL,
	[PINo] [varchar](50) NOT NULL,
	[VendorID] [int] NOT NULL,
	[BuyerID] [int] NOT NULL,
	[GroupSalesID] [int] NOT NULL,
	[RefPO] [varchar](50) NOT NULL,
	[Style] [varchar](100) NULL,
	[SeasonID] [int] NULL,
	[TermOfPaymentID] [int] NOT NULL,
	[DelTerm] [date] NOT NULL,
	[TermOfPriceID] [int] NOT NULL,
	[ContractNo] [varchar](50) NULL,
	[DestinationID] [int] NULL,
	[DeliveryPlace] [varchar](255) NOT NULL,
	[Status] [smallint] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_PIHeader] PRIMARY KEY CLUSTERED 
(
	[PIHeaderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIRemarks]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PIRemarks](
	[PIHeaderID] [bigint] NOT NULL,
	[PIRemarksID] [bigint] IDENTITY(1,1) NOT NULL,
	[Remarks] [varchar](max) NOT NULL,
 CONSTRAINT [PK_PIRemarks] PRIMARY KEY CLUSTERED 
(
	[PIHeaderID] ASC,
	[PIRemarksID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PIYarnDetail]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PIYarnDetail](
	[PIHeaderID] [bigint] NOT NULL,
	[PIYarnDetailID] [bigint] IDENTITY(1,1) NOT NULL,
	[YarnID] [int] NOT NULL,
	[PriceYarn] [float] NULL,
	[PercentageUsage] [float] NULL,
	[QtyUsage] [float] NULL,
	[ColorID] [int] NULL,
	[BrandYarnID] [int] NULL,
	[Loss] [float] NULL,
 CONSTRAINT [PK_PIYarnDetail] PRIMARY KEY CLUSTERED 
(
	[PIHeaderID] ASC,
	[PIYarnDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RawMaterial]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RawMaterial](
	[RawMaterialID] [int] NOT NULL,
	[RawMaterialCode] [varchar](50) NOT NULL,
	[RawMaterialName] [varchar](50) NOT NULL,
	[VendorID] [int] NOT NULL,
	[SpecRawMaterial] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_RawMaterial] PRIMARY KEY CLUSTERED 
(
	[RawMaterialID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RoleD]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleD](
	[RoleID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
	[IsCreate] [bit] NOT NULL,
	[IsUpdate] [bit] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[IsApprove] [bit] NOT NULL,
	[IsVoid] [bit] NOT NULL,
 CONSTRAINT [PK_RoleD] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RoleH]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[RoleH](
	[RoleID] [int] NOT NULL,
	[RoleName] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_RoleH] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Season]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Season](
	[SeasonID] [int] NOT NULL,
	[SeasonCode] [varchar](15) NOT NULL,
	[SeasonName] [varchar](150) NOT NULL,
	[Description] [varchar](150) NOT NULL,
	[VendorID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED 
(
	[SeasonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Style]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Style](
	[StyleID] [int] NOT NULL,
	[StyleCode] [varchar](50) NOT NULL,
	[StyleName] [varchar](150) NOT NULL,
	[SpecStyle] [varchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Style] PRIMARY KEY CLUSTERED 
(
	[StyleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TermApprove]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TermApprove](
	[TermApproveID] [bigint] NOT NULL,
	[UserID] [int] NOT NULL,
	[Code] [varchar](15) NOT NULL,
	[Notes] [varchar](255) NOT NULL,
	[Status] [smallint] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TermApprove] PRIMARY KEY CLUSTERED 
(
	[TermApproveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TermOfPayment]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TermOfPayment](
	[TermOfPaymentID] [int] NOT NULL,
	[TermOfPaymentCode] [varchar](15) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Description] [varchar](150) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TermOfPayment] PRIMARY KEY CLUSTERED 
(
	[TermOfPaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TermOfPrice]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TermOfPrice](
	[TermOfPriceID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TermOfPrice] PRIMARY KEY CLUSTERED 
(
	[TermOfPriceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] NOT NULL,
	[UnitName] [varchar](15) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Unit] PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[userpassword] [varchar](255) NOT NULL,
	[RoleID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vendor](
	[VendorID] [int] NOT NULL,
	[VendorCode] [varchar](15) NOT NULL,
	[VendorName] [varchar](255) NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[ShippingAddress] [varchar](max) NULL,
	[Telephone] [varchar](25) NULL,
	[Fax] [varchar](25) NULL,
	[ContactPerson] [varchar](50) NOT NULL,
	[EmailCP] [varchar](50) NOT NULL,
	[Npwp] [varchar](50) NOT NULL,
	[TermOfPaymentID] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
	[DestinationID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Yarn]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Yarn](
	[YarnID] [int] NOT NULL,
	[YarnCode] [varchar](15) NOT NULL,
	[YarnName] [varchar](150) NOT NULL,
	[VendorID] [int] NOT NULL,
	[SpecYarn] [varchar](150) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[UpdatedBy] [int] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Yarn] PRIMARY KEY CLUSTERED 
(
	[YarnID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[v_BankAccount]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE View [dbo].[v_BankAccount]
AS

SELECT ba.BankAccountID
		, ba.BankAccountCode
		, ba.BankID
		, ba.VendorID
		, ba.CurrencyID
		, ba.AccountName
		, ba.AccountNumber
		, ba.IsActive
		, bnk.Name BankName
		, ve.VendorCode + ' - ' + ve.VendorName as VendorDesc
		, cur.Name CurrencyName
FROM BankAccount as ba
LEFT JOIN Bank as bnk ON bnk.BankID = ba.BankID
LEFT JOIN Vendor as ve ON ve.VendorID = ba.VendorID
LEFT JOIN Currency as cur ON cur.CurrencyID = ba.CurrencyID



GO
/****** Object:  View [dbo].[v_Fabric]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Fabric]
AS
SELECT fbc.FabricID
		, fbc.FabricCode
		, fbc.FabricName
		, fbc.Composition
		, fbc.Specification
		, fbc.VendorID
		, fbc.IsActive
		, ven.VendorName
FROM Fabric as fbc
INNER JOIN Vendor as ven ON ven.VendorID = fbc.VendorID

GO
/****** Object:  View [dbo].[v_PIDetail]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_PIDetail]
AS

SELECT pidet.*
		, pih.PINo
		, pih.PIDate
		, fab.FabricName
		, co.ColorCode
		, co.ColorName
		, un.UnitName
		, cur.CurrencyCode
		, cur.Name as Currency
FROM PIDETAIL as pidet
LEFT JOIN PIHeader as pih ON pih.PIHeaderID = pidet.PIHeaderID
LEFT JOIN Fabric as fab ON fab.FabricID = pidet.FabricID
LEFT JOIN Colors as co ON co.ColorID = pidet.ColorID
LEFT JOIN Unit as un ON un.UnitID = pidet.UnitID
LEFT JOIN Currency as cur ON cur.CurrencyID = pidet.CurrencyID 



GO
/****** Object:  View [dbo].[v_PIHeader]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[v_PIHeader]
AS

SELECT pih.PIHeaderID
		, pih.PIDate
		, pih.PINo
		, pih.VendorID
		, pih.BuyerID
		, pih.GroupSalesID
		, pih.RefPO
		, pih.Style
		, pih.SeasonID
		, pih.TermOfPaymentID
		, pih.DelTerm
		, pih.TermOfPriceID
		, pih.ContractNo
		, pih.DestinationID
		, pih.DeliveryPlace
		, pih.Status
		, ve.VendorCode
		, ve.VendorName
		, ve.Address
		, ve.Telephone
		, ve.Fax
		, ve.ContactPerson
		, buyer.VendorName as BuyerName
		, gs.Name as SalesName
		, sea.SeasonName
		, tp.Name as TermOfPayment
		, tpi.Name as TermOfPrice
		, dest.Name as DestinationName
FROM PIHeader as pih
LEFT JOIN Vendor as ve ON ve.VendorID = pih.VendorID 
LEFT JOIN Vendor as buyer ON buyer.VendorID = pih.BuyerID
LEFT JOIN GroupSales as gs ON gs.GroupSalesID = pih.GroupSalesID
LEFT JOIN Season as sea ON sea.SeasonID = pih.SeasonID
LEFT JOIN TermOfPayment as tp ON tp.TermOfPaymentID = pih.TermOfPaymentID
LEFT JOIN TermOfPrice as tpi ON tpi.TermOfPriceID = pih.TermOfPriceID
LEFT JOIN Destination as dest ON dest.DestinationID = pih.DestinationID





GO
/****** Object:  View [dbo].[v_RawMaterial]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE View [dbo].[v_RawMaterial]
AS

Select rm.RawMaterialID
		, rm.RawMaterialCode
		, rm.RawMaterialName
		, rm.VendorID
		, rm.SpecRawMaterial
		, rm.IsActive
		, ven.VendorName
FROM RawMaterial as rm
LEFT JOIN Vendor as ven ON ven.VendorID = rm.VendorID



GO
/****** Object:  View [dbo].[v_RoleD]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[v_RoleD]
AS

Select rod.*
		, mn.MenuDescription
From RoleD rod
LEFT JOIN Menu mn ON mn.MenuID = rod.MenuID



GO
/****** Object:  View [dbo].[v_Season]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Season]
AS
SELECT s.SeasonID
		, s.SeasonCode
		, s.SeasonName
		, s.Description
		, s.VendorID
		, s.IsActive
		, v.VendorName
FROM Season as s
LEFT JOIN Vendor as v ON v.VendorID = s.VendorID

GO
/****** Object:  View [dbo].[v_Users]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[v_Users]
AS

SELECT us.*
		, roh.RoleName
FROM Users us
LEFT JOIN RoleH roh ON roh.RoleID = us.RoleID
GO
/****** Object:  View [dbo].[v_Vendor]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE View [dbo].[v_Vendor]
AS
Select vn.VendorID
		, vn.VendorCode
		, vn.VendorName
		, vn.Address
		, vn.ShippingAddress
		, vn.Telephone
		, vn.Fax
		, vn.ContactPerson
		, vn.EmailCP
		, vn.Npwp
		, vn.TermOfPaymentID
		, tp.Name TermOfPaymentName
		, vn.Status
		, vn.DestinationID
		, dt.Name DestinationName
		, vn.IsActive
From Vendor vn
LEFT JOIN TermOfPayment tp ON tp.TermOfPaymentID = vn.TermOfPaymentID
LEFT JOIN Destination dt ON dt.DestinationID = vn.DestinationID



GO
/****** Object:  View [dbo].[v_Yarn]    Script Date: 2017-07-27 09:32:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE View [dbo].[v_Yarn]
AS

Select y.YarnID
		, y.YarnCode
		, y.YarnName
		, y.VendorID
		, y.SpecYarn
		, y.IsActive
		, ven.VendorName
FROM Yarn as y
LEFT JOIN Vendor as ven ON ven.VendorID = y.VendorID



GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Menu"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RoleD"
            Begin Extent = 
               Top = 6
               Left = 256
               Bottom = 136
               Right = 426
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_RoleD'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_RoleD'
GO
USE [master]
GO
ALTER DATABASE [OCEANERP] SET  READ_WRITE 
GO
