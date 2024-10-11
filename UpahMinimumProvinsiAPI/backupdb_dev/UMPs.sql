/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : UpahMinimumProvinsiDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:18:56
*/


-- ----------------------------
-- Table structure for UMPs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[UMPs]') AND type IN ('U'))
	DROP TABLE [dbo].[UMPs]
GO

CREATE TABLE [dbo].[UMPs] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Keterangan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tahun] int  NOT NULL,
  [Jumlah] int  NOT NULL,
  [CreatedBy] int  NOT NULL,
  [UpdatedBy] int  NOT NULL,
  [CreatedAt] datetime2(7)  NOT NULL,
  [UpdatedAt] datetime2(7)  NOT NULL
)
GO

ALTER TABLE [dbo].[UMPs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of UMPs
-- ----------------------------
SET IDENTITY_INSERT [dbo].[UMPs] ON
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'1', N'UMP Tahun 2018', N'2018', N'1661632', N'1', N'1', N'2023-09-15 10:57:57.0000000', N'2023-09-15 10:58:01.0000000')
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'2', N'UMP Tahun 2019', N'2019', N'1795061', N'1', N'1', N'2023-09-15 10:58:47.0000000', N'2023-09-15 10:58:50.0000000')
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'3', N'UMP Tahun 2020', N'2020', N'1947821', N'1', N'1', N'2023-09-15 10:59:23.0000000', N'2023-09-15 10:59:25.0000000')
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'4', N'UMP Tahun 2021', N'2021', N'2011515', N'1', N'1', N'2023-09-15 10:59:57.0000000', N'2023-09-15 11:00:04.0000000')
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'5', N'UMP Tahun 2022', N'2022', N'2015623', N'1', N'1', N'2023-09-15 11:00:40.0000000', N'2023-09-15 11:00:43.0000000')
GO

INSERT INTO [dbo].[UMPs] ([Id], [Keterangan], [Tahun], [Jumlah], [CreatedBy], [UpdatedBy], [CreatedAt], [UpdatedAt]) VALUES (N'6', N'UMP Tahun 2023', N'2023', N'2152323', N'1', N'1', N'2023-09-15 11:01:12.0000000', N'2023-09-15 11:01:14.0000000')
GO

SET IDENTITY_INSERT [dbo].[UMPs] OFF
GO


-- ----------------------------
-- Auto increment value for UMPs
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[UMPs]', RESEED, 6)
GO


-- ----------------------------
-- Primary Key structure for table UMPs
-- ----------------------------
ALTER TABLE [dbo].[UMPs] ADD CONSTRAINT [PK_UMPs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

