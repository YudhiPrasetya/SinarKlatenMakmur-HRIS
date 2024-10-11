/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : PenghasilanTidakKenaPajakDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:13:42
*/


-- ----------------------------
-- Table structure for PTKPs
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[PTKPs]') AND type IN ('U'))
	DROP TABLE [dbo].[PTKPs]
GO

CREATE TABLE [dbo].[PTKPs] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Keterangan] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Jumlah] int  NOT NULL,
  [IsActive] bit  NOT NULL,
  [CreatedBy] int  NOT NULL,
  [CreatedAt] datetime2(7)  NULL,
  [UpdatedBy] int  NOT NULL,
  [UpdatedAt] datetime2(7)  NULL
)
GO

ALTER TABLE [dbo].[PTKPs] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of PTKPs
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PTKPs] ON
GO

INSERT INTO [dbo].[PTKPs] ([Id], [Keterangan], [Jumlah], [IsActive], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (N'1', N'TIDAK KAWIN', N'24300000', N'1', N'1', N'2023-09-15 13:58:07.0000000', N'1', N'2023-09-15 13:58:10.0000000')
GO

INSERT INTO [dbo].[PTKPs] ([Id], [Keterangan], [Jumlah], [IsActive], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (N'2', N'KAWIN', N'26325000', N'1', N'1', N'2023-09-15 13:58:38.0000000', N'1', N'2023-09-15 13:58:43.0000000')
GO

INSERT INTO [dbo].[PTKPs] ([Id], [Keterangan], [Jumlah], [IsActive], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (N'3', N'KAWIN ANAK 1', N'28350000', N'1', N'1', N'2023-09-15 13:59:13.0000000', N'1', N'2023-09-15 13:59:18.0000000')
GO

INSERT INTO [dbo].[PTKPs] ([Id], [Keterangan], [Jumlah], [IsActive], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (N'4', N'KAWIN ANAK 2', N'30375000', N'1', N'1', N'2023-09-15 13:59:44.0000000', N'1', N'2023-09-15 13:59:48.0000000')
GO

INSERT INTO [dbo].[PTKPs] ([Id], [Keterangan], [Jumlah], [IsActive], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt]) VALUES (N'5', N'KAWIN ANAK 3', N'32400000', N'1', N'1', N'2023-09-15 14:00:15.0000000', N'1', N'2023-09-15 14:00:19.0000000')
GO

SET IDENTITY_INSERT [dbo].[PTKPs] OFF
GO


-- ----------------------------
-- Auto increment value for PTKPs
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[PTKPs]', RESEED, 5)
GO


-- ----------------------------
-- Primary Key structure for table PTKPs
-- ----------------------------
ALTER TABLE [dbo].[PTKPs] ADD CONSTRAINT [PK_PTKPs] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

