/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : MesinAbsenDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:12:17
*/


-- ----------------------------
-- Table structure for MesinAbsens
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MesinAbsens]') AND type IN ('U'))
	DROP TABLE [dbo].[MesinAbsens]
GO

CREATE TABLE [dbo].[MesinAbsens] (
  [DeviceID] int  IDENTITY(1,1) NOT NULL,
  [DeviceDesc] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DeviceIP] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [IsActive] bit  NOT NULL,
  [CreatedAt] datetime2(7)  NOT NULL,
  [CreatedBy] int DEFAULT 0 NOT NULL,
  [UpdatedAt] datetime2(7) DEFAULT '0001-01-01T00:00:00.0000000' NOT NULL,
  [UpdatedBy] int DEFAULT 0 NOT NULL,
  [Port] int  NULL,
  [DeviceNo] int  NULL,
  [Connected] bit  NULL
)
GO

ALTER TABLE [dbo].[MesinAbsens] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of MesinAbsens
-- ----------------------------
SET IDENTITY_INSERT [dbo].[MesinAbsens] ON
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'1', N'GI1', N'192.168.2.83', N'1', N'2022-03-19 16:53:40.0000000', N'0', N'0001-01-01 00:00:00.0000000', N'0', N'4370', N'1', N'0')
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'3', N'GI2 Pos', N'192.168.94.94', N'1', N'2022-06-09 10:11:13.0000000', N'0', N'0001-01-01 00:00:00.0000000', N'0', N'4370', N'3', N'0')
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'4', N'SKM_2', N'192.168.90.16', N'1', N'2022-04-03 13:59:48.0000000', N'0', N'0001-01-01 00:00:00.0000000', N'0', N'4370', N'2', N'0')
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'5', N'SKM_4', N'192.168.95.35', N'1', N'2023-08-09 00:00:00.0000000', N'0', N'0001-01-01 00:00:00.0000000', N'0', N'4370', N'4', N'0')
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'10', N'GI2-Mesin3', N'192.168.2.85', N'1', N'2024-08-13 15:12:32.7490000', N'1', N'2024-08-13 15:12:32.7490000', N'1', N'4370', N'5', N'0')
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'11', N'GI2-Mesin1', N'192.168.2.83', N'1', N'2024-08-13 15:54:48.9470000', N'1', N'2024-08-13 15:54:48.9470000', N'1', N'4370', N'6', NULL)
GO

INSERT INTO [dbo].[MesinAbsens] ([DeviceID], [DeviceDesc], [DeviceIP], [IsActive], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy], [Port], [DeviceNo], [Connected]) VALUES (N'12', N'GI2-Mesin2', N'192.168.2.84', N'1', N'2024-08-13 15:01:58.5730000', N'1', N'2024-08-13 15:01:58.5730000', N'1', N'4370', N'7', NULL)
GO

SET IDENTITY_INSERT [dbo].[MesinAbsens] OFF
GO


-- ----------------------------
-- Auto increment value for MesinAbsens
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[MesinAbsens]', RESEED, 12)
GO


-- ----------------------------
-- Primary Key structure for table MesinAbsens
-- ----------------------------
ALTER TABLE [dbo].[MesinAbsens] ADD CONSTRAINT [PK_MesinAbsens] PRIMARY KEY CLUSTERED ([DeviceID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

