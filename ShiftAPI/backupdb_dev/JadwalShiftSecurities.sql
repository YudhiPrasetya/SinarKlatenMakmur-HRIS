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

 Date: 11/10/2024 09:16:08
*/


-- ----------------------------
-- Table structure for JadwalShiftSecurities
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[JadwalShiftSecurities]') AND type IN ('U'))
	DROP TABLE [dbo].[JadwalShiftSecurities]
GO

CREATE TABLE [dbo].[JadwalShiftSecurities] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Deskripsi] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NOT NULL,
  [JadwalMasuk] time(7)  NULL,
  [JadwalPulang] time(7)  NULL,
  [Initial] nvarchar(max) COLLATE SQL_Latin1_General_CP1_CI_AS  NULL
)
GO

ALTER TABLE [dbo].[JadwalShiftSecurities] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of JadwalShiftSecurities
-- ----------------------------
SET IDENTITY_INSERT [dbo].[JadwalShiftSecurities] ON
GO

INSERT INTO [dbo].[JadwalShiftSecurities] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Initial]) VALUES (N'1', N'Pagi', N'07:00:00.0000000', N'15:00:00.0000000', N'P')
GO

INSERT INTO [dbo].[JadwalShiftSecurities] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Initial]) VALUES (N'2', N'Siang', N'15:00:00.0000000', N'23:00:00.0000000', N'S')
GO

INSERT INTO [dbo].[JadwalShiftSecurities] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Initial]) VALUES (N'3', N'Malam', N'23:00:00.0000000', N'07:00:00.0000000', N'M')
GO

INSERT INTO [dbo].[JadwalShiftSecurities] ([Id], [Deskripsi], [JadwalMasuk], [JadwalPulang], [Initial]) VALUES (N'4', N'Libur', N'00:00:00.0000000', N'00:00:00.0000000', N'L')
GO

SET IDENTITY_INSERT [dbo].[JadwalShiftSecurities] OFF
GO


-- ----------------------------
-- Auto increment value for JadwalShiftSecurities
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[JadwalShiftSecurities]', RESEED, 4)
GO


-- ----------------------------
-- Primary Key structure for table JadwalShiftSecurities
-- ----------------------------
ALTER TABLE [dbo].[JadwalShiftSecurities] ADD CONSTRAINT [PK_JadwalShiftSecurities] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

