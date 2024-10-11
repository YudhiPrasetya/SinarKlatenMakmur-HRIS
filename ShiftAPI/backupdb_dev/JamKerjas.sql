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

 Date: 11/10/2024 09:16:20
*/


-- ----------------------------
-- Table structure for JamKerjas
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JamKerjas]') AND type IN ('U'))
	DROP TABLE [dbo].[JamKerjas]
GO

CREATE TABLE [dbo].[JamKerjas] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Deskripsi] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [DurasiPerHari] int  NOT NULL,
  [PembagiPayroll] int DEFAULT 0 NOT NULL
)
GO

ALTER TABLE [dbo].[JamKerjas] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of JamKerjas
-- ----------------------------
SET IDENTITY_INSERT [dbo].[JamKerjas] ON
GO

INSERT INTO [dbo].[JamKerjas] ([Id], [Deskripsi], [DurasiPerHari], [PembagiPayroll]) VALUES (N'1', N'5 Hari Kerja', N'8', N'21')
GO

SET IDENTITY_INSERT [dbo].[JamKerjas] OFF
GO


-- ----------------------------
-- Auto increment value for JamKerjas
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JamKerjas]', RESEED, 1)
GO


-- ----------------------------
-- Primary Key structure for table JamKerjas
-- ----------------------------
ALTER TABLE [dbo].[JamKerjas] ADD CONSTRAINT [PK_JamKerjas] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

