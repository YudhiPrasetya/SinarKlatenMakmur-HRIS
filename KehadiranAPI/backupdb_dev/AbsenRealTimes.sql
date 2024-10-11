/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : KehadiranDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:10:21
*/


-- ----------------------------
-- Table structure for AbsenRealTimes
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[AbsenRealTimes]') AND type IN ('U'))
	DROP TABLE [dbo].[AbsenRealTimes]
GO

CREATE TABLE [dbo].[AbsenRealTimes] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [NIK] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Nama] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Gender] bit  NULL,
  [GroupKerja] varchar(255) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Tanggal] datetime2(7)  NULL,
  [IpMesin] varchar(20) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [Port] int  NULL,
  [NoMesin] int  NULL
)
GO

ALTER TABLE [dbo].[AbsenRealTimes] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of AbsenRealTimes
-- ----------------------------
SET IDENTITY_INSERT [dbo].[AbsenRealTimes] ON
GO

INSERT INTO [dbo].[AbsenRealTimes] ([Id], [NIK], [Nama], [Gender], [GroupKerja], [Tanggal], [IpMesin], [Port], [NoMesin]) VALUES (N'1', N'240410015', N'WINARTI ', N'0', N'SHIFT 1 LINE ENDANG 1', N'2024-08-14 13:49:27.1960541', N'192.168.94.94', N'4037', N'3')
GO

SET IDENTITY_INSERT [dbo].[AbsenRealTimes] OFF
GO


-- ----------------------------
-- Auto increment value for AbsenRealTimes
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[AbsenRealTimes]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table AbsenRealTimes
-- ----------------------------
ALTER TABLE [dbo].[AbsenRealTimes] ADD CONSTRAINT [PK__AbsenRea__3214EC0743AA6882] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

