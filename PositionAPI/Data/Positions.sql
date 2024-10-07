/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : PositionDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 29/10/2023 15:27:41
*/


-- ----------------------------
-- Table structure for Positions
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Positions]') AND type IN ('U'))
	DROP TABLE [dbo].[Positions]
GO

CREATE TABLE [dbo].[Positions] (
  [PositionId] int  IDENTITY(1,1) NOT NULL,
  [PositionDesc] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsActive] bit  NOT NULL,
  [CreatedAt] datetime2(7)  NOT NULL,
  [CreatedBy] int DEFAULT 0 NOT NULL,
  [UpdatedAt] datetime2(7) DEFAULT '0001-01-01T00:00:00.0000000' NOT NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL
)
GO

ALTER TABLE [dbo].[Positions] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Positions
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Positions] ON
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'1', N'ADMIN', N'1', N'2018-01-17 10:58:00.0000000', N'1', N'2018-01-17 10:58:00.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'2', N'KARYAWAN', N'1', N'2018-01-17 10:58:00.0000000', N'1', N'2018-01-17 10:58:00.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'3', N'OPERATOR JAHIT', N'1', N'2018-01-17 10:58:00.0000000', N'1', N'2018-01-17 10:58:00.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'4', N'QC', N'1', N'2018-01-17 10:58:00.0000000', N'1', N'2018-01-17 10:58:00.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'5', N'STAFF', N'1', N'2018-01-17 10:58:00.0000000', N'1', N'2018-01-17 10:58:00.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'6', N'SECURITY', N'1', N'2018-06-25 15:04:43.0000000', N'1', N'2018-06-25 15:04:43.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'7', N'MOVER', N'1', N'2019-04-01 14:09:38.0000000', N'1', N'2019-04-01 14:09:38.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'8', N'IRON', N'1', N'2019-04-01 14:09:59.0000000', N'1', N'2019-04-01 14:09:59.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'9', N'OPERATOR CUTING', N'1', N'2019-04-01 14:10:18.0000000', N'1', N'2019-04-01 14:10:18.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'10', N'BUANG BENANG ', N'1', N'2019-04-01 14:10:43.0000000', N'1', N'2019-04-01 14:10:43.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'11', N'PRESS', N'1', N'2019-04-01 14:10:52.0000000', N'1', N'2019-04-01 14:10:52.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'12', N'MANUAL', N'1', N'2019-04-01 14:11:09.0000000', N'1', N'2019-04-01 14:11:09.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'13', N'KEBUT BENANG & SEMPROT', N'1', N'2019-04-01 14:11:37.0000000', N'1', N'2019-04-01 14:11:37.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'14', N'PACKING', N'1', N'2019-04-01 14:22:01.0000000', N'1', N'2019-04-01 14:22:01.0000000', N'1')
GO

INSERT INTO [dbo].[Positions] ([PositionId], [PositionDesc], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'15', N'CUTTING', N'1', N'2019-04-01 14:24:44.0000000', N'1', N'2019-04-01 14:24:44.0000000', N'1')
GO

SET IDENTITY_INSERT [dbo].[Positions] OFF
GO


-- ----------------------------
-- Auto increment value for Positions
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Positions]', RESEED, 19)
GO

