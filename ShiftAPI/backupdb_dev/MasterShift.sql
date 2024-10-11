/*
 Navicat Premium Data Transfer

 Source Server         : SQLServerExpress-Local
 Source Server Type    : SQL Server
 Source Server Version : 16001000 (16.00.1000)
 Source Host           : WINDOWS-B1ORSCN\SQLEXPRESS:1433
 Source Catalog        : ShiftDB
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 16001000 (16.00.1000)
 File Encoding         : 65001

 Date: 11/10/2024 09:16:45
*/


-- ----------------------------
-- Table structure for MasterShift
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterShift]') AND type IN ('U'))
	DROP TABLE [dbo].[MasterShift]
GO

CREATE TABLE [dbo].[MasterShift] (
  [id] int  IDENTITY(1,1) NOT NULL,
  [deskripsi] nvarchar(100) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL,
  [jam_masuk] time(7)  NULL,
  [jam_pulang] time(7)  NULL,
  [premi_per_jam] int  NULL
)
GO

ALTER TABLE [dbo].[MasterShift] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of MasterShift
-- ----------------------------
SET IDENTITY_INSERT [dbo].[MasterShift] ON
GO

SET IDENTITY_INSERT [dbo].[MasterShift] OFF
GO


-- ----------------------------
-- Auto increment value for MasterShift
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[MasterShift]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table MasterShift
-- ----------------------------
ALTER TABLE [dbo].[MasterShift] ADD CONSTRAINT [PK_MasterShift] PRIMARY KEY CLUSTERED ([id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

